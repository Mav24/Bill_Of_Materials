namespace ValcomDrawings
{
    partial class MainForm
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
            System.Windows.Forms.Label txtAddedBy;
            System.Windows.Forms.Label bOMDescriptionLabel;
            System.Windows.Forms.Label dateModifiedLabel;
            System.Windows.Forms.Label nSNLabel;
            System.Windows.Forms.Label drawingIDLabel1;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addedByTextBox = new System.Windows.Forms.TextBox();
            this.drawingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBOMDescription = new System.Windows.Forms.TextBox();
            this.dateModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtNSN = new System.Windows.Forms.TextBox();
            this.drawingLineDataGridView = new System.Windows.Forms.DataGridView();
            this.drawingLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawingIDComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDrawingChanges = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMnuNewDrawing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMnuModifyDeleteDrawing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolmnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMnuOpenParts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.btnAddLineItems = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtAddedBy = new System.Windows.Forms.Label();
            bOMDescriptionLabel = new System.Windows.Forms.Label();
            dateModifiedLabel = new System.Windows.Forms.Label();
            nSNLabel = new System.Windows.Forms.Label();
            drawingIDLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddedBy
            // 
            txtAddedBy.AutoSize = true;
            txtAddedBy.Location = new System.Drawing.Point(216, 122);
            txtAddedBy.Name = "txtAddedBy";
            txtAddedBy.Size = new System.Drawing.Size(67, 17);
            txtAddedBy.TabIndex = 1;
            txtAddedBy.Text = "Added By:";
            // 
            // bOMDescriptionLabel
            // 
            bOMDescriptionLabel.AutoSize = true;
            bOMDescriptionLabel.Location = new System.Drawing.Point(625, 41);
            bOMDescriptionLabel.Name = "bOMDescriptionLabel";
            bOMDescriptionLabel.Size = new System.Drawing.Size(106, 17);
            bOMDescriptionLabel.TabIndex = 3;
            bOMDescriptionLabel.Text = "BOMDescription:";
            // 
            // dateModifiedLabel
            // 
            dateModifiedLabel.AutoSize = true;
            dateModifiedLabel.Location = new System.Drawing.Point(216, 167);
            dateModifiedLabel.Name = "dateModifiedLabel";
            dateModifiedLabel.Size = new System.Drawing.Size(88, 17);
            dateModifiedLabel.TabIndex = 5;
            dateModifiedLabel.Text = "Date Created:";
            // 
            // nSNLabel
            // 
            nSNLabel.AutoSize = true;
            nSNLabel.Location = new System.Drawing.Point(216, 82);
            nSNLabel.Name = "nSNLabel";
            nSNLabel.Size = new System.Drawing.Size(38, 17);
            nSNLabel.TabIndex = 4;
            nSNLabel.Text = "NSN:";
            // 
            // drawingIDLabel1
            // 
            drawingIDLabel1.AutoSize = true;
            drawingIDLabel1.Location = new System.Drawing.Point(216, 41);
            drawingIDLabel1.Name = "drawingIDLabel1";
            drawingIDLabel1.Size = new System.Drawing.Size(75, 17);
            drawingIDLabel1.TabIndex = 0;
            drawingIDLabel1.Text = "&Drawing ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(625, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 17);
            label1.TabIndex = 5;
            label1.Text = "Date Modified:";
            // 
            // addedByTextBox
            // 
            this.addedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingBindingSource, "AddedBy", true));
            this.addedByTextBox.Enabled = false;
            this.addedByTextBox.Location = new System.Drawing.Point(328, 119);
            this.addedByTextBox.Name = "addedByTextBox";
            this.addedByTextBox.Size = new System.Drawing.Size(166, 25);
            this.addedByTextBox.TabIndex = 2;
            // 
            // drawingBindingSource
            // 
            this.drawingBindingSource.DataSource = typeof(ValcomData.Drawing);
            // 
            // txtBOMDescription
            // 
            this.txtBOMDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingBindingSource, "BOMDescription", true));
            this.txtBOMDescription.Enabled = false;
            this.txtBOMDescription.Location = new System.Drawing.Point(737, 38);
            this.txtBOMDescription.Name = "txtBOMDescription";
            this.txtBOMDescription.Size = new System.Drawing.Size(544, 25);
            this.txtBOMDescription.TabIndex = 4;
            // 
            // dateModifiedDateTimePicker
            // 
            this.dateModifiedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.drawingBindingSource, "DateCreated", true));
            this.dateModifiedDateTimePicker.Enabled = false;
            this.dateModifiedDateTimePicker.Location = new System.Drawing.Point(328, 161);
            this.dateModifiedDateTimePicker.Name = "dateModifiedDateTimePicker";
            this.dateModifiedDateTimePicker.Size = new System.Drawing.Size(243, 25);
            this.dateModifiedDateTimePicker.TabIndex = 6;
            // 
            // txtNSN
            // 
            this.txtNSN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingBindingSource, "NSN", true));
            this.txtNSN.Enabled = false;
            this.txtNSN.Location = new System.Drawing.Point(328, 79);
            this.txtNSN.Name = "txtNSN";
            this.txtNSN.Size = new System.Drawing.Size(284, 25);
            this.txtNSN.TabIndex = 5;
            // 
            // drawingLineDataGridView
            // 
            this.drawingLineDataGridView.AllowUserToAddRows = false;
            this.drawingLineDataGridView.AllowUserToDeleteRows = false;
            this.drawingLineDataGridView.AutoGenerateColumns = false;
            this.drawingLineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drawingLineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.PartDescription,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Comment});
            this.drawingLineDataGridView.DataSource = this.drawingLineBindingSource;
            this.drawingLineDataGridView.Location = new System.Drawing.Point(15, 220);
            this.drawingLineDataGridView.Name = "drawingLineDataGridView";
            this.drawingLineDataGridView.ReadOnly = true;
            this.drawingLineDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drawingLineDataGridView.Size = new System.Drawing.Size(1346, 412);
            this.drawingLineDataGridView.TabIndex = 3;
            // 
            // drawingLineBindingSource
            // 
            this.drawingLineBindingSource.DataSource = typeof(ValcomData.DrawingLine);
            // 
            // drawingIDComboBox
            // 
            this.drawingIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drawingIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drawingIDComboBox.FormattingEnabled = true;
            this.drawingIDComboBox.Location = new System.Drawing.Point(328, 38);
            this.drawingIDComboBox.Name = "drawingIDComboBox";
            this.drawingIDComboBox.Size = new System.Drawing.Size(284, 25);
            this.drawingIDComboBox.TabIndex = 1;
            this.drawingIDComboBox.SelectedIndexChanged += new System.EventHandler(this.drawingIDComboBox_SelectedIndexChanged);
            this.drawingIDComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drawingIDComboBox_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.drawingBindingSource, "DateModifedNotNull", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(737, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 25);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Changes:";
            // 
            // txtDrawingChanges
            // 
            this.txtDrawingChanges.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingBindingSource, "Changes", true));
            this.txtDrawingChanges.Location = new System.Drawing.Point(737, 72);
            this.txtDrawingChanges.Multiline = true;
            this.txtDrawingChanges.Name = "txtDrawingChanges";
            this.txtDrawingChanges.ReadOnly = true;
            this.txtDrawingChanges.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDrawingChanges.Size = new System.Drawing.Size(544, 78);
            this.txtDrawingChanges.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1373, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMnuNewDrawing,
            this.toolMnuModifyDeleteDrawing,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolmnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolMnuNewDrawing
            // 
            this.toolMnuNewDrawing.Image = ((System.Drawing.Image)(resources.GetObject("toolMnuNewDrawing.Image")));
            this.toolMnuNewDrawing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMnuNewDrawing.Name = "toolMnuNewDrawing";
            this.toolMnuNewDrawing.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolMnuNewDrawing.Size = new System.Drawing.Size(197, 22);
            this.toolMnuNewDrawing.Text = "&New Drawing";
            this.toolMnuNewDrawing.Click += new System.EventHandler(this.btnAddDrawing_Click);
            // 
            // toolMnuModifyDeleteDrawing
            // 
            this.toolMnuModifyDeleteDrawing.Image = ((System.Drawing.Image)(resources.GetObject("toolMnuModifyDeleteDrawing.Image")));
            this.toolMnuModifyDeleteDrawing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMnuModifyDeleteDrawing.Name = "toolMnuModifyDeleteDrawing";
            this.toolMnuModifyDeleteDrawing.Size = new System.Drawing.Size(197, 22);
            this.toolMnuModifyDeleteDrawing.Text = "&Modify/Delete Drawing";
            this.toolMnuModifyDeleteDrawing.Click += new System.EventHandler(this.btnModifyDrawing_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // toolmnuExit
            // 
            this.toolmnuExit.Name = "toolmnuExit";
            this.toolmnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolmnuExit.Size = new System.Drawing.Size(197, 22);
            this.toolmnuExit.Text = "E&xit";
            this.toolmnuExit.Click += new System.EventHandler(this.toolmnuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.toolMnuOpenParts,
            this.toolStripSeparator3});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.editToolStripMenuItem.Text = "&Parts";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // toolMnuOpenParts
            // 
            this.toolMnuOpenParts.Name = "toolMnuOpenParts";
            this.toolMnuOpenParts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolMnuOpenParts.Size = new System.Drawing.Size(173, 22);
            this.toolMnuOpenParts.Text = "Open Parts";
            this.toolMnuOpenParts.Click += new System.EventHandler(this.toolMnuOpenParts_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ValcomDrawings.Properties.Resources.Exitsmall;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1293, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.toolmnuExit_Click);
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Image = global::ValcomDrawings.Properties.Resources.create;
            this.btnCreateJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateJob.Location = new System.Drawing.Point(1063, 167);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(118, 44);
            this.btnCreateJob.TabIndex = 10;
            this.btnCreateJob.Text = "Create Job";
            this.btnCreateJob.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateJob.UseVisualStyleBackColor = true;
            this.btnCreateJob.Click += new System.EventHandler(this.btnCreateJob_Click);
            // 
            // btnAddLineItems
            // 
            this.btnAddLineItems.Image = global::ValcomDrawings.Properties.Resources.EditNew;
            this.btnAddLineItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLineItems.Location = new System.Drawing.Point(1187, 167);
            this.btnAddLineItems.Name = "btnAddLineItems";
            this.btnAddLineItems.Size = new System.Drawing.Size(174, 44);
            this.btnAddLineItems.TabIndex = 2;
            this.btnAddLineItems.Text = "Add/Edit &Line Items";
            this.btnAddLineItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddLineItems.UseVisualStyleBackColor = true;
            this.btnAddLineItems.Click += new System.EventHandler(this.btnAddLineItems_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ValcomDrawings.Properties.Resources.ValcomLogoMF;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DLDrawingID";
            this.dataGridViewTextBoxColumn2.HeaderText = "DLDrawingID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LineNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "Line#";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 64;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductionCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "PM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PartID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PartID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 220;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DWGNO";
            this.dataGridViewTextBoxColumn6.HeaderText = "DWGNO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 220;
            // 
            // PartDescription
            // 
            this.PartDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartDescription.DataPropertyName = "PartDescription";
            this.PartDescription.HeaderText = "PartDescription";
            this.PartDescription.Name = "PartDescription";
            this.PartDescription.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QTYU";
            this.dataGridViewTextBoxColumn7.HeaderText = "QTY/U";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 67;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Units";
            this.dataGridViewTextBoxColumn8.HeaderText = "Units";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 62;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IndentFactor";
            this.dataGridViewTextBoxColumn9.HeaderText = "IF";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 42;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "QANote";
            this.dataGridViewTextBoxColumn10.HeaderText = "QANote";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateJob);
            this.Controls.Add(this.txtDrawingChanges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddLineItems);
            this.Controls.Add(drawingIDLabel1);
            this.Controls.Add(this.drawingIDComboBox);
            this.Controls.Add(this.drawingLineDataGridView);
            this.Controls.Add(txtAddedBy);
            this.Controls.Add(this.addedByTextBox);
            this.Controls.Add(bOMDescriptionLabel);
            this.Controls.Add(this.txtBOMDescription);
            this.Controls.Add(label1);
            this.Controls.Add(dateModifiedLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateModifiedDateTimePicker);
            this.Controls.Add(nSNLabel);
            this.Controls.Add(this.txtNSN);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valcom Drawings";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource drawingBindingSource;
        private System.Windows.Forms.TextBox addedByTextBox;
        private System.Windows.Forms.TextBox txtBOMDescription;
        private System.Windows.Forms.DateTimePicker dateModifiedDateTimePicker;
        private System.Windows.Forms.TextBox txtNSN;
        private System.Windows.Forms.BindingSource drawingLineBindingSource;
        private System.Windows.Forms.DataGridView drawingLineDataGridView;
        private System.Windows.Forms.ComboBox drawingIDComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnAddLineItems;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrawingChanges;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMnuNewDrawing;
        private System.Windows.Forms.ToolStripMenuItem toolMnuModifyDeleteDrawing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolmnuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMnuOpenParts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}

