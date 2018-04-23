using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication88 {
    [UserRepositoryItem("RegisterCustomColorPickEdit")]
    public class RepositoryItemCustomColorPickEdit : RepositoryItemColorPickEdit {
        static RepositoryItemCustomColorPickEdit() {
            RegisterCustomColorPickEdit();
        }

        public const string CustomEditName = "CustomColorPickEdit";

        public RepositoryItemCustomColorPickEdit() {
        }

        public override string EditorTypeName {
            get {
                return CustomEditName;
            }
        }

        public static void RegisterCustomColorPickEdit() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomColorPickEdit), typeof(RepositoryItemCustomColorPickEdit), typeof(ColorEditViewInfo), new ColorEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomColorPickEdit source = item as RepositoryItemCustomColorPickEdit;
                if (source == null) return;
                //
            } finally {
                EndUpdate();
            }
        }
    }

}
