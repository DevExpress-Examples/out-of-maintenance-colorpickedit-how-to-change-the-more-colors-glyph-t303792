Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication88
    Public Class CustomColorPickEditPopupForm
        Inherits PopupColorPickEditForm

        Public Sub New(ByVal ownerEdit As CustomColorPickEdit)
            MyBase.New(ownerEdit)
        End Sub
        Protected Overrides Function CreatePopupColorEditBuilder() As PopupColorBuilder
            Return New CustomPopupColorBuilder(Me)
        End Function
    End Class
End Namespace
