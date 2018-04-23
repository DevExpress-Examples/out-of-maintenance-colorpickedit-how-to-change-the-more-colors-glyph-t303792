Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication88
    Public Class CustomInnerColorPickControl
        Inherits InnerColorPickControl

        Public Sub New()
            MyBase.New()

        End Sub
        Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
            Return New CustomInnerColorPickControlViewInfo(Me)
        End Function
    End Class
End Namespace
