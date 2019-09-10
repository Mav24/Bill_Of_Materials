namespace ValcomDrawings
{
    partial class AddModifyParts
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
            System.Windows.Forms.Label defaultSupplierLabel;
            System.Windows.Forms.Label partDescriptionLabel;
            System.Windows.Forms.Label partIDLabel;
            System.Windows.Forms.Label qANoteLabel;
            System.Windows.Forms.Label stockLabel;
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQANote = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtpartID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            defaultSupplierLabel = new System.Windows.Forms.Label();
            partDescriptionLabel = new System.Windows.Forms.Label();
            partIDLabel = new System.Windows.Forms.Label();
            qANoteLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultSupplierLabel
            // 
            defaultSupplierLabel.AutoSize = true;
            defaultSupplierLabel.Location = new System.Drawing.Point(210, 138);
            defaultSupplierLabel.Name = "defaultSupplierLabel";
            defaultSupplierLabel.Size = new System.Drawing.Size(94, 15);
            defaultSupplierLabel.TabIndex = 6;
            defaultSupplierLabel.Text = "Default &Supplier:";
            // 
            // partDescriptionLabel
            // 
            partDescriptionLabel.AutoSize = true;
            partDescriptionLabel.Location = new System.Drawing.Point(210, 54);
            partDescriptionLabel.Name = "partDescriptionLabel";
            partDescriptionLabel.Size = new System.Drawing.Size(94, 15);
            partDescriptionLabel.TabIndex = 2;
            partDescriptionLabel.Text = "Part &Description:";
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Location = new System.Drawing.Point(210, 12);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new System.Drawing.Size(45, 15);
            partIDLabel.TabIndex = 0;
            partIDLabel.Text = "&Part ID:";
            // 
            // qANoteLabel
            // 
            qANoteLabel.AutoSize = true;
            qANoteLabel.Location = new System.Drawing.Point(210, 96);
            qANoteLabel.Name = "qANoteLabel";
            qANoteLabel.Size = new System.Drawing.Size(53, 15);
            qANoteLabel.TabIndex = 4;
            qANoteLabel.Text = "&QANote:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(605, 138);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(39, 15);
            stockLabel.TabIndex = 8;
            stockLabel.Text = "S&tock:";
            // 
            // txtSupplier
            // 
            this.txtSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSupplier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "DefaultSupplier", true));
            this.txtSupplier.Location = new System.Drawing.Point(310, 135);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(289, 23);
            this.txtSupplier.TabIndex = 7;
            this.txtSupplier.Tag = "Default Supplier";
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(ValcomData.Parts);
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "PartDescription", true));
            this.txtDescription.Location = new System.Drawing.Point(310, 51);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(444, 23);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Tag = "Part Description";
            // 
            // txtQANote
            // 
            this.txtQANote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "QANote", true));
            this.txtQANote.Location = new System.Drawing.Point(310, 93);
            this.txtQANote.Name = "txtQANote";
            this.txtQANote.Size = new System.Drawing.Size(444, 23);
            this.txtQANote.TabIndex = 5;
            this.txtQANote.Tag = "QA Notes";
            // 
            // txtStock
            // 
            this.txtStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Stock", true));
            this.txtStock.Location = new System.Drawing.Point(650, 135);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(64, 23);
            this.txtStock.TabIndex = 9;
            this.txtStock.Tag = "Stock";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(679, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(598, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtpartID
            // 
            this.txtpartID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpartID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "PartID", true));
            this.txtpartID.Location = new System.Drawing.Point(310, 9);
            this.txtpartID.Name = "txtpartID";
            this.txtpartID.Size = new System.Drawing.Size(444, 23);
            this.txtpartID.TabIndex = 1;
            this.txtpartID.Tag = "Part ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ValcomDrawings.Properties.Resources.ValcomLogoMF;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AddModifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 209);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpartID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(defaultSupplierLabel);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(partDescriptionLabel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(partIDLabel);
            this.Controls.Add(qANoteLabel);
            this.Controls.Add(this.txtQANote);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.txtStock);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddModifyParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Modifiy Part";
            this.Load += new System.EventHandler(this.AddModifyParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource partsBindingSource;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQANote;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtpartID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}