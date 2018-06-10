using DotNetBrowser;
using DotNetBrowser.Events;
using DotNetBrowser.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RetroZone.Tab
{
    class CustomPopupContainer : PopupContainer
    {
        private Form parentForm;
        private Form form;
        private WinFormsBrowserView browserView;
        private bool formClosed = false;

        /// <summary>
        /// Constructor creates WinForms Popup Container based on parent form.
        /// </summary>
        public CustomPopupContainer(Form parentForm)
        {
            this.parentForm = parentForm;
        }

        /// <summary>
        /// Creates a WinForms popup window with embedded Browser instance.
        /// </summary>
        /// <param name="browser">the newly created browser.</param>
        /// <param name="initialBounds">initial bounds of popup window.</param>
        public void InsertBrowser(Browser browser, Rectangle initialBounds)
        {
            parentForm.BeginInvoke((Action)(() =>
            {
                Init(browser, initialBounds);
            }));
        }


        private void Init(Browser browser, Rectangle initialBounds)
        {
            browserView = new WinFormsBrowserView(browser);

            form = new Form();
            form.Icon = this.parentForm.Icon;

            if (!initialBounds.IsEmpty)
            {
                form.DesktopLocation = new Point(initialBounds.X, initialBounds.Y);
                form.ClientSize = new Size(initialBounds.Width, initialBounds.Height);
                browserView.UpdateSize(initialBounds.Width, initialBounds.Height);
            }
            else
            {
                form.Width = 800;
                form.Height = 600;
            }

            form.Closed += delegate
            {
                formClosed = true;
                form.Controls.Clear();
                browserView.Dispose();
                browser.Dispose();
            };

            browser.TitleChangedEvent += delegate (object sender, TitleEventArgs e)
            {
                form.BeginInvoke((Action)(() =>
                {
                    form.Text = e.Title;
                }));
            };

            browser.DisposeEvent += delegate (object sender, DisposeEventArgs e)
            {
                form.BeginInvoke((Action)(() =>
                {
                    if (!formClosed)
                    {
                        form.Controls.Clear();
                        form.Hide();
                        form.Close();
                        formClosed = true;
                    }
                }));
            };

            form.Controls.Add(browserView);
            form.Show();

        }
    }
}
