namespace ValcomDrawings
{
    partial class AddLineItems
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
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label dLDrawingIDLabel;
            System.Windows.Forms.Label dWGNOLabel;
            System.Windows.Forms.Label indentFactorLabel;
            System.Windows.Forms.Label lineNumberLabel;
            System.Windows.Forms.Label partIDLabel;
            System.Windows.Forms.Label productionCodeLabel;
            System.Windows.Forms.Label qANoteLabel;
            System.Windows.Forms.Label qTYULabel;
            System.Windows.Forms.Label unitsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLineItems));
            this.drawingLineDataGridView = new System.Windows.Forms.DataGridView();
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
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.drawingLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtDrawingID = new System.Windows.Forms.TextBox();
            this.txtDWGNO = new System.Windows.Forms.TextBox();
            this.txtIndentFactor = new System.Windows.Forms.TextBox();
            this.txtQANotes = new System.Windows.Forms.TextBox();
            this.txtQTYU = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboBoxParts = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.btnDeleteLineItem = new System.Windows.Forms.Button();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.cboProductionCode = new System.Windows.Forms.ComboBox();
            this.cboPartsDescription = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.EntryPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            commentsLabel = new System.Windows.Forms.Label();
            dLDrawingIDLabel = new System.Windows.Forms.Label();
            dWGNOLabel = new System.Windows.Forms.Label();
            indentFactorLabel = new System.Windows.Forms.Label();
            lineNumberLabel = new System.Windows.Forms.Label();
            partIDLabel = new System.Windows.Forms.Label();
            productionCodeLabel = new System.Windows.Forms.Label();
            qANoteLabel = new System.Windows.Forms.Label();
            qTYULabel = new System.Windows.Forms.Label();
            unitsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.EntryPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(555, 88);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(69, 15);
            commentsLabel.TabIndex = 11;
            commentsLabel.Text = "&Comments:";
            // 
            // dLDrawingIDLabel
            // 
            dLDrawingIDLabel.AutoSize = true;
            dLDrawingIDLabel.Location = new System.Drawing.Point(24, 16);
            dLDrawingIDLabel.Name = "dLDrawingIDLabel";
            dLDrawingIDLabel.Size = new System.Drawing.Size(68, 15);
            dLDrawingIDLabel.TabIndex = 0;
            dLDrawingIDLabel.Text = "Drawing ID:";
            // 
            // dWGNOLabel
            // 
            dWGNOLabel.AutoSize = true;
            dWGNOLabel.Location = new System.Drawing.Point(24, 52);
            dWGNOLabel.Name = "dWGNOLabel";
            dWGNOLabel.Size = new System.Drawing.Size(55, 15);
            dWGNOLabel.TabIndex = 1;
            dWGNOLabel.Text = "D&WGNO:";
            // 
            // indentFactorLabel
            // 
            indentFactorLabel.AutoSize = true;
            indentFactorLabel.Location = new System.Drawing.Point(724, 16);
            indentFactorLabel.Name = "indentFactorLabel";
            indentFactorLabel.Size = new System.Drawing.Size(80, 15);
            indentFactorLabel.TabIndex = 12;
            indentFactorLabel.Text = "&Indent Factor:";
            // 
            // lineNumberLabel
            // 
            lineNumberLabel.AutoSize = true;
            lineNumberLabel.Location = new System.Drawing.Point(555, 16);
            lineNumberLabel.Name = "lineNumberLabel";
            lineNumberLabel.Size = new System.Drawing.Size(79, 15);
            lineNumberLabel.TabIndex = 7;
            lineNumberLabel.Text = "&Line Number:";
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Location = new System.Drawing.Point(24, 88);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new System.Drawing.Size(45, 15);
            partIDLabel.TabIndex = 3;
            partIDLabel.Text = "P&art ID:";
            // 
            // productionCodeLabel
            // 
            productionCodeLabel.AutoSize = true;
            productionCodeLabel.Location = new System.Drawing.Point(555, 51);
            productionCodeLabel.Name = "productionCodeLabel";
            productionCodeLabel.Size = new System.Drawing.Size(100, 15);
            productionCodeLabel.TabIndex = 9;
            productionCodeLabel.Text = "&Production Code:";
            // 
            // qANoteLabel
            // 
            qANoteLabel.AutoSize = true;
            qANoteLabel.Location = new System.Drawing.Point(555, 124);
            qANoteLabel.Name = "qANoteLabel";
            qANoteLabel.Size = new System.Drawing.Size(53, 15);
            qANoteLabel.TabIndex = 13;
            qANoteLabel.Text = "&QANote:";
            // 
            // qTYULabel
            // 
            qTYULabel.AutoSize = true;
            qTYULabel.Location = new System.Drawing.Point(860, 16);
            qTYULabel.Name = "qTYULabel";
            qTYULabel.Size = new System.Drawing.Size(46, 15);
            qTYULabel.TabIndex = 18;
            qTYULabel.Text = "Q&TY/U:";
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Location = new System.Drawing.Point(724, 45);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Size = new System.Drawing.Size(37, 15);
            unitsLabel.TabIndex = 16;
            unitsLabel.Text = "&Units:";
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
            this.Comment,
            this.Edit});
            this.drawingLineDataGridView.DataSource = this.drawingLineBindingSource;
            this.drawingLineDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingLineDataGridView.Location = new System.Drawing.Point(0, 0);
            this.drawingLineDataGridView.MultiSelect = false;
            this.drawingLineDataGridView.Name = "drawingLineDataGridView";
            this.drawingLineDataGridView.ReadOnly = true;
            this.drawingLineDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drawingLineDataGridView.Size = new System.Drawing.Size(1269, 342);
            this.drawingLineDataGridView.TabIndex = 21;
            this.drawingLineDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drawingLineDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductionCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "PC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 65;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PartID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PartID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QTYU";
            this.dataGridViewTextBoxColumn7.HeaderText = "QTY/U";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 68;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Units";
            this.dataGridViewTextBoxColumn8.HeaderText = "Units";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 59;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IndentFactor";
            this.dataGridViewTextBoxColumn9.HeaderText = "IF";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 41;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "QANote";
            this.dataGridViewTextBoxColumn10.HeaderText = "QANote";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 155;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comments";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 230;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 60;
            // 
            // drawingLineBindingSource
            // 
            this.drawingLineBindingSource.DataSource = typeof(ValcomData.DrawingLine);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(630, 85);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(407, 23);
            this.txtComments.TabIndex = 12;
            // 
            // txtDrawingID
            // 
            this.txtDrawingID.Enabled = false;
            this.txtDrawingID.Location = new System.Drawing.Point(120, 13);
            this.txtDrawingID.Name = "txtDrawingID";
            this.txtDrawingID.Size = new System.Drawing.Size(407, 23);
            this.txtDrawingID.TabIndex = 1;
            // 
            // txtDWGNO
            // 
            this.txtDWGNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDWGNO.Location = new System.Drawing.Point(120, 49);
            this.txtDWGNO.Name = "txtDWGNO";
            this.txtDWGNO.Size = new System.Drawing.Size(407, 23);
            this.txtDWGNO.TabIndex = 2;
            this.txtDWGNO.Tag = "DWGNO";
            // 
            // txtIndentFactor
            // 
            this.txtIndentFactor.Location = new System.Drawing.Point(810, 13);
            this.txtIndentFactor.Name = "txtIndentFactor";
            this.txtIndentFactor.Size = new System.Drawing.Size(44, 23);
            this.txtIndentFactor.TabIndex = 15;
            this.txtIndentFactor.Tag = "Indent Factor";
            // 
            // txtQANotes
            // 
            this.txtQANotes.Location = new System.Drawing.Point(630, 121);
            this.txtQANotes.Name = "txtQANotes";
            this.txtQANotes.Size = new System.Drawing.Size(407, 23);
            this.txtQANotes.TabIndex = 14;
            // 
            // txtQTYU
            // 
            this.txtQTYU.Location = new System.Drawing.Point(912, 13);
            this.txtQTYU.Name = "txtQTYU";
            this.txtQTYU.Size = new System.Drawing.Size(44, 23);
            this.txtQTYU.TabIndex = 19;
            this.txtQTYU.Tag = "QTY/U";
            // 
            // txtUnits
            // 
            this.txtUnits.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnits.Location = new System.Drawing.Point(810, 42);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(44, 23);
            this.txtUnits.TabIndex = 17;
            this.txtUnits.Tag = "Units";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::ValcomDrawings.Properties.Resources.AddLine;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(ValcomData.Parts);
            // 
            // cboBoxParts
            // 
            this.cboBoxParts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBoxParts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBoxParts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "ID", true));
            this.cboBoxParts.DataSource = this.partsBindingSource;
            this.cboBoxParts.DisplayMember = "PartID";
            this.cboBoxParts.FormattingEnabled = true;
            this.cboBoxParts.Location = new System.Drawing.Point(120, 85);
            this.cboBoxParts.Name = "cboBoxParts";
            this.cboBoxParts.Size = new System.Drawing.Size(407, 23);
            this.cboBoxParts.TabIndex = 4;
            this.cboBoxParts.Tag = "Part";
            this.cboBoxParts.ValueMember = "ID";
            this.cboBoxParts.SelectedIndexChanged += new System.EventHandler(this.cboBoxParts_SelectedIndexChanged);
            this.cboBoxParts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboboxesToUpper_KeyPress);
            // 
            // Exit
            // 
            this.Exit.Image = global::ValcomDrawings.Properties.Resources.Exitsmall;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(85, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(68, 44);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "E&xit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnDeleteLineItem
            // 
            this.btnDeleteLineItem.Location = new System.Drawing.Point(1151, 7);
            this.btnDeleteLineItem.Name = "btnDeleteLineItem";
            this.btnDeleteLineItem.Size = new System.Drawing.Size(106, 38);
            this.btnDeleteLineItem.TabIndex = 24;
            this.btnDeleteLineItem.Text = "&Delete Line Item";
            this.btnDeleteLineItem.UseVisualStyleBackColor = true;
            this.btnDeleteLineItem.Click += new System.EventHandler(this.btnDeleteLineItem_Click);
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(661, 13);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(45, 23);
            this.txtLineNumber.TabIndex = 8;
            this.txtLineNumber.Tag = "Line Number";
            // 
            // cboProductionCode
            // 
            this.cboProductionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductionCode.FormattingEnabled = true;
            this.cboProductionCode.Items.AddRange(new object[] {
            "P",
            "M"});
            this.cboProductionCode.Location = new System.Drawing.Point(661, 48);
            this.cboProductionCode.Name = "cboProductionCode";
            this.cboProductionCode.Size = new System.Drawing.Size(44, 23);
            this.cboProductionCode.TabIndex = 10;
            this.cboProductionCode.Tag = "Production Code";
            // 
            // cboPartsDescription
            // 
            this.cboPartsDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPartsDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPartsDescription.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "ID", true));
            this.cboPartsDescription.DataSource = this.partsBindingSource;
            this.cboPartsDescription.DisplayMember = "PartDescription";
            this.cboPartsDescription.FormattingEnabled = true;
            this.cboPartsDescription.Location = new System.Drawing.Point(120, 121);
            this.cboPartsDescription.Name = "cboPartsDescription";
            this.cboPartsDescription.Size = new System.Drawing.Size(407, 23);
            this.cboPartsDescription.TabIndex = 6;
            this.cboPartsDescription.Tag = "Part Description";
            this.cboPartsDescription.ValueMember = "ID";
            this.cboPartsDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboboxesToUpper_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Part &Description:";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Controls.Add(this.EntryPanel);
            this.topPanel.Controls.Add(this.buttonPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1269, 224);
            this.topPanel.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Image = global::ValcomDrawings.Properties.Resources.ValcomLogoMF;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(192, 86);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 26;
            this.logo.TabStop = false;
            // 
            // EntryPanel
            // 
            this.EntryPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EntryPanel.Controls.Add(dLDrawingIDLabel);
            this.EntryPanel.Controls.Add(dWGNOLabel);
            this.EntryPanel.Controls.Add(this.txtDWGNO);
            this.EntryPanel.Controls.Add(this.label1);
            this.EntryPanel.Controls.Add(this.txtDrawingID);
            this.EntryPanel.Controls.Add(this.txtUnits);
            this.EntryPanel.Controls.Add(indentFactorLabel);
            this.EntryPanel.Controls.Add(this.cboPartsDescription);
            this.EntryPanel.Controls.Add(this.txtIndentFactor);
            this.EntryPanel.Controls.Add(unitsLabel);
            this.EntryPanel.Controls.Add(this.txtComments);
            this.EntryPanel.Controls.Add(this.cboProductionCode);
            this.EntryPanel.Controls.Add(lineNumberLabel);
            this.EntryPanel.Controls.Add(this.txtQTYU);
            this.EntryPanel.Controls.Add(commentsLabel);
            this.EntryPanel.Controls.Add(this.txtLineNumber);
            this.EntryPanel.Controls.Add(partIDLabel);
            this.EntryPanel.Controls.Add(qTYULabel);
            this.EntryPanel.Controls.Add(productionCodeLabel);
            this.EntryPanel.Controls.Add(this.txtQANotes);
            this.EntryPanel.Controls.Add(qANoteLabel);
            this.EntryPanel.Controls.Add(this.cboBoxParts);
            this.EntryPanel.Location = new System.Drawing.Point(210, 12);
            this.EntryPanel.Name = "EntryPanel";
            this.EntryPanel.Size = new System.Drawing.Size(1047, 153);
            this.EntryPanel.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.Controls.Add(this.btnAdd);
            this.buttonPanel.Controls.Add(this.Exit);
            this.buttonPanel.Location = new System.Drawing.Point(1092, 168);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(165, 50);
            this.buttonPanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnDeleteLineItem);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 566);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1269, 57);
            this.bottomPanel.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.drawingLineDataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1269, 342);
            this.panel3.TabIndex = 27;
            // 
            // AddLineItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddLineItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Line Items";
            this.Load += new System.EventHandler(this.AddLineItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.EntryPanel.ResumeLayout(false);
            this.EntryPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource drawingLineBindingSource;
        private System.Windows.Forms.DataGridView drawingLineDataGridView;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtDrawingID;
        private System.Windows.Forms.TextBox txtDWGNO;
        private System.Windows.Forms.TextBox txtIndentFactor;
        private System.Windows.Forms.TextBox txtQANotes;
        private System.Windows.Forms.TextBox txtQTYU;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private System.Windows.Forms.ComboBox cboBoxParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnDeleteLineItem;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.ComboBox cboProductionCode;
        private System.Windows.Forms.ComboBox cboPartsDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Panel EntryPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.PictureBox logo;
    }
}