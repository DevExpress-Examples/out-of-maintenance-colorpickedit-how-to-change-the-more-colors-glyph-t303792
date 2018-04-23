using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;

namespace WindowsFormsApplication88 {
    [ToolboxItem(true)]
    public class CustomColorPickEdit : ColorPickEdit {
        static CustomColorPickEdit() {
            RepositoryItemCustomColorPickEdit.RegisterCustomColorPickEdit();
        }

        public CustomColorPickEdit() {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomColorPickEdit Properties {
            get {
                return base.Properties as RepositoryItemCustomColorPickEdit;
            }
        }

        public override string EditorTypeName {
            get {
                return RepositoryItemCustomColorPickEdit.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm() {
            return new CustomColorPickEditPopupForm(this);
        }
    }
}
