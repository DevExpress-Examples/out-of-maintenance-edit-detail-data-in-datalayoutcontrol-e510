Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication204
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Suppliers' table. You can move, or remove it, as needed.
			Me.suppliersTableAdapter.Fill(Me.nwindDataSet.Suppliers)

		End Sub

		Private Sub gridControl1_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gridControl1.EmbeddedNavigator.ButtonClick
			If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Custom Then
				ShowEditForm()
			ElseIf e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Append Then
				suppliersBindingSource.AddNew()
				ShowEditForm()
				e.Handled = True
			End If
		End Sub

		Private Sub ShowEditForm()
			Dim f As New Form2()
			f.DataSource = gridControl1.DataSource
			If f.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				suppliersBindingSource.EndEdit()
			Else
				suppliersBindingSource.CancelEdit()
			End If
			f.Dispose()
		End Sub
	End Class
End Namespace