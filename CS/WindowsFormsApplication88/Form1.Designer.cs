namespace WindowsFormsApplication88 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.customColorPickEdit1 = new WindowsFormsApplication88.CustomColorPickEdit();
            ((System.ComponentModel.ISupportInitialize)(this.customColorPickEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customColorPickEdit1
            // 
            this.customColorPickEdit1.EditValue = System.Drawing.Color.Empty;
            this.customColorPickEdit1.Location = new System.Drawing.Point(12, 12);
            this.customColorPickEdit1.Name = "customColorPickEdit1";
            this.customColorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customColorPickEdit1.Size = new System.Drawing.Size(333, 20);
            this.customColorPickEdit1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 265);
            this.Controls.Add(this.customColorPickEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customColorPickEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomColorPickEdit customColorPickEdit1;
    }
}

