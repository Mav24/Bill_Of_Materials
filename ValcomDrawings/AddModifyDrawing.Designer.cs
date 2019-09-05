namespace ValcomDrawings
{
    partial class AddModifyDrawing
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
            System.Windows.Forms.Label addedByLabel;
            System.Windows.Forms.Label bOMDescriptionLabel;
            System.Windows.Forms.Label drawingIDLabel;
            System.Windows.Forms.Label nSNLabel;
            this.txtAddedBy = new System.Windows.Forms.TextBox();
            this.drawingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBOMDescription = new System.Windows.Forms.TextBox();
            this.txtDrawingID = new System.Windows.Forms.TextBox();
            this.txtNSN = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            addedByLabel = new System.Windows.Forms.Label();
            bOMDescriptionLabel = new System.Windows.Forms.Label();
            drawingIDLabel = new System.Windows.Forms.Label();
            nSNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addedByLabel
            // 
            addedByLabel.AutoSize = true;
            addedByLabel.Location = new System.Drawing.Point(368, 29);
            addedByLabel.Name = "addedByLabel";
            addedByLabel.Size = new System.Drawing.Size(61, 15);
            addedByLabel.TabIndex = 4;
            addedByLabel.Text = "Added By:";
            // 
            // bOMDescriptionLabel
            // 
            bOMDescriptionLabel.AutoSize = true;
            bOMDescriptionLabel.Location = new System.Drawing.Point(45, 96);
            bOMDescriptionLabel.Name = "bOMDescriptionLabel";
            bOMDescriptionLabel.Size = new System.Drawing.Size(97, 15);
            bOMDescriptionLabel.TabIndex = 6;
            bOMDescriptionLabel.Text = "BOMDescription:";
            // 
            // drawingIDLabel
            // 
            drawingIDLabel.AutoSize = true;
            drawingIDLabel.Location = new System.Drawing.Point(45, 29);
            drawingIDLabel.Name = "drawingIDLabel";
            drawingIDLabel.Size = new System.Drawing.Size(68, 15);
            drawingIDLabel.TabIndex = 0;
            drawingIDLabel.Text = "Drawing ID:";
            // 
            // nSNLabel
            // 
            nSNLabel.AutoSize = true;
            nSNLabel.Location = new System.Drawing.Point(45, 62);
            nSNLabel.Name = "nSNLabel";
            nSNLabel.Size = new System.Drawing.Size(34, 15);
            nSNLabel.TabIndex = 2;
            nSNLabel.Text = "NSN:";
            // 
            // txtAddedBy
            // 
            this.txtAddedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddedBy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingBindingSource, "AddedBy", true));
            this.txtAddedBy.Location = new System.Drawing.Point(471, 26);
            this.txtAddedBy.Name = "txtAddedBy";
            this.txtAddedBy.Size = new System.Drawing.Size(200, 23);
            this.txtAddedBy.TabIndex = 5;
            this.txtAddedBy.Tag = "AddedBy";
            // 
            // drawingBindingSource
            // 
            this.drawingBindingSource.DataSource = typeof(ValcomData.Drawing);
            // 
            // txtBOMDescription
            // 
            this.txtBOMDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBOMDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingBindingSource, "BOMDescription", true));
            this.txtBOMDescription.Location = new System.Drawing.Point(148, 93);
            this.txtBOMDescription.Name = "txtBOMDescription";
            this.txtBOMDescription.Size = new System.Drawing.Size(523, 23);
            this.txtBOMDescription.TabIndex = 7;
            this.txtBOMDescription.Tag = "BOMDescription";
            // 
            // txtDrawingID
            // 
            this.txtDrawingID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDrawingID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingBindingSource, "DrawingID", true));
            this.txtDrawingID.Enabled = false;
            this.txtDrawingID.Location = new System.Drawing.Point(148, 26);
            this.txtDrawingID.Name = "txtDrawingID";
            this.txtDrawingID.Size = new System.Drawing.Size(200, 23);
            this.txtDrawingID.TabIndex = 1;
            this.txtDrawingID.Tag = "DrawingID";
            // 
            // txtNSN
            // 
            this.txtNSN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drawingBindingSource, "NSN", true));
            this.txtNSN.Location = new System.Drawing.Point(148, 59);
            this.txtNSN.Name = "txtNSN";
            this.txtNSN.Size = new System.Drawing.Size(200, 23);
            this.txtNSN.TabIndex = 3;
            this.txtNSN.Tag = "NSN";
            this.txtNSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNSN_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(467, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(548, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddModifyDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 172);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(addedByLabel);
            this.Controls.Add(this.txtAddedBy);
            this.Controls.Add(bOMDescriptionLabel);
            this.Controls.Add(this.txtBOMDescription);
            this.Controls.Add(drawingIDLabel);
            this.Controls.Add(this.txtDrawingID);
            this.Controls.Add(nSNLabel);
            this.Controls.Add(this.txtNSN);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddModifyDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Modify Drawing";
            this.Load += new System.EventHandler(this.AddModifyDrawing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource drawingBindingSource;
        private System.Windows.Forms.TextBox txtAddedBy;
        private System.Windows.Forms.TextBox txtBOMDescription;
        private System.Windows.Forms.TextBox txtDrawingID;
        private System.Windows.Forms.TextBox txtNSN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}