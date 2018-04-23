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
Imports DevExpress.Xpf.Grid

Namespace MyGridControl
	''' <summary>
	''' Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
	'''
	''' Step 1a) Using this custom control in a XAML file that exists in the current project.
	''' Add this XmlNamespace attribute to the root element of the markup file where it is 
	''' to be used:
	'''
	'''     xmlns:MyNamespace="clr-namespace:MyGridControl"
	'''
	'''
	''' Step 1b) Using this custom control in a XAML file that exists in a different project.
	''' Add this XmlNamespace attribute to the root element of the markup file where it is 
	''' to be used:
	'''
	'''     xmlns:MyNamespace="clr-namespace:MyGridControl;assembly=MyGridControl"
	'''
	''' You will also need to add a project reference from the project where the XAML file lives
	''' to this project and Rebuild to avoid compilation errors:
	'''
	'''     Right click on the target project in the Solution Explorer and
	'''     "Add Reference"->"Projects"->[Select this project]
	'''
	'''
	''' Step 2)
	''' Go ahead and use your control in the XAML file.
	'''
	'''     <MyNamespace:CustomControl1/>
	'''
	''' </summary>

	Public Class MyGridControl
		Inherits GridControl
		Protected Overrides Sub OnPropertyChanged(ByVal e As DependencyPropertyChangedEventArgs)
			If e.Property Is GridControl.FilterCriteriaProperty Then
				MessageBox.Show(e.NewValue.ToString())
			End If
			MyBase.OnPropertyChanged(e)
		End Sub

	End Class
End Namespace
