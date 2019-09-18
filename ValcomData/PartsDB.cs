using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValcomData
{
    public static class PartsDB
    {

        /// <summary>
        /// Get All Parts
        /// </summary>
        /// <returns></returns>
        public static List<Parts> GetPartsList()
        {
            List<Parts> partsList = new List<Parts>();
            SqlConnection connection = ValcomDB.GetConnection();
            string selectStatement = "SELECT * FROM Parts";

            SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Parts parts = new Parts();
                    parts.ID = (int)reader["ID"];
                    parts.PartID = reader["PartID"].ToString();
                    parts.PartDescription = reader["PartDescription"].ToString();
                    parts.DefaultSupplier = reader["DefaultSupplier"].ToString();
                    parts.Stock = reader["Stock"].ToString();
                    parts.QANote = reader["QANote"].ToString();
                    partsList.Add(parts);
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
            return partsList;
        }

        #region Not sure if i am going to use this method. Keeping for use later on maybe.
        /// <summary>
        /// Search for part
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public static List<Parts> SearchedPart(string searchValue)
        {
            List<Parts> partsList = new List<Parts>();
            SqlConnection connection = ValcomDB.GetConnection();

            string selectStatement = "SELECT * FROM Parts WHERE PartID = @PartID";

            SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);
            sqlCommand.Parameters.AddWithValue("@PartID", searchValue);

            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Parts part = new Parts();
                    part.ID = (int)reader["ID"];
                    part.PartID = reader["PartID"].ToString();
                    part.PartDescription = reader["PartDescription"].ToString();
                    part.DefaultSupplier = reader["DefaultSupplier"].ToString();
                    part.Stock = reader["Stock"].ToString();
                    part.QANote = reader["QANote"].ToString();

                    partsList.Add(part);
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
            return partsList;
        }
        #endregion

        /// <summary>
        /// Add New Part
        /// </summary>
        /// <param name="part"></param>
        public static bool AddPart(Parts part)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            string insertStatement = "INSERT Parts " +
                "(PartID, PartDescription, DefaultSupplier, Stock, QANote) " +
                "VALUES (@PartID, @PartDescription, @DefaultSupplier, @Stock, @QANote)";

            // Check if part exist in Database
            SqlCommand partExist = new SqlCommand("SELECT COUNT(*) FROM Parts WHERE PartID = @PartID AND PartDescription = @PartDescription", connection);
            partExist.Parameters.AddWithValue("@PartID", part.PartID);
            partExist.Parameters.AddWithValue("@PartDescription", part.PartDescription);

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PartID", part.PartID);
            insertCommand.Parameters.AddWithValue("@PartDescription", part.PartDescription);
            insertCommand.Parameters.AddWithValue("@DefaultSupplier", part.DefaultSupplier);
            insertCommand.Parameters.AddWithValue("@Stock", part.Stock);
            if (part.QANote == null)
            {
                insertCommand.Parameters.AddWithValue("@QANote", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@QANote", part.QANote);
            }


            try
            {
                connection.Open();
                int count = (int)partExist.ExecuteScalar();
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
        /// Update Part
        /// </summary>
        /// <param name="oldPart"></param>
        /// <param name="newPart"></param>
        /// <returns></returns>
        public static bool UpdatePart(Parts oldPart, Parts newPart)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            SqlTransaction updatePartTran = null;

            string updateStatement = 
                "UPDATE Parts SET " +
                "PartID = @NewPartID, " +
                "PartDescription = @NewPartDescription, " +
                "DefaultSupplier = @NewDefaultSupplier, " +
                "Stock = @NewStock, " +
                "QANote = @NewQANote " +
                "WHERE ID = @OldID " +
                "AND PartID = @OldPartID " +
                "AND PartDescription = @OldPartDescription " +
                "AND DefaultSupplier = @OldDefaultSupplier " +
                "AND Stock = @OldStock ";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@NewPartID", newPart.PartID);
            updateCommand.Parameters.AddWithValue("@NewPartDescription", newPart.PartDescription);
            updateCommand.Parameters.AddWithValue("@NewDefaultSupplier", newPart.DefaultSupplier);
            updateCommand.Parameters.AddWithValue("@NewStock", newPart.Stock);
            updateCommand.Parameters.AddWithValue("@NewQANote", newPart.QANote);

            updateCommand.Parameters.AddWithValue("@OldID", oldPart.ID);
            updateCommand.Parameters.AddWithValue("@OldPartID", oldPart.PartID);
            updateCommand.Parameters.AddWithValue("@OldPartDescription", oldPart.PartDescription);
            updateCommand.Parameters.AddWithValue("@OldDefaultSupplier", oldPart.DefaultSupplier);
            updateCommand.Parameters.AddWithValue("@OldStock", oldPart.Stock);
            //updateCommand.Parameters.AddWithValue("@OldQANote", oldPart.QANote);

            try
            {
                connection.Open();
                updatePartTran = connection.BeginTransaction();
                updateCommand.Transaction = updatePartTran;
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    updatePartTran.Commit();
                    return true;
                }
                else
                {
                    updatePartTran.Rollback();
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
        /// Delete Part
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static bool DeletePart(int Id)
        {
            SqlConnection connection = ValcomDB.GetConnection();
            string deleteStatement = "DELETE FROM Parts WHERE ID = @Id";
            SqlTransaction deletePartTrans = null;

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();
                deletePartTrans = connection.BeginTransaction();
                deleteCommand.Transaction = deletePartTrans;
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    deletePartTrans.Commit();
                    return true;
                }
                else
                {
                    deletePartTrans.Rollback();
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

        public static Parts GetPartDiscription(int id)
        {
            List<Parts> partsList = new List<Parts>();    
            SqlConnection connection = ValcomDB.GetConnection();
            Parts part = new Parts();
            string selectStatement = "SELECT * FROM Parts WHERE ID = @id";

            SqlCommand sqlCommand = new SqlCommand(selectStatement, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // NOTE: this needs to be an if statement see drawingDB class for example.
                    part.ID = (int)reader["ID"];
                    part.PartID = reader["PartID"].ToString();
                    part.PartDescription = reader["PartDescription"].ToString();
                    part.DefaultSupplier = reader["DefaultSupplier"].ToString();
                    part.Stock = reader["Stock"].ToString();
                    part.QANote = reader["QANote"].ToString();

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
            return part;
        }


    }
}
