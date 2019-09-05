namespace ValcomDrawings
{
    partial class EditLineItem
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
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label dLDrawingIDLabel;
            System.Windows.Forms.Label dWGNOLabel;
            System.Windows.Forms.Label indentFactorLabel;
            System.Windows.Forms.Label lineNumberLabel;
            System.Windows.Forms.Label productionCodeLabel;
            System.Windows.Forms.Label qANoteLabel;
            System.Windows.Forms.Label qTYULabel;
            System.Windows.Forms.Label unitsLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label partIDLabel;
            this.drawingLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtDLDrawingID = new System.Windows.Forms.TextBox();
            this.txtDWGNO = new System.Windows.Forms.TextBox();
            this.txtIndentFactor = new System.Windows.Forms.TextBox();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.txtQANote = new System.Windows.Forms.TextBox();
            this.txtQTYU = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboProductionCode = new System.Windows.Forms.ComboBox();
            this.cboPartDescription = new System.Windows.Forms.ComboBox();
            this.cboBoxParts = new System.Windows.Forms.ComboBox();
            commentLabel = new System.Windows.Forms.Label();
            dLDrawingIDLabel = new System.Windows.Forms.Label();
            dWGNOLabel = new System.Windows.Forms.Label();
            indentFactorLabel = new System.Windows.Forms.Label();
            lineNumberLabel = new System.Windows.Forms.Label();
            productionCodeLabel = new System.Windows.Forms.Label();
            qANoteLabel = new System.Windows.Forms.Label();
            qTYULabel = new System.Windows.Forms.Label();
            unitsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            partIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            commentLabel.Location = new System.Drawing.Point(12, 170);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(64, 15);
            commentLabel.TabIndex = 16;
            commentLabel.Text = "C&omment:";
            // 
            // dLDrawingIDLabel
            // 
            dLDrawingIDLabel.AutoSize = true;
            dLDrawingIDLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dLDrawingIDLabel.Location = new System.Drawing.Point(12, 37);
            dLDrawingIDLabel.Name = "dLDrawingIDLabel";
            dLDrawingIDLabel.Size = new System.Drawing.Size(82, 15);
            dLDrawingIDLabel.TabIndex = 3;
            dLDrawingIDLabel.Text = "DLDrawing ID:";
            // 
            // dWGNOLabel
            // 
            dWGNOLabel.AutoSize = true;
            dWGNOLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            dWGNOLabel.Location = new System.Drawing.Point(12, 71);
            dWGNOLabel.Name = "dWGNOLabel";
            dWGNOLabel.Size = new System.Drawing.Size(55, 15);
            dWGNOLabel.TabIndex = 0;
            dWGNOLabel.Text = "D&WGNO:";
            // 
            // indentFactorLabel
            // 
            indentFactorLabel.AutoSize = true;
            indentFactorLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            indentFactorLabel.Location = new System.Drawing.Point(365, 72);
            indentFactorLabel.Name = "indentFactorLabel";
            indentFactorLabel.Size = new System.Drawing.Size(80, 15);
            indentFactorLabel.TabIndex = 10;
            indentFactorLabel.Text = "&Indent Factor:";
            // 
            // lineNumberLabel
            // 
            lineNumberLabel.AutoSize = true;
            lineNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            lineNumberLabel.Location = new System.Drawing.Point(365, 37);
            lineNumberLabel.Name = "lineNumberLabel";
            lineNumberLabel.Size = new System.Drawing.Size(79, 15);
            lineNumberLabel.TabIndex = 6;
            lineNumberLabel.Text = "&Line Number:";
            // 
            // productionCodeLabel
            // 
            productionCodeLabel.AutoSize = true;
            productionCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            productionCodeLabel.Location = new System.Drawing.Point(365, 107);
            productionCodeLabel.Name = "productionCodeLabel";
            productionCodeLabel.Size = new System.Drawing.Size(100, 15);
            productionCodeLabel.TabIndex = 14;
            productionCodeLabel.Text = "P&roduction Code:";
            // 
            // qANoteLabel
            // 
            qANoteLabel.AutoSize = true;
            qANoteLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            qANoteLabel.Location = new System.Drawing.Point(12, 204);
            qANoteLabel.Name = "qANoteLabel";
            qANoteLabel.Size = new System.Drawing.Size(53, 15);
            qANoteLabel.TabIndex = 18;
            qANoteLabel.Text = "&QANote:";
            // 
            // qTYULabel
            // 
            qTYULabel.AutoSize = true;
            qTYULabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            qTYULabel.Location = new System.Drawing.Point(513, 37);
            qTYULabel.Name = "qTYULabel";
            qTYULabel.Size = new System.Drawing.Size(41, 15);
            qTYULabel.TabIndex = 8;
            qTYULabel.Text = "QTYU:";
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            unitsLabel.Location = new System.Drawing.Point(512, 72);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Size = new System.Drawing.Size(37, 15);
            unitsLabel.TabIndex = 12;
            unitsLabel.Text = "Units:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            label1.Location = new System.Drawing.Point(12, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Part &Description:";
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Location = new System.Drawing.Point(12, 109);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new System.Drawing.Size(43, 13);
            partIDLabel.TabIndex = 2;
            partIDLabel.Text = "Part ID:";
            // 
            // drawingLineBindingSource
            // 
            this.drawingLineBindingSource.DataSource = typeof(ValcomData.DrawingLine);
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "Comment", true));
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComment.Location = new System.Drawing.Point(109, 167);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(491, 23);
            this.txtComment.TabIndex = 17;
            // 
            // txtDLDrawingID
            // 
            this.txtDLDrawingID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "DLDrawingID", true));
            this.txtDLDrawingID.Enabled = false;
            this.txtDLDrawingID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDLDrawingID.Location = new System.Drawing.Point(109, 34);
            this.txtDLDrawingID.Name = "txtDLDrawingID";
            this.txtDLDrawingID.Size = new System.Drawing.Size(247, 23);
            this.txtDLDrawingID.TabIndex = 4;
            // 
            // txtDWGNO
            // 
            this.txtDWGNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDWGNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "DWGNO", true));
            this.txtDWGNO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDWGNO.Location = new System.Drawing.Point(109, 68);
            this.txtDWGNO.Name = "txtDWGNO";
            this.txtDWGNO.Size = new System.Drawing.Size(247, 23);
            this.txtDWGNO.TabIndex = 1;
            // 
            // txtIndentFactor
            // 
            this.txtIndentFactor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "IndentFactor", true));
            this.txtIndentFactor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIndentFactor.Location = new System.Drawing.Point(472, 69);
            this.txtIndentFactor.Name = "txtIndentFactor";
            this.txtIndentFactor.Size = new System.Drawing.Size(35, 23);
            this.txtIndentFactor.TabIndex = 11;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "LineNumber", true));
            this.txtLineNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLineNumber.Location = new System.Drawing.Point(472, 34);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(35, 23);
            this.txtLineNumber.TabIndex = 7;
            // 
            // txtQANote
            // 
            this.txtQANote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "QANote", true));
            this.txtQANote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQANote.Location = new System.Drawing.Point(109, 201);
            this.txtQANote.Name = "txtQANote";
            this.txtQANote.Size = new System.Drawing.Size(491, 23);
            this.txtQANote.TabIndex = 19;
            // 
            // txtQTYU
            // 
            this.txtQTYU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "QTYU", true));
            this.txtQTYU.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQTYU.Location = new System.Drawing.Point(559, 34);
            this.txtQTYU.Name = "txtQTYU";
            this.txtQTYU.Size = new System.Drawing.Size(35, 23);
            this.txtQTYU.TabIndex = 9;
            // 
            // txtUnits
            // 
            this.txtUnits.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "Units", true));
            this.txtUnits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnits.Location = new System.Drawing.Point(557, 68);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(35, 23);
            this.txtUnits.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(513, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.Location = new System.Drawing.Point(432, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(ValcomData.Parts);
            // 
            // cboProductionCode
            // 
            this.cboProductionCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingLineBindingSource, "ProductionCode", true));
            this.cboProductionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductionCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductionCode.FormattingEnabled = true;
            this.cboProductionCode.Items.AddRange(new object[] {
            "P",
            "M"});
            this.cboProductionCode.Location = new System.Drawing.Point(472, 104);
            this.cboProductionCode.Name = "cboProductionCode";
            this.cboProductionCode.Size = new System.Drawing.Size(35, 23);
            this.cboProductionCode.TabIndex = 15;
            // 
            // cboPartDescription
            // 
            this.cboPartDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "PartDescription", true));
            this.cboPartDescription.DataSource = this.partsBindingSource;
            this.cboPartDescription.DisplayMember = "PartDescription";
            this.cboPartDescription.FormattingEnabled = true;
            this.cboPartDescription.Location = new System.Drawing.Point(109, 136);
            this.cboPartDescription.Name = "cboPartDescription";
            this.cboPartDescription.Size = new System.Drawing.Size(247, 21);
            this.cboPartDescription.TabIndex = 5;
            // 
            // cboBoxParts
            // 
            this.cboBoxParts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "PartID", true));
            this.cboBoxParts.DataSource = this.partsBindingSource;
            this.cboBoxParts.DisplayMember = "PartID";
            this.cboBoxParts.FormattingEnabled = true;
            this.cboBoxParts.Location = new System.Drawing.Point(109, 105);
            this.cboBoxParts.Name = "cboBoxParts";
            this.cboBoxParts.Size = new System.Drawing.Size(247, 21);
            this.cboBoxParts.TabIndex = 3;
            // 
            // EditLineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 287);
            this.ControlBox = false;
            this.Controls.Add(this.cboBoxParts);
            this.Controls.Add(this.cboPartDescription);
            this.Controls.Add(partIDLabel);
            this.Controls.Add(this.cboProductionCode);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(dLDrawingIDLabel);
            this.Controls.Add(this.txtDLDrawingID);
            this.Controls.Add(dWGNOLabel);
            this.Controls.Add(this.txtDWGNO);
            this.Controls.Add(indentFactorLabel);
            this.Controls.Add(this.txtIndentFactor);
            this.Controls.Add(lineNumberLabel);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(label1);
            this.Controls.Add(productionCodeLabel);
            this.Controls.Add(qANoteLabel);
            this.Controls.Add(this.txtQANote);
            this.Controls.Add(qTYULabel);
            this.Controls.Add(this.txtQTYU);
            this.Controls.Add(unitsLabel);
            this.Controls.Add(this.txtUnits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditLineItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Line Item";
            this.Load += new System.EventHandler(this.EditLineItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource drawingLineBindingSource;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtDLDrawingID;
        private System.Windows.Forms.TextBox txtDWGNO;
        private System.Windows.Forms.TextBox txtIndentFactor;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.TextBox txtQANote;
        private System.Windows.Forms.TextBox txtQTYU;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private System.Windows.Forms.ComboBox cboProductionCode;
        private System.Windows.Forms.ComboBox cboPartDescription;
        private System.Windows.Forms.ComboBox cboBoxParts;
    }
}