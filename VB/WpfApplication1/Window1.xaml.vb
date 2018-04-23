Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Xpf.Grid
Imports DevExpress.Data.Filtering

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Public Partial Class Window1
		Inherits Window
	   Private coll As List(Of ContactItem)
		Public Sub New()
			InitializeComponent()
			coll = New List(Of ContactItem)()

			Dim f1 As ContactItem = New ContactItem()
				f1.Name = "A"
				f1.Salary = 200
				coll.Add(f1)
				Dim f2 As ContactItem = New ContactItem()
				f2.Name = "B"
				f2.Salary = 100
				coll.Add(f2)

			gridControl1.DataSource = coll

		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			gridControl1.FilterCriteria = New BinaryOperator("Salary", 100, BinaryOperatorType.Greater)
		End Sub

	End Class
End Namespace
