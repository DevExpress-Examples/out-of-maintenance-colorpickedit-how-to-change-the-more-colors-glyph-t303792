Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication88
    Public Class CustomInnerColorPickControlViewInfo
        Inherits InnerColorPickControlViewInfo

        Public Sub New(ByVal owner As InnerColorPickControl)
            MyBase.New(owner)

        End Sub
        Protected Overrides Function LoadMoreButtonGlyph() As Image
            Return GetLoadModeButtonGlyph()
            'return base.LoadMoreButtonGlyph();
        End Function
        Friend Function GetLoadModeButtonGlyph() As Image
            Return My.Resources.pictureshapefillcolor_32x32
        End Function
    End Class
End Namespace
