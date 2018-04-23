Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			AddHandler spinEdit1.KeyPress, AddressOf spinEdit1_KeyPress
			spinEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
		End Sub
		Private Sub spinEdit1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			e.Handled = True
		End Sub
	End Class
End Namespace