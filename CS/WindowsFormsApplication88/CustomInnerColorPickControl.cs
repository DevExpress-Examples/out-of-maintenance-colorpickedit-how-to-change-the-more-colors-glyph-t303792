using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication88 {
    public class CustomInnerColorPickControl : InnerColorPickControl {
        public CustomInnerColorPickControl() : base() {

        }
        protected override BaseStyleControlViewInfo CreateViewInfo() {
            return new CustomInnerColorPickControlViewInfo(this);
        }
    }
}
