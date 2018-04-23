Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication88
    Public Class CustomPopupColorBuilder
        Inherits PopupColorBuilderEx

        Public Sub New(ByVal owner As IPopupColorEdit)
            MyBase.New(owner)

        End Sub
        Protected Overrides Function CreateCustomTabInnerControl() As InnerColorPickControl
            Return New CustomInnerColorPickControl()
        End Function
    End Class
End Namespace
