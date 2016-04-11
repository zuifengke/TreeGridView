namespace Simple_Test_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AdvancedDataGridView.TreeGridNode treeGridNode1 = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode treeGridNode2 = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode treeGridNode3 = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode treeGridNode4 = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode treeGridNode5 = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode treeGridNode6 = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode treeGridNode7 = new AdvancedDataGridView.TreeGridNode();
            AdvancedDataGridView.TreeGridNode treeGridNode8 = new AdvancedDataGridView.TreeGridNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeGridView1 = new AdvancedDataGridView.TreeGridView();
            this.treeColumn = new AdvancedDataGridView.TreeGridColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeGridView1
            // 
            this.treeGridView1.AllowUserToAddRows = false;
            this.treeGridView1.AllowUserToDeleteRows = false;
            this.treeGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.treeGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treeColumn,
            this.nameColumn,
            this.descriptionColumn});
            this.treeGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.treeGridView1.ImageList = this.imageList1;
            this.treeGridView1.Location = new System.Drawing.Point(0, 0);
            this.treeGridView1.Name = "treeGridView1";
            treeGridNode1.Height = 23;
            treeGridNode1.ImageIndex = 0;
            treeGridNode2.Height = 23;
            treeGridNode2.ImageIndex = 11;
            treeGridNode1.Nodes.Add(treeGridNode2);
            treeGridNode3.Height = 23;
            treeGridNode3.ImageIndex = 13;
            treeGridNode4.Height = 23;
            treeGridNode4.ImageIndex = 7;
            treeGridNode5.Height = 23;
            treeGridNode5.ImageIndex = 15;
            treeGridNode6.Height = 23;
            treeGridNode6.ImageIndex = 0;
            treeGridNode7.Height = 23;
            treeGridNode7.ImageIndex = 9;
            treeGridNode8.Height = 23;
            treeGridNode8.ImageIndex = 10;
            treeGridNode7.Nodes.Add(treeGridNode8);
            treeGridNode6.Nodes.Add(treeGridNode7);
            this.treeGridView1.Nodes.Add(treeGridNode1);
            this.treeGridView1.Nodes.Add(treeGridNode3);
            this.treeGridView1.Nodes.Add(treeGridNode4);
            this.treeGridView1.Nodes.Add(treeGridNode5);
            this.treeGridView1.Nodes.Add(treeGridNode6);
            this.treeGridView1.RowHeadersVisible = false;
            this.treeGridView1.Size = new System.Drawing.Size(425, 265);
            this.treeGridView1.TabIndex = 0;
            // 
            // treeColumn
            // 
            this.treeColumn.DefaultNodeImage = null;
            this.treeColumn.HeaderText = "Tree";
            this.treeColumn.Name = "treeColumn";
            this.treeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cdmusic.ico");
            this.imageList1.Images.SetKeyName(1, "cellphone.ico");
            this.imageList1.Images.SetKeyName(2, "CONTACTS.ICO");
            this.imageList1.Images.SetKeyName(3, "delete_16x.ico");
            this.imageList1.Images.SetKeyName(4, "disconnect2.ico");
            this.imageList1.Images.SetKeyName(5, "disconnect3.ico");
            this.imageList1.Images.SetKeyName(6, "document.ico");
            this.imageList1.Images.SetKeyName(7, "error.ico");
            this.imageList1.Images.SetKeyName(8, "GenVideoDoc.ico");
            this.imageList1.Images.SetKeyName(9, "globe.ico");
            this.imageList1.Images.SetKeyName(10, "group.ico");
            this.imageList1.Images.SetKeyName(11, "help.ico");
            this.imageList1.Images.SetKeyName(12, "helpdoc.ico");
            this.imageList1.Images.SetKeyName(13, "homenet.ico");
            this.imageList1.Images.SetKeyName(14, "hotplug.ico");
            this.imageList1.Images.SetKeyName(15, "ICS client.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 265);
            this.Controls.Add(this.treeGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedDataGridView.TreeGridView treeGridView1;
        private AdvancedDataGridView.TreeGridColumn treeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.ImageList imageList1;
    }
}

