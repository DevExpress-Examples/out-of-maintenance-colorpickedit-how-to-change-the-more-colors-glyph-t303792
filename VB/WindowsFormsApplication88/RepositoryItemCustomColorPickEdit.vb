Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication88
    <UserRepositoryItem("RegisterCustomColorPickEdit")> _
    Public Class RepositoryItemCustomColorPickEdit
        Inherits RepositoryItemColorPickEdit

        Shared Sub New()
            RegisterCustomColorPickEdit()
        End Sub

        Public Const CustomEditName As String = "CustomColorPickEdit"

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomColorPickEdit()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomColorPickEdit), GetType(RepositoryItemCustomColorPickEdit), GetType(ColorEditViewInfo), New ColorEditPainter(), True, img))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomColorPickEdit = TryCast(item, RepositoryItemCustomColorPickEdit)
                If source Is Nothing Then
                    Return
                End If
                '
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class

End Namespace
