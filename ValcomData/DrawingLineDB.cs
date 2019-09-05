using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValcomData
{
    public static class DrawingLineDB
    {
        public static List<DrawingLine> GetDrawingLines(string drawingID)
        {
            List<DrawingLine> lineItems = new List<DrawingLine>();
            SqlConnection connection = ValcomDB.GetConnection();

            string selectStatement = "SELECT * FROM DrawingLines WHERE DLDrawingID = @DrawingID";

            SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);
            sqlCommand.Parameters.AddWithValue("@DrawingID", drawingID);

            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    DrawingLine drawingLine = new DrawingLine();
                    drawingLine.ID = (int)reader["ID"];
                    drawingLine.DLDrawingID = reader["DLDrawingID"].ToString();
                    drawingLine.LineNumber = Convert.ToInt16(reader["LineNumber"]);
                    drawingLine.ProductionCode = reader["ProductionCode"].ToString();
                    drawingLine.PartID = reader["PartID"].ToString();
                    drawingLine.PartDescription = reader["PartDescription"].ToString();
                    drawingLine.DWGNO = reader["DWGNO"].ToString();
                    drawingLine.QTYU = Convert.ToDouble(reader["QTYU"]);
                    drawingLine.Units = reader["Units"].ToString();
                    drawingLine.IndentFactor = Convert.ToInt16(reader["IndentFactor"]);
                    drawingLine.QANote = reader["QANote"].ToString();
                    drawingLine.Comment = reader["Comment"].ToString();
                    
                    //Fill list
                    lineItems.Add(drawingLine);
                }
                reader.Close();
            }
            
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
            // Return list of lineItems
            // Sorts the list before returning
            return lineItems.OrderBy(x => x.LineNumber).ToList();
        }

        /// <summary>
        /// Add Line Item
        /// </summary>
        /// <param name="drawing"></param>
        /// <param name="drawingLine"></param>
        public static void AddLineItem(Drawing drawing, DrawingLine drawingLine)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            string insertStatement = "INSERT DrawingLines " +
                "(DLDrawingID, LineNumber, ProductionCode, PartID, DWGNO, QTYU, Units, IndentFactor, QANote, Comment, PartDescription) " +
                "VALUES (@DLDrawingID, @LineNumber, @ProductionCode, @PartID, @DWGNO, @QTYU, @Units, @IndentFactor, @QANote, @Comment, @PartDescription)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@DLDrawingID", drawing.DrawingID);
            insertCommand.Parameters.AddWithValue("@LineNumber", drawingLine.LineNumber);
            insertCommand.Parameters.AddWithValue("@ProductionCode", drawingLine.ProductionCode);
            insertCommand.Parameters.AddWithValue("@PartID", drawingLine.PartID);
            insertCommand.Parameters.AddWithValue("@PartDescription", drawingLine.PartDescription);
            insertCommand.Parameters.AddWithValue("@DWGNO", drawingLine.DWGNO);
            insertCommand.Parameters.AddWithValue("@QTYU", drawingLine.QTYU);
            insertCommand.Parameters.AddWithValue("@Units", drawingLine.Units);
            insertCommand.Parameters.AddWithValue("@IndentFactor", drawingLine.IndentFactor);
            if (drawingLine.QANote == null)
            {
                insertCommand.Parameters.AddWithValue("@QANote", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@QANote", drawingLine.QANote);
            }
            if (drawingLine.Comment == null)
            {
                insertCommand.Parameters.AddWithValue("@Comment", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Comment", drawingLine.Comment);
            }
            

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                // Marked for delete Don't think i need this as i don't need to return anything
                //string selectStatement = "SELECT IDENT_CURRENT('DrawingLines') FROM DrawingLines";
                //SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);
                //sqlCommand.ExecuteScalar();
                
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Update LineItem
        /// </summary>
        /// <param name="drawing"></param>
        /// <param name="oldDrawingLine"></param>
        /// <param name="newDrawingLine"></param>
        /// <returns></returns>
        public static bool UpdateLineItem(DrawingLine oldDrawingLine, DrawingLine newDrawingLine)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            SqlTransaction updateDrawingLineTran = null;

            string updateStatement =
                "UPDATE DrawingLines SET " +
                 "LineNumber = @NewLineNumber, " +
                 "ProductionCode = @NewProductionCode, " +
                 "PartID = @NewPartID, " +
                 "DWGNO = @NewDWGNO, " +
                 "QTYU = @NewQTYU, " +
                 "Units = @NewUnits, " +
                 "IndentFactor = @NewIndentFactor, " +
                 "QANote = @NewQANote, " +
                 "Comment = @NewComment, " +
                 "PartDescription = @NewPartDescription " +
                 "WHERE ID = @OldID " +
                 "AND LineNumber = @OldLineNumber " +
                 "AND ProductionCode = @OldProductionCode " +
                 "AND PartID = @OldPartID " +
                 "AND DWGNO = @OldDWGNO " +
                 "AND QTYU = @OldQTYU " +
                 "AND Units = @OldUnits " +
                 "AND IndentFactor = @OldIndentFactor " +
                 "AND QANote = @OldQANote " +
                 "AND Comment = @OldComment " +
                 "AND PartDescription = @OldPartDescription";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@NewLineNumber", newDrawingLine.LineNumber);
            updateCommand.Parameters.AddWithValue("@NewProductionCode", newDrawingLine.ProductionCode);
            updateCommand.Parameters.AddWithValue("@NewPartID", newDrawingLine.PartID);
            updateCommand.Parameters.AddWithValue("@NewDWGNO", newDrawingLine.DWGNO);
            updateCommand.Parameters.AddWithValue("@NewQTYU", newDrawingLine.QTYU);
            updateCommand.Parameters.AddWithValue("@NewUnits", newDrawingLine.Units);
            updateCommand.Parameters.AddWithValue("@NewIndentFactor", newDrawingLine.IndentFactor);
            updateCommand.Parameters.AddWithValue("@NewQANote", newDrawingLine.QANote);
            updateCommand.Parameters.AddWithValue("@NewComment", newDrawingLine.Comment);
            updateCommand.Parameters.AddWithValue("@NewPartDescription", newDrawingLine.PartDescription);

            updateCommand.Parameters.AddWithValue("@OldID", oldDrawingLine.ID);
            updateCommand.Parameters.AddWithValue("@OldLineNumber", oldDrawingLine.LineNumber);
            updateCommand.Parameters.AddWithValue("@OldProductionCode", oldDrawingLine.ProductionCode);
            updateCommand.Parameters.AddWithValue("@OldPartID", oldDrawingLine.PartID);
            updateCommand.Parameters.AddWithValue("@OldDWGNO", oldDrawingLine.DWGNO);
            updateCommand.Parameters.AddWithValue("@OldQTYU", oldDrawingLine.QTYU);
            updateCommand.Parameters.AddWithValue("@OldUnits", oldDrawingLine.Units);
            updateCommand.Parameters.AddWithValue("@OldIndentFactor", oldDrawingLine.IndentFactor);
            updateCommand.Parameters.AddWithValue("@OldQANote", oldDrawingLine.QANote);
            updateCommand.Parameters.AddWithValue("@OldComment", oldDrawingLine.Comment);
            updateCommand.Parameters.AddWithValue("@OldPartDescription", oldDrawingLine.PartDescription);

            try
            {
                connection.Open();
                updateDrawingLineTran = connection.BeginTransaction();
                updateCommand.Transaction = updateDrawingLineTran;
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    updateDrawingLineTran.Commit();
                    return true;
                }
                else
                {
                    updateDrawingLineTran.Rollback();
                    return false;
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        ///  Method to delete only single Line Items
        /// </summary>
        /// <param name="drawingLineID"></param>
        public static void DeleteLineItems(int drawingLineID)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            string deleteStatement = "DELETE FROM DrawingLines WHERE ID = @ID";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@ID", drawingLineID);

            try
            {
                connection.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        /// <summary>
        /// This Deletes multiple line items
        /// </summary>
        /// <param name="drawingLineItems"></param>
        public static void DeleteMultipleLineItems(string drawingLineItems)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            string deleteAllLineItemStatement = "DELETE FROM DrawingLines WHERE DLDrawingID = @drawingLineItems";
            SqlCommand deleteAllCommand = new SqlCommand(deleteAllLineItemStatement, connection);
            deleteAllCommand.Parameters.AddWithValue("@drawingLineItems", drawingLineItems);
            try
            {
                connection.Open();
                deleteAllCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
