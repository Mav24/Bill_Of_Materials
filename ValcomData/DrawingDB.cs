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
            using (SqlConnection connection = ValcomDB.GetConnection())
            using (SqlCommand sqlCommand = connection.CreateCommand())
            {
                sqlCommand.CommandText = "Select DrawingID FROM Drawings ";

                connection.Open();
                List<string> listofDrawings = new List<string>();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listofDrawings.Add(reader[0].ToString());

                    }
                    reader.Close();
                }
                return listofDrawings;
            }
            #region Old Method using try catch and finally
            //SqlConnection connection = ValcomDB.GetConnection();

            //string selectStatement = "Select DrawingID FROM Drawings ";
            //SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);

            //try
            //{
            //    connection.Open();
            //    SqlDataReader reader = sqlCommand.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        listofDrawings.Add(reader[0].ToString());

            //    }
            //    reader.Close();
            //}
            //catch (SqlException ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    connection.Close();
            //}
            //return listofDrawings;
            #endregion

        }

        /// <summary>
        /// Get Drawing INFO
        /// </summary>
        /// <param name="drawingID"></param>
        /// <returns></returns>
        public static Drawing GetDrawingInfo(string drawingID)
        {
            using (SqlConnection connection = ValcomDB.GetConnection())
            using (SqlCommand sqlCommand = connection.CreateCommand())
            {
                sqlCommand.CommandText = "SELECT * FROM Drawings WHERE DrawingID = @DrawingID ";
                sqlCommand.Parameters.Add("@DrawingID", SqlDbType.NVarChar).Value = drawingID;
                connection.Open();
                Drawing drawing = new Drawing();
                using (SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (reader.Read())
                    {
                        drawing.ID = (int)reader["ID"];
                        drawing.DrawingID = reader["DrawingID"].ToString();
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
                }
                return drawing;
            }
            #region Old Method with try catch finally
            //Drawing drawing = new Drawing();
            //SqlConnection connection = ValcomDB.GetConnection();
            //string selectStatement = "SELECT * FROM Drawings WHERE DrawingID = @DrawingID ";

            //SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);
            //sqlCommand.Parameters.AddWithValue("@DrawingID", drawingID);
            //try
            //{
            //    connection.Open();
            //    SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
            //    if (reader.Read())
            //    {
            //        drawing.ID = (int)reader["ID"];
            //        drawing.DrawingID = reader["DrawingID"].ToString();
            //        //string date = reader["DateCreated"].ToString();
            //        //drawing.DateCreated = (DateTime)reader["DateCreated"];
            //        if (reader["DateCreated"] == DBNull.Value)
            //            drawing.DateCreated = DateTime.Now;
            //        else
            //            drawing.DateCreated = (DateTime)reader["DateCreated"];
            //        drawing.BOMDescription = reader["BOMDescription"].ToString();
            //        drawing.NSN = reader["NSN"].ToString();
            //        drawing.AddedBy = reader["AddedBy"].ToString();
            //        drawing.DateModified = reader["DateModified"].ToString();
            //        if (reader["DateModified"] == DBNull.Value)
            //        {
            //            drawing.DateModifedNotNull = drawing.DateCreated;
            //        }
            //        else
            //        {
            //            drawing.DateModifedNotNull = (DateTime)reader["DateModified"];
            //        }
            //        drawing.Changes = reader["Changes"].ToString();


            //    }
            //    else
            //    {
            //        return null;
            //    }
            //    reader.Close();
            //}
            //catch (SqlException ex)
            //{

            //    throw ex;
            //}
            //finally
            //{
            //    connection.Close();
            //}
            //return drawing;
            #endregion
        }

        /// <summary>
        /// Add new drawing
        /// </summary>
        /// <param name="drawing"></param>
        /// <returns></returns>
        public static bool AddDrawing(Drawing drawing)
        {
            using (SqlConnection connection = ValcomDB.GetConnection())
            using (SqlCommand check_if_drawing_Exist = connection.CreateCommand())
            using (SqlCommand insertCommand = connection.CreateCommand())
            {
                insertCommand.CommandText = "INSERT Drawings " +
                "(DrawingID, DateCreated, BOMDescription, NSN, AddedBy, DateModified) " +
                "VALUES (@DrawingID, @DateCreated, @BOMDescription, @NSN, @AddedBy, @DateModified)";
                check_if_drawing_Exist.CommandText = "SELECT COUNT(*) FROM Drawings WHERE DrawingID = @DrawingID ";
                check_if_drawing_Exist.Parameters.Add("@drawingID", SqlDbType.NVarChar).Value = drawing.DrawingID;

                insertCommand.Parameters.Add("@DrawingID", SqlDbType.NVarChar).Value = drawing.DrawingID;
                insertCommand.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = DateTime.Now;
                insertCommand.Parameters.Add("@BOMDescription", SqlDbType.NVarChar).Value = drawing.BOMDescription;
                if (drawing.NSN == null)
                {
                    insertCommand.Parameters.Add("@NSN", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    insertCommand.Parameters.Add("@NSN", SqlDbType.NVarChar).Value = drawing.NSN;
                }

                insertCommand.Parameters.Add("@AddedBy", SqlDbType.NVarChar).Value = drawing.AddedBy;
                insertCommand.Parameters.Add("@DateModified", SqlDbType.DateTime).Value = DateTime.Now;

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

            #region Old Try catch finally method
            //SqlConnection connection = ValcomDB.GetConnection();
            //string insertStatement = "INSERT Drawings " +
            //    "(DrawingID, DateCreated, BOMDescription, NSN, AddedBy, DateModified) " +
            //    "VALUES (@DrawingID, @DateCreated, @BOMDescription, @NSN, @AddedBy, @DateModified)";

            //// Check if the DrawingID already exist in the database before entry
            //SqlCommand check_if_drawing_Exist = new SqlCommand("SELECT COUNT(*) FROM Drawings WHERE DrawingID = @DrawingID ", connection);
            //check_if_drawing_Exist.Parameters.AddWithValue("@drawingID", drawing.DrawingID);

            //SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            //insertCommand.Parameters.AddWithValue("@DrawingID", drawing.DrawingID);
            //insertCommand.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            //insertCommand.Parameters.AddWithValue("@BOMDescription", drawing.BOMDescription);;
            //if (drawing.NSN == null)
            //{
            //    insertCommand.Parameters.AddWithValue("@NSN", DBNull.Value);
            //}
            //else
            //{
            //    insertCommand.Parameters.AddWithValue("@NSN", drawing.NSN);
            //}

            //insertCommand.Parameters.AddWithValue("@AddedBy", drawing.AddedBy);
            //insertCommand.Parameters.AddWithValue("@DateModified", DateTime.Now);

            //try
            //{
            //    connection.Open();
            //    int count = (int)check_if_drawing_Exist.ExecuteScalar();
            //    if (count > 0)
            //    {  
            //        return false;
            //    }
            //    else
            //    {
            //        insertCommand.ExecuteNonQuery();
            //        return true;
            //    }

            //}
            //catch (SqlException ex)
            //{

            //    throw ex;
            //}
            //finally
            //{
            //    connection.Close();
            //}
            #endregion

        }


        /// <summary>
        /// Update Drawing Method
        /// </summary>
        /// <param name="oldDrawing"></param>
        /// <param name="newDrawing"></param>
        /// <returns></returns>
        public static bool UpdateDrawing(Drawing oldDrawing, Drawing newDrawing)
        {
            #region This is the Using statement another way of writing this method
            //using (var connection = ValcomDB.GetConnection())
            //using (var updateCommand = connection.CreateCommand())
            //{
            //    updateCommand.CommandText = "UPDATE Drawings SET " + 
            //        "BOMDescription = @NewBOMDescription, " + 
            //        "AddedBy = @NewAddedBy, " +
            //        "DateModified = @NewDateModified, " +
            //        "Changes = @NewChanges " +
            //        "WHERE ID = @OldID ";

            //    updateCommand.Parameters.Add("@NewBOMDescription", SqlDbType.NVarChar).Value = newDrawing.BOMDescription;
            //    updateCommand.Parameters.Add("@NewNSN", SqlDbType.NVarChar).Value = newDrawing.NSN;
            //    updateCommand.Parameters.Add("@NewAddedBy", SqlDbType.NVarChar).Value = newDrawing.AddedBy;
            //    updateCommand.Parameters.Add("@NewDateModified", SqlDbType.DateTime).Value = DateTime.Now;
            //    updateCommand.Parameters.Add("@NewChanges", SqlDbType.NVarChar).Value = newDrawing.Changes;

            //    connection.Open();
            //    SqlTransaction updateDrawingTran = connection.BeginTransaction();
            //    updateCommand.Transaction = updateDrawingTran;
            //    int count = updateCommand.ExecuteNonQuery();
            //    if (count > 0)
            //    {
            //        updateDrawingTran.Commit();
            //        return true;
            //    }
            //    else
            //    {
            //        updateDrawingTran.Rollback();
            //        return false;
            //    }


            //}

            #endregion
            SqlConnection connection = ValcomDB.GetConnection();

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
                SqlTransaction updateDrawingTran = connection.BeginTransaction();
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
            using (var connection = ValcomDB.GetConnection())
            using(var deleteCommand = connection.CreateCommand())
            {
                deleteCommand.CommandText = "DELETE FROM Drawings WHERE ID = @ID";
                deleteCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Id;

                connection.Open();
                deleteCommand.ExecuteNonQuery();
            }

            #region This is old sql connection and command. Marked for delete Oct 15 2019
            //SqlConnection connection = ValcomDB.GetConnection();
            //string deleteStatement = "DELETE FROM Drawings WHERE ID = @ID";
            //SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            //deleteCommand.Parameters.AddWithValue("@ID", Id);

            //try
            //{
            //    connection.Open();
            //    deleteCommand.ExecuteNonQuery();
            //}
            //catch (SqlException ex)
            //{

            //    throw ex;
            //}
            //finally
            //{
            //    connection.Close();
            //}
            #endregion

        }
    }
}
