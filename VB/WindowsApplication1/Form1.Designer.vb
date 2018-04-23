Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(45, 39)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.Increment = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spinEdit1.Size = New System.Drawing.Size(100, 20)
			Me.spinEdit1.TabIndex = 0
			' 
			' spinEdit2
			' 
			Me.spinEdit2.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit2.Location = New System.Drawing.Point(157, 140)
			Me.spinEdit2.Name = "spinEdit2"
			Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit2.Size = New System.Drawing.Size(100, 20)
			Me.spinEdit2.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 273)
			Me.Controls.Add(Me.spinEdit2)
			Me.Controls.Add(Me.spinEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private spinEdit2 As DevExpress.XtraEditors.SpinEdit
	End Class
End Namespace

