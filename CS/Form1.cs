using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridControl_Demo4_6
{
    public partial class Form1 : Form
    {
        //Create the instance for textbox
        TextBox text = new TextBox();
        public Form1()
        {
            InitializeComponent();
            gridControl1.RowCount = 15;
            gridControl1.ColCount = 4;
            //Looping through the cells and assigning the values based on row and column index
            for (int row = 1; row <= gridControl1.RowCount; row++)
            {
                for (int col = 1; col <= gridControl1.ColCount; col++)
                {
                    gridControl1.Model[row, col].CellValue = string.Format("{0}/{1}", row, col);
                }
            }
            text.Visible = false;
            //Add the texbox to the grid
            this.gridControl1.Controls.Add(text);
            //Hook the event to get the textbox at the front of the grid.
            this.gridControl1.CurrentCellKeyPress += new KeyPressEventHandler(gridControl1_CurrentCellKeyPress);
        }
        void gridControl1_CurrentCellKeyPress(object sender, KeyPressEventArgs e)
        {
            GridCurrentCell cc = this.gridControl1.CurrentCell;
            //Get the co-ordinates of the current cell
            Rectangle rect = this.gridControl1.RangeInfoToRectangle(GridRangeInfo.Cell(cc.RowIndex, cc.ColIndex));
            //Move the location of the textbox to the current cell
            text.Location = rect.Location;
            //Set the size for the textbox
            text.Size = rect.Size;
            text.Visible = true;
            //Set the focus to the TextBox
            text.Focus();
            text.BringToFront();
        }
    }
}
