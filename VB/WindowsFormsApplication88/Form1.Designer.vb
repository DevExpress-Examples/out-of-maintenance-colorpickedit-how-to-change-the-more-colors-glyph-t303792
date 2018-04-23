Namespace WindowsFormsApplication88
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.customColorPickEdit1 = New WindowsFormsApplication88.CustomColorPickEdit()
            DirectCast(Me.customColorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customColorPickEdit1
            ' 
            Me.customColorPickEdit1.EditValue = System.Drawing.Color.Empty
            Me.customColorPickEdit1.Location = New System.Drawing.Point(12, 12)
            Me.customColorPickEdit1.Name = "customColorPickEdit1"
            Me.customColorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.customColorPickEdit1.Size = New System.Drawing.Size(333, 20)
            Me.customColorPickEdit1.TabIndex = 1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(357, 265)
            Me.Controls.Add(Me.customColorPickEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.customColorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private customColorPickEdit1 As CustomColorPickEdit
    End Class
End Namespace

