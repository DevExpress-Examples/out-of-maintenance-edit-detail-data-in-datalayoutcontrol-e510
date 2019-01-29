Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace WindowsApplication204
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function CreateTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow

			table.Columns.Add("SupplierID", GetType(Integer))
			table.Columns.Add("CompanyName", GetType(String))
			table.Columns.Add("ContactName", GetType(String))
			table.Columns.Add("ContactTitle", GetType(String))
			table.Columns.Add("Address", GetType(String))
			table.Columns.Add("City", GetType(String))
			table.Columns.Add("Region", GetType(String))
			table.Columns.Add("PostalCode", GetType(String))
			table.Columns.Add("Country", GetType(String))
			table.Columns.Add("Phone", GetType(String))
			table.Columns.Add("Fax", GetType(String))
			table.Columns.Add("HomePage", GetType(String))

			dataRow = table.NewRow()
			dataRow("SupplierID") = 1
			dataRow("CompanyName") = "Exotic Liquids"
			dataRow("ContactName") = "Charlotte Cooper"
			dataRow("ContactTitle") = "Purchasing Manager"
			dataRow("Address") = "49 Gilbert St."
			dataRow("City") = "London"
			dataRow("Region") = ""
			dataRow("PostalCode") = "EC1 4SD"
			dataRow("Country") = "UK"
			dataRow("Phone") = "(171) 555-2222"
			dataRow("Fax") = ""
			dataRow("HomePage") = ""
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("SupplierID") = 2
			dataRow("CompanyName") = "New Orleans Cajun Delights"
			dataRow("ContactName") = "Shelley Burke"
			dataRow("ContactTitle") = "Order Administrator"
			dataRow("Address") = "P.O. Box 78934"
			dataRow("City") = "New Orleans"
			dataRow("Region") = "LA"
			dataRow("PostalCode") = "70117"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(100) 555-4822"
			dataRow("Fax") = ""
			dataRow("HomePage") = "#CAJUN.HTM#"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("SupplierID") = 3
			dataRow("CompanyName") = "Grandma Kelly's Homestead"
			dataRow("ContactName") = "Regina Murphy"
			dataRow("ContactTitle") = "Sales Representative"
			dataRow("Address") = "707 Oxford Rd."
			dataRow("City") = "Ann Arbor"
			dataRow("Region") = "MI"
			dataRow("PostalCode") = "48104"
			dataRow("Country") = "USA"
			dataRow("Phone") = "(313) 555-5735"
			dataRow("Fax") = "(313) 555-3349"
			dataRow("HomePage") = ""
			table.Rows.Add(dataRow)

			Return table
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim table As DataTable = CreateTable()
			suppliersBindingSource.DataSource = table
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