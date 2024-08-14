Imports Microsoft.VisualBasic
Imports System
Namespace GridControl_Demo4_6
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
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(49, 83)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(691, 204)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(114))))), (CInt(Fix((CByte(114))))), (CInt(Fix((CByte(114))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(150))))), (CInt(Fix((CByte(150))))), (CInt(Fix((CByte(150))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(171))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(171))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(171))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(171))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(197))))), (CInt(Fix((CByte(197))))), (CInt(Fix((CByte(197))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(150))))), (CInt(Fix((CByte(150))))), (CInt(Fix((CByte(150))))))
			Me.gridControl1.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(197))))), (CInt(Fix((CByte(197))))), (CInt(Fix((CByte(197))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(114))))), (CInt(Fix((CByte(114))))), (CInt(Fix((CByte(114))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(150))))), (CInt(Fix((CByte(150))))), (CInt(Fix((CByte(150))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(171))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(171))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(171))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(171))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(197))))), (CInt(Fix((CByte(197))))), (CInt(Fix((CByte(197))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(150))))), (CInt(Fix((CByte(150))))), (CInt(Fix((CByte(150))))))
			Me.gridControl1.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(197))))), (CInt(Fix((CByte(197))))), (CInt(Fix((CByte(197))))))
			Me.gridControl1.UseRightToLeftCompatibleTextBox = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
	End Class
End Namespace

