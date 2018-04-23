using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsApplication88.Properties;

namespace WindowsFormsApplication88 {
    public class CustomInnerColorPickControlViewInfo : InnerColorPickControlViewInfo {
        public CustomInnerColorPickControlViewInfo(InnerColorPickControl owner) : base(owner) {

        }
        protected override Image LoadMoreButtonGlyph() {
            return GetLoadModeButtonGlyph();
            //return base.LoadMoreButtonGlyph();
        }
        internal Image GetLoadModeButtonGlyph() {
            return Resources.pictureshapefillcolor_32x32;
        }
    }
}
