Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports System.Windows
Imports System.ComponentModel

Namespace WpfApplication1
    Public Class ContactItem
        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property
        Private _salary As Decimal
        Public Property Salary() As Decimal
            Get
                Return _salary
            End Get
            Set(ByVal value As Decimal)
                _salary = value
            End Set
        End Property
    End Class
End Namespace
