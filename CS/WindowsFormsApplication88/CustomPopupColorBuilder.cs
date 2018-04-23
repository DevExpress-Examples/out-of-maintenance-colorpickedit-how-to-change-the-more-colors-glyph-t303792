using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication88 {
    public class CustomPopupColorBuilder : PopupColorBuilderEx {
        public CustomPopupColorBuilder(IPopupColorEdit owner) : base(owner) {

        }
        protected override InnerColorPickControl CreateCustomTabInnerControl() {
            return new CustomInnerColorPickControl();
        }
    }
}
