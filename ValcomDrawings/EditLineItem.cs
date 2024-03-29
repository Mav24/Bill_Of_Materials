﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValcomData;

namespace ValcomDrawings
{
    public partial class EditLineItem : Form
    {
        public EditLineItem()
        {
            InitializeComponent();
        }

        public DrawingLine drawingLine;
        public DrawingLine newDrawingLine;
        private List<Parts> parts;

        private void EditLineItem_Load(object sender, EventArgs e)
        {
            parts = PartsDB.GetPartsList();
            cboBoxParts.DataSource = parts;
            cboPartDescription.DataSource = parts;
            
            FillformWithInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                // Gets and sets updated info
                GetUpdatedInfo();

                Parts newPart = new Parts()
                {
                    PartID = cboBoxParts.Text.ToUpper(),
                    PartDescription = cboPartDescription.Text.ToUpper(),
                    DefaultSupplier = "N/A",
                    Stock = "0",
                    QANote = ""
                };
                if (!DrawingLineDB.UpdateLineItem(drawingLine, newDrawingLine))
                {
                    MessageBox.Show($"Another user has updated or deleted this line item, please try again", "DataBase Error!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    PartsDB.AddPart(newPart);
                    DrawingLineDB.UpdateLineItem(drawingLine, newDrawingLine);
                    MessageBox.Show("Line Item updated successfully!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }


            }

        }

        private void GetUpdatedInfo()
        {

            newDrawingLine = new DrawingLine();
            newDrawingLine.ID = drawingLine.ID;
            newDrawingLine.DLDrawingID = drawingLine.DLDrawingID;
            newDrawingLine.IndentFactor = int.Parse(txtIndentFactor.Text);
            newDrawingLine.LineNumber = int.Parse(txtLineNumber.Text);
            newDrawingLine.PartID = cboBoxParts.Text;
            newDrawingLine.PartDescription = cboPartDescription.Text;
            newDrawingLine.ProductionCode = cboProductionCode.Text;
            newDrawingLine.QANote = txtQANote.Text;
            newDrawingLine.QTYU = double.Parse(txtQTYU.Text);
            newDrawingLine.Units = txtUnits.Text;
            newDrawingLine.DWGNO = txtDWGNO.Text;
            newDrawingLine.Comment = txtComment.Text;
        }

        private void FillformWithInfo()
        {

            txtDLDrawingID.Text = drawingLine.DLDrawingID;
            txtIndentFactor.Text = drawingLine.IndentFactor.ToString();
            txtLineNumber.Text = drawingLine.LineNumber.ToString();
            cboBoxParts.Text = drawingLine.PartID;
            cboPartDescription.Text = drawingLine.PartDescription;
            cboProductionCode.Text = drawingLine.ProductionCode;
            txtQANote.Text = drawingLine.QANote;
            txtQTYU.Text = drawingLine.QTYU.ToString();
            txtUnits.Text = drawingLine.Units;
            txtDWGNO.Text = drawingLine.DWGNO;
            txtComment.Text = drawingLine.Comment;

            #region This is used if i'm going to use Datasource fill, Marked for delete Sept 27 2019
            //newDrawingLine.ID = drawingLine.ID;
            //newDrawingLine.DLDrawingID = drawingLine.DLDrawingID;
            //newDrawingLine.IndentFactor = drawingLine.IndentFactor;
            //newDrawingLine.LineNumber = drawingLine.LineNumber;
            //newDrawingLine.PartID = drawingLine.PartID;
            //newDrawingLine.PartDescription = drawingLine.PartDescription;
            //newDrawingLine.ProductionCode = drawingLine.ProductionCode;
            //newDrawingLine.QANote = drawingLine.QANote;
            //newDrawingLine.QTYU = drawingLine.QTYU;
            //newDrawingLine.Units = drawingLine.Units;
            //newDrawingLine.DWGNO = drawingLine.DWGNO;
            //newDrawingLine.Comment = drawingLine.Comment;
            #endregion
        }
        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtDWGNO) &&
                Validator.IsPresent(txtIndentFactor) &&
                Validator.IsPresent(txtLineNumber) &&
                Validator.IsPresent(txtQTYU) &&
                Validator.IsPresent(txtUnits) &&
                Validator.IsPresentCombo(cboProductionCode) &&
                Validator.IsPresentCombo(cboBoxParts) &&
                Validator.IsPresentCombo(cboPartDescription);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
