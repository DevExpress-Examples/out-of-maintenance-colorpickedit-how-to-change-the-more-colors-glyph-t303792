using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication88 {
    public class CustomColorPickEditPopupForm : PopupColorPickEditForm {
        public CustomColorPickEditPopupForm(CustomColorPickEdit ownerEdit) : base(ownerEdit) {
        }
        protected override PopupColorBuilder CreatePopupColorEditBuilder() {
            return new CustomPopupColorBuilder(this);
        }
    }
}
