Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication204
	Partial Public Class Form2
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Property DataSource() As Object
			Get
				Return dataLayoutControl1.DataSource
			End Get
			Set(ByVal value As Object)
				dataLayoutControl1.DataSource = value
			End Set
		End Property
	End Class
End Namespace