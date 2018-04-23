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
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing.Native
Imports DevExpress.XtraPrinting.Native

Namespace RibbonPrintPreviewDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXRibbonWindow
		Public Sub New()
			InitializeComponent()
		End Sub

		Shared Sub New()
			BarManager.CheckBarItemNames = False
			ThemeManager.ApplicationThemeName = "Office2010Black"
		End Sub

		Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim report As New XtraReport1()
			CType(preview.Model, XtraReportPreviewModel).Report = report
			report.CreateDocument(False)
		End Sub

		Private Sub documentMap_SelectedItemChanged(ByVal sender As Object, ByVal e As RoutedPropertyChangedEventArgs(Of Object))
			Dim model As XtraReportPreviewModel = CType(preview.Model, XtraReportPreviewModel)

			If model IsNot Nothing Then
				model.DocumentMapSelectedNode = TryCast(e.NewValue, DocumentMapTreeViewNode)
			End If
		End Sub

	End Class
End Namespace
