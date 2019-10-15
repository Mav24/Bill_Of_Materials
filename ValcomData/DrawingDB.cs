using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValcomData
{
    public static class DrawingDB
    {
        public static List<string> GetListofDrawings()
        {
            List<string> listofDrawings = new List<string>();
            SqlConnection connection = ValcomDB.GetConnection();

            string selectStatement = "Select DrawingID FROM Drawings ";
            SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    listofDrawings.Add(reader[0].ToString());

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
            return listofDrawings;
        }


        #region this is the way of getting List of Drawings Not used****
        //public static List<Drawing> GetListofDrawings()
        //{
        //    List<Drawing> drawingList = new List<Drawing>();
        //    SqlConnection connection = ValcomDB.GetConnection();
        //    string selectStatement = "SELECT * FROM Drawings ";
        //    SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = sqlCommand.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Drawing drawing = new Drawing();
        //            drawing.ID = (int)reader["ID"];
        //            drawing.DrawingID = reader["DrawingID"].ToString();

        //            #region Not sure if I need this stuff keeping to make sure
        //            //drawing.DateModified = (DateTime)reader["DateModified"];
        //            //drawing.BOMDescription = reader["BOMDescription"].ToString();
        //            //drawing.NSN = reader["NSN"].ToString();
        //            //drawing.AddedBy = reader["AddedBy"].ToString();
        //            #endregion

        //            drawingList.Add(drawing);
        //        }
        //        reader.Close();
        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return drawingList;
        //}
        #endregion

              

        /// <summary>
        /// Get Drawing INFO
        /// </summary>
        /// <param name="drawingID"></param>
        /// <returns></returns>
        public static Drawing GetDrawingInfo(string drawingID)
        {
            Drawing drawing = new Drawing();
            SqlConnection connection = ValcomDB.GetConnection();
            string selectStatement = "SELECT * FROM Drawings WHERE DrawingID = @DrawingID ";

            SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);
            sqlCommand.Parameters.AddWithValue("@DrawingID", drawingID);
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    drawing.ID = (int)reader["ID"];
                    drawing.DrawingID = reader["DrawingID"].ToString();
                    //string date = reader["DateCreated"].ToString();
                    //drawing.DateCreated = (DateTime)reader["DateCreated"];
                    if (reader["DateCreated"] == DBNull.Value)
                        drawing.DateCreated = DateTime.Now;
                    else
                        drawing.DateCreated = (DateTime)reader["DateCreated"];
                    drawing.BOMDescription = reader["BOMDescription"].ToString();
                    drawing.NSN = reader["NSN"].ToString();
                    drawing.AddedBy = reader["AddedBy"].ToString();
                    drawing.DateModified = reader["DateModified"].ToString();
                    if (reader["DateModified"] == DBNull.Value)
                    {
                        drawing.DateModifedNotNull = drawing.DateCreated;
                    }
                    else
                    {
                        drawing.DateModifedNotNull = (DateTime)reader["DateModified"];
                    }
                    drawing.Changes = reader["Changes"].ToString();
                    
                    
                }
                else
                {
                    return null;
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
            return drawing;
        }

        /// <summary>
        /// Add new drawing
        /// </summary>
        /// <param name="drawing"></param>
        /// <returns></returns>
        public static bool AddDrawing(Drawing drawing)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            string insertStatement = "INSERT Drawings " +
                "(DrawingID, DateCreated, BOMDescription, NSN, AddedBy, DateModified) " +
                "VALUES (@DrawingID, @DateCreated, @BOMDescription, @NSN, @AddedBy, @DateModified)";

            // Check if the DrawingID already exist in the database before entry
            SqlCommand check_if_drawing_Exist = new SqlCommand("SELECT COUNT(*) FROM Drawings WHERE DrawingID = @DrawingID ", connection);
            check_if_drawing_Exist.Parameters.AddWithValue("@drawingID", drawing.DrawingID);

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@DrawingID", drawing.DrawingID);
            insertCommand.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            insertCommand.Parameters.AddWithValue("@BOMDescription", drawing.BOMDescription);;
            if (drawing.NSN == null)
            {
                insertCommand.Parameters.AddWithValue("@NSN", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@NSN", drawing.NSN);
            }

            insertCommand.Parameters.AddWithValue("@AddedBy", drawing.AddedBy);
            insertCommand.Parameters.AddWithValue("@DateModified", DateTime.Now);

            try
            {
                connection.Open();
                int count = (int)check_if_drawing_Exist.ExecuteScalar();
                if (count > 0)
                {  
                    return false;
                }
                else
                {
                    insertCommand.ExecuteNonQuery();
                    return true;
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
            /// Update Drawing Method
            /// </summary>
            /// <param name="oldDrawing"></param>
            /// <param name="newDrawing"></param>
            /// <returns></returns>
        public static bool UpdateDrawing(Drawing oldDrawing, Drawing newDrawing)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            SqlTransaction updateDrawingTran = null;

            string updateStatement =
                "UPDATE Drawings SET " +
                  "BOMDescription = @NewBOMDescription, " +
                  "NSN = @NewNSN, " +
                  "AddedBy = @NewAddedBy, " +
                  "DateModified = @NewDateModified, " +
                  "Changes = @NewChanges " +
                "WHERE ID = @OldID ";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewBOMDescription", newDrawing.BOMDescription);
            updateCommand.Parameters.AddWithValue("@NewNSN", newDrawing.NSN);
            updateCommand.Parameters.AddWithValue("@NewAddedBy", newDrawing.AddedBy);
            updateCommand.Parameters.AddWithValue("@NewDateModified", DateTime.Now);
            updateCommand.Parameters.AddWithValue("@NewChanges", newDrawing.Changes);

            updateCommand.Parameters.AddWithValue("@OldID", oldDrawing.ID);

            try
            {
                connection.Open();
                updateDrawingTran = connection.BeginTransaction();
                updateCommand.Transaction = updateDrawingTran;
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    updateDrawingTran.Commit();
                    return true;
                }
                else
                {
                    updateDrawingTran.Rollback();
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
            /// Delete Drawing Method
            /// </summary>
            /// <param name="Id"></param>
        public static void DeleteDrawing(int Id)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            string deleteStatement = "DELETE FROM Drawings WHERE ID = @ID";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@ID", Id);

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
    }
}
