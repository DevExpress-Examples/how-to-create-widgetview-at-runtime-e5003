Imports Microsoft.VisualBasic
Imports System
Namespace WidgetViewExample
	Public Partial Class ucMaximizedContent
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label1.Location = New System.Drawing.Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(150, 150)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Maximized Content"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' ucMaximizedContent
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.label1)
			Me.Name = "ucMaximizedContent"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace
