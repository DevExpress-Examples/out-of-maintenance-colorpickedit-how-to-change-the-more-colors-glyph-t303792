Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Popup

Namespace WindowsFormsApplication88
    <ToolboxItem(True)> _
    Public Class CustomColorPickEdit
        Inherits ColorPickEdit

        Shared Sub New()
            RepositoryItemCustomColorPickEdit.RegisterCustomColorPickEdit()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomColorPickEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomColorPickEdit)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomColorPickEdit.CustomEditName
            End Get
        End Property

        Protected Overrides Function CreatePopupForm() As PopupBaseForm
            Return New CustomColorPickEditPopupForm(Me)
        End Function
    End Class
End Namespace
