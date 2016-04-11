//---------------------------------------------------------------------
// 
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
//KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//PARTICULAR PURPOSE.
//---------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.Design;

namespace AdvancedDataGridView
{
	/// <summary>
	/// Summary description for form.
	/// </summary>
	public partial class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, System.EventArgs e)
		{
            attachmentColumn.DefaultCellStyle.NullValue = null;

            // load image strip
            this.imageStrip.ImageSize = new System.Drawing.Size(16, 16);
            this.imageStrip.TransparentColor = System.Drawing.Color.Magenta;
            this.imageStrip.ImageSize = new Size(16, 16);
            this.imageStrip.Images.AddStrip(Properties.Resources.newGroupPostIconStrip);
            
            treeGridView1.ImageList = imageStrip;

            // attachment header cell
            this.attachmentColumn.HeaderCell = new AttachmentColumnHeader(imageStrip.Images[2]);

		}

        private void Form1_Shown(object sender, EventArgs e)
        {
            Font boldFont = new Font(treeGridView1.DefaultCellStyle.Font, FontStyle.Bold);

            TreeGridNode node = treeGridView1.Nodes.Add(null, "Using DataView filter when binding to DataGridView", "tab", @"10/19/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Nodes.Add(null, "Re: Using DataView filter when binding to DataGridView", "tab", @"10/19/2005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"Using CurrencyManager's ItemChanged Event correctly", "michael", @"11/27/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Nodes.Add(null, "Re: Using CurrencyManager's ItemChanged Event correctly", "tab", @"10/19/2005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"updgrade vb6 to .net adodc", "howie", @"11/27/2005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"threads for reading data to textarea", "ajijv", @"11/20/2005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"SQL Server and DataSet bound to DataGridView", "tab", @"11/20/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Nodes.Add(null, "Re: SQL Server and DataSet bound to DataGridView", "Bart Mermuys", @"10/19/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"SQL Server timeout", "sybn", @"11/7/2005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"Selecting rows in the DataGrid", "jez", @"10/3/2005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"Referring to boundfields properties", "mikeslaptop", @"10/17/2005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"NEWBIE with database connection error", @"No_So_Clever", @"10/24/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Nodes.Add(null, "Re: NEWBIE with database connection error", "Jerry H", @"10/31/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"Referring to boundfields properties", "mikeslaptop", @"10/17/2005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"Partial load of data", "james", @"10/19/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"Master-details query", "pinerallo", @"10/29/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"How to access a datagrid column", "mervin", @"11/1/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"Empty table", "guy", @"10/26/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"Deepbinding: ICustomTypeDescriptor problem", @"kpax", @"10/12/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Nodes.Add(null, "Re: Deepbinding: ICustomTypeDescriptor problem", "Mervin", @"10/31/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Parent.Nodes.Add(null, "Re: Deepbinding: ICustomTypeDescriptor problem", "Jerry H", @"10/31/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Nodes.Add(null, "Re: Deepbinding: ICustomTypeDescriptor problem", "james", @"10/31/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Nodes.Add(null, "Re: Deepbinding: ICustomTypeDescriptor problem", "Mark", @"10/31/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Parent.Nodes.Add(null, "Re: Deepbinding: ICustomTypeDescriptor problem", "Jerry H", @"10/31/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"Datasource propert in usercontrol", "mamaike", @"10/23/32005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"DataGridView insert record", "Stephen", @"11/24/32005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"GridView null values", "Stanislav Nedelchev", @"11/29/32005 1:02 AM");
            node.ImageIndex = 1;

            node = treeGridView1.Nodes.Add(null, @"Current position", "No_So_Clever", @"11/8/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"ComboBox inside of datgrid", "Rick", @"11/24/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"Quick question about datagrid", "Sowen", @"11/14/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;
            node = node.Nodes.Add(null, "Re: Quick question about datagrid", "Jerry H", @"10/31/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"Best single documentation source for Binding", "Michael", @"11/2/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

            node = treeGridView1.Nodes.Add(null, @"Bind dataset to crystal report", "Sanjeewa", @"11/24/2005 1:02 AM");
            node.ImageIndex = 0;
            node.DefaultCellStyle.Font = boldFont;

        }


        internal class AttachmentColumnHeader : DataGridViewColumnHeaderCell
        {
            public Image _image;
            public AttachmentColumnHeader(Image img)
                : base()
            {
                this._image = img;
            }
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(_image, cellBounds.X + 4, cellBounds.Y + 2);
            }
            protected override object GetValue(int rowIndex)
            {
                return null;
            }
        }

	}
	
}

