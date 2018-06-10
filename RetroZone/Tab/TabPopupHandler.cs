using DotNetBrowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroZone.Tab
{
    class TabPopupHandler : PopupHandler
    {
        private Control control;

        public TabPopupHandler(Control control)
        {
            this.control = control;
        }
        public PopupContainer HandlePopup(PopupParams popupParams)
        {
            Form form = control.FindForm();
            if (form != null)
            {
                return new CustomPopupContainer(form);
            }
            else
            {
                throw new InvalidOperationException("Main window can't be found");
            }
        }
    }
}
