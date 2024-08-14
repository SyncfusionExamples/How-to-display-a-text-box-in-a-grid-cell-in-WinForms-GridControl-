# How-to-display-a-text-box-in-a-grid-cell-in-WinForms-GridControl-
How to display a text box in a grid cell in WinForms GridControl?
<div class="Section0"><h2 style="color: #365f91;font-family: cambria;font-size: 13pt;font-style: normal;font-variant: normal;font-weight: normal;line-height: 115%;margin-bottom: 0pt;margin-top: 2pt;page-break-after: avoid;page-break-before: avoid;page-break-inside: avoid;text-align: left;text-transform: none;"><span style="color:#365F91;font-family:Calibri Light;font-size:13pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;line-height:115%;" lang="en-US">Display a text box in grid</span></h2>
<p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;line-height:normal;margin-top:0pt;margin-bottom:6pt;"><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;" lang="en-US">By default, each cell in a </span><a style="color:#0000FF;font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;text-decoration: underline;" href="https://www.syncfusion.com/winforms-ui-controls/grid-control" title="">WinForms Grid Control</a><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;" lang="en-US"> is a type of textbox. To add the TextBox to the grid cell and bring it to the front of the cell, use the following method.</span></p>
<p style="text-align:left;page-break-inside:auto;page-break-after:avoid;page-break-before:avoid;line-height:normal;margin-top:0pt;margin-bottom:6pt;"><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:bold;font-style:normal;font-variant:normal;" lang="en-US">Solution</span></p>
<p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;line-height:normal;margin-top:0pt;margin-bottom:6pt;"><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;" lang="en-US">To add a </span><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:bold;font-style:normal;font-variant:normal;" lang="en-US">TextBox</span><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;" lang="en-US"> on a cell, create an object for the </span><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:bold;font-style:normal;font-variant:normal;" lang="en-US">TextBox</span><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;" lang="en-US"> class and add it to the </span><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:bold;font-style:normal;font-variant:normal;" lang="en-US">Grid.Controls</span><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;" lang="en-US"> collection. In the provided sample the textbox is displayed while entering the text in the current cell.</span></p>
<p style="text-align:left;page-break-inside:auto;page-break-after:avoid;page-break-before:avoid;line-height:normal;margin-top:0pt;margin-bottom:6pt;"><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:bold;font-style:normal;font-variant:normal;" lang="en-US">C#</span></p>
<div class="codesnippet"><pre class="highlight">//Create the instance for textbox
TextBox text = new TextBox();
public Form1()
{
&nbsp;&nbsp; InitializeComponent();
&nbsp;&nbsp; text.Visible = false;
&nbsp;&nbsp; //Add the texbox to the grid
&nbsp;&nbsp; this.gridControl1.Controls.Add(text);
&nbsp;&nbsp; //Hook the event to get the textbox at the front of the grid.
&nbsp;&nbsp; this.gridControl1.CurrentCellKeyPress += new&nbsp;&nbsp;&nbsp; KeyPressEventHandler(gridControl1_CurrentCellKeyPress);
}
void gridControl1_CurrentCellKeyPress(object sender, KeyPressEventArgs e)
{
&nbsp;&nbsp; GridCurrentCell cc = this.gridControl1.CurrentCell;
&nbsp;&nbsp; //Get the co-ordinates of the current cell
&nbsp;&nbsp; Rectangle rect = this.gridControl1.RangeInfoToRectangle(GridRangeInfo.Cell(cc.RowIndex, cc.ColIndex));
&nbsp;&nbsp; //Move the location of the textbox to the current cell
&nbsp;&nbsp; text.Location = rect.Location;
&nbsp;&nbsp; //Set the size for the textbox
&nbsp;&nbsp; text.Size = rect.Size;
&nbsp;&nbsp; text.Visible = true;
&nbsp;&nbsp; //Set the focus to the TextBox
&nbsp;&nbsp; text.Focus();
&nbsp;&nbsp; text.BringToFront();
}
</pre><div><br></div></div><p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;line-height:115%;margin-top:0pt;margin-bottom:10pt;"><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:bold;font-style:normal;font-variant:normal;line-height:115%;" lang="en-US">VB</span></p>
<div class="codesnippet"><pre class="language-vb highlight">'Create the instance for textbox
Private text As New TextBox()
Public Sub New()
&nbsp;&nbsp; InitializeComponent()
&nbsp;&nbsp; text.Visible = False
&nbsp;&nbsp; 'Add the texbox to the grid
&nbsp;&nbsp; Me.gridControl1.Controls.Add(text)
&nbsp;&nbsp; 'Hook the event to get the textbox at the front of the grid.
&nbsp;&nbsp; AddHandler gridControl1.CurrentCellKeyPress, AddressOf&nbsp;&nbsp;&nbsp; gridControl1_CurrentCellKeyPress
End Sub
Private Sub gridControl1_CurrentCellKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
&nbsp;&nbsp; Dim cc As GridCurrentCell = Me.gridControl1.CurrentCell
&nbsp;&nbsp; 'Get the co-ordinates of the current cell
&nbsp;&nbsp; Dim rect As Rectangle = Me.gridControl1.RangeInfoToRectangle(GridRangeInfo.Cell(cc.RowIndex, cc.ColIndex))
&nbsp;&nbsp; 'Move the location of the textbox to the current cell
&nbsp;&nbsp; text.Location = rect.Location
&nbsp;&nbsp; 'Set the size for the textbox
&nbsp;&nbsp; text.Size = rect.Size
&nbsp;&nbsp; text.Visible = True
&nbsp;&nbsp; 'Set the focus to the TextBox
&nbsp;&nbsp; text.Focus()
&nbsp;&nbsp; text.BringToFront()
End Sub
</pre></div><p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;line-height:normal;margin-top:3pt;margin-bottom:6pt;"><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;" lang="en-US">The following screenshot displays the textbox displayed in a </span><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:bold;font-style:normal;font-variant:normal;" lang="en-US">Grid</span><span style="font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;" lang="en-US"> while entering the text in a current cell.</span></p>
<p class="No-Spacing" style="font-family: calibri;font-size: 11pt;font-style: normal;font-variant: normal;font-weight: normal;line-height: normal;margin-bottom: 0pt;margin-top: 0pt;page-break-after: avoid;page-break-before: avoid;page-break-inside: auto;text-align: left;text-transform: none;"><img src="https://www.syncfusion.com/uploads/user/kb/wf/wf-18629/wf-18629_img1.png" width="468" height="269" alt="Textbox displayed in a grid" class="e-rte-image e-imginline"></p>
<p class="Caption" style="color: #1f497d;font-family: calibri;font-size: 9pt;font-style: italic;font-variant: normal;font-weight: normal;line-height: normal;margin-bottom: 10pt;margin-top: 0pt;page-break-after: auto;page-break-before: avoid;page-break-inside: auto;text-align: left;text-transform: none;"><span style="color:#1F497D;font-family:Calibri;font-size:9pt;text-transform:none;font-weight:normal;font-style:italic;font-variant:normal;" lang="en-US">Figure </span><!--[if supportFields]><span style="mso-element:field-begin"></span><span lang="en-US" style="color:#1F497D;font-family:Calibri;font-size:9pt;text-transform:none;font-weight:normal;font-style:italic;font-variant:normal;"> SEQ Figure \* ARABIC </span><span style="mso-element:field-separator"></span><![endif]--><span style="color:#1F497D;font-family:Calibri;font-size:9pt;text-transform:none;font-weight:normal;font-style:italic;font-variant:normal;" lang="en-US">1</span><!--[if supportFields]><span style="mso-element:field-end"></span><![endif]--><span style="color:#1F497D;font-family:Calibri;font-size:9pt;text-transform:none;font-weight:normal;font-style:italic;font-variant:normal;" lang="en-US">: Textbox displayed in a Grid</span></p>
<p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;line-height:normal;margin-top:0pt;margin-bottom:6pt;"><span style="color:#0000FF;font-family:Calibri;font-size:11pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;">&nbsp;</span></p>
<div><p style="margin-top:0cm;margin-right:0cm;margin-bottom:8.0pt;margin-left:0cm;
line-height:12.85pt;background:white;font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;"><b><span lang="EN-US" style="font-size:
11.0pt;font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">Conclusion</span></b></p><p style="margin-top:0cm;margin-right:0cm;margin-bottom:8.0pt;margin-left:0cm;
line-height:12.85pt;background:white;font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;"><span lang="EN-US" style="font-size:11.0pt;
font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">I hope you enjoyed learning about how to display a
text box in a grid cell in WinForms GridControl.</span></p><p style="margin-top:0cm;margin-right:0cm;margin-bottom:8.0pt;margin-left:0cm;
line-height:12.85pt;background:white;font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;"><span lang="EN-US" style="font-size:11.0pt;
font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">You can refer to our&nbsp;</span><span lang="en-KE" style="color:black;"><a href="https://www.syncfusion.com/winforms-ui-controls/grid-control" target="_blank" rel="noopener noreferrer" aria-label="Open in new window"><span><span lang="EN-US" style="font-size:11.0pt;
font-family:&quot;Calibri&quot;,sans-serif;color:#0563C1;text-decoration:none;">WinForms
GridControl feature tour</span></span><span lang="EN-US" style="font-size:11.0pt;
font-family:&quot;Calibri&quot;,sans-serif;color:#0565FF;text-decoration:none;">&nbsp;</span></a></span><span lang="en-KE" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">page to know about its
other&nbsp;groundbreaking feature representations.</span><span lang="en-KE" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;"> </span><span lang="en-KE" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">You can also explore our</span><span lang="en-KE" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;"> </span><span lang="en-KE" style="color:black;"><a href="https://help.syncfusion.com/windowsforms/grid-control/getting-started" target="_blank" rel="noopener noreferrer" aria-label="Open in new window"><span lang="EN-US" style="font-family:&quot;Calibri&quot;,sans-serif;text-decoration:none;">documentation</span></a></span><span lang="EN-US" style="font-family:&quot;Calibri&quot;,sans-serif;color:black;"> </span><span lang="en-KE" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">to understand how to create and manipulate data.</span></p><p style="margin-top:0cm;margin-right:0cm;margin-bottom:8.0pt;margin-left:0cm;
line-height:12.85pt;background:white;font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;"><span lang="en-KE" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">For current customers,&nbsp;you
can check out our&nbsp;components</span><span lang="en-KE" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">&nbsp;from the&nbsp;</span><span lang="en-KE" style="color:black;"><a href="https://www.syncfusion.com/sales/teamlicense" target="_blank" rel="noopener noreferrer" aria-label="Open in new window"><span style="font-family:
&quot;Calibri&quot;,sans-serif;color:#0565FF;">License
and Downloads</span></a></span><span lang="en-KE" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">&nbsp;page.&nbsp;If you are new
to Syncfusion, you can try our 30-day&nbsp;</span><span lang="en-KE" style="color:black;"><a href="https://www.syncfusion.com/downloads/windowsforms" target="_blank" rel="noopener noreferrer" aria-label="Open in new window"><span style="font-family:&quot;Calibri&quot;,sans-serif;">free trial&nbsp;</span></a></span><span lang="en-KE" style="font-family:
&quot;Calibri&quot;,sans-serif;color:#2D3748;">to
check out our other controls.</span></p><p style="margin-top:0cm;margin-right:0cm;margin-bottom:8.0pt;margin-left:0cm;
line-height:12.85pt;background:white;font-size:12.0pt;font-family:&quot;Times New Roman&quot;,serif;"><span lang="EN-US" style="font-size:11.0pt;
font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">If </span><span lang="EN-US" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">you have
any queries or require clarifications, please let us know in comments below.
You can also contact us through our&nbsp;</span><span lang="en-KE" style="color:black;"><a href="https://www.syncfusion.com/forums" target="_blank" rel="noopener noreferrer" aria-label="Open in new window"><span><span lang="EN-US" style="font-family:&quot;Calibri&quot;,sans-serif;color:#0563C1;text-decoration:none;">support forums</span></span></a></span><span lang="EN-US" style="font-family:
&quot;Calibri&quot;,sans-serif;color:#2D3748;">,&nbsp;</span><span lang="en-KE" style="color:black;"><a href="https://support.syncfusion.com/create" target="_blank" rel="noopener noreferrer" aria-label="Open in new window"><span><span lang="EN-US" style="font-family:&quot;Calibri&quot;,sans-serif;color:#0563C1;
text-decoration:none;">Direct-Trac</span></span></a></span><span lang="EN-US" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">, or&nbsp;</span><span lang="en-KE" style="color:black;"><a href="https://www.syncfusion.com/feedback/winforms?control=gridcontrol" target="_blank" rel="noopener noreferrer" aria-label="Open in new window"><span><span lang="EN-US" style="font-family:&quot;Calibri&quot;,sans-serif;color:#0563C1;
text-decoration:none;">feedback portal</span></span></a></span><span lang="EN-US" style="font-family:&quot;Calibri&quot;,sans-serif;color:#2D3748;">&nbsp;We are always happy to
assist you!</span></p></div>
<p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;line-height:normal;margin-top:0pt;margin-bottom:6pt;"><br></p>
</div>