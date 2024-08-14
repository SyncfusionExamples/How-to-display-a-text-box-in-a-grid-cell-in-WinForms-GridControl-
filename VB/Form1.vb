Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace GridControl_Demo4_6
	Partial Public Class Form1
		Inherits Form
		'Create the instance for textbox
		Private text_Renamed As New TextBox()
		Public Sub New()
			InitializeComponent()
			gridControl1.RowCount = 15
			gridControl1.ColCount = 4
			'Looping through the cells and assigning the values based on row and column index
			For row As Integer = 1 To gridControl1.RowCount
				For col As Integer = 1 To gridControl1.ColCount
					gridControl1.Model(row, col).CellValue = String.Format("{0}/{1}", row, col)
				Next col
			Next row
			text_Renamed.Visible = False
			'Add the texbox to the grid
			Me.gridControl1.Controls.Add(text_Renamed)
			'Hook the event to get the textbox at the front of the grid.
			AddHandler gridControl1.CurrentCellKeyPress, AddressOf gridControl1_CurrentCellKeyPress
		End Sub
		Private Sub gridControl1_CurrentCellKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			Dim cc As GridCurrentCell = Me.gridControl1.CurrentCell
			'Get the co-ordinates of the current cell
			Dim rect As Rectangle = Me.gridControl1.RangeInfoToRectangle(GridRangeInfo.Cell(cc.RowIndex, cc.ColIndex))
			'Move the location of the textbox to the current cell
			text_Renamed.Location = rect.Location
			'Set the size for the textbox
			text_Renamed.Size = rect.Size
			text_Renamed.Visible = True
			'Set the focus to the TextBox
			text_Renamed.Focus()
			text_Renamed.BringToFront()
		End Sub
	End Class
End Namespace
