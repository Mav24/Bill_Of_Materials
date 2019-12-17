using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValcomData
{
    public static class SupplierDB
    {
        public static List<string> GetSuppliers()
        {
            using (SqlConnection connection = ValcomDB.GetConnection())
            using (SqlCommand sqlCommand = connection.CreateCommand())
            {
                sqlCommand.CommandText = "Select SupplierName FROM Supplier ";

                connection.Open();
                List<string> listOfSupplierNames = new List<string>();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listOfSupplierNames.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                return listOfSupplierNames;
            }
        }


        public static Supplier GetSupplierInfo(string supplierName)
        {
            using (SqlConnection connection = ValcomDB.GetConnection())
            using (SqlCommand sqlCommand = connection.CreateCommand())
            {
                sqlCommand.CommandText = "SELECT * FROM Supplier WHERE @SupplierName ";
                sqlCommand.Parameters.Add("@SupplierName", SqlDbType.NVarChar).Value = supplierName;
                connection.Open();
                Supplier supplier = new Supplier();
                using (SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (reader.Read())
                    {
                        supplier.ID = (int)reader["ID"];
                        supplier.SupplierName = reader["SupplierName"].ToString();
                        supplier.ContactName = reader["ContactName"].ToString();
                        supplier.Address = reader["Address"].ToString();
                        supplier.City = reader["City"].ToString();
                        supplier.PostalCode = reader["PostalCode"].ToString();
                        supplier.Region = reader["Region"].ToString();
                        supplier.Country = reader["Country"].ToString();
                        supplier.PhoneNumber = reader["PhoneNumber"].ToString();
                        supplier.FaxNumber = reader["FaxNumber"].ToString();
                        supplier.Email = reader["Email"].ToString();
                        supplier.PaymentTerms = reader["PaymentTerms"].ToString();
                        supplier.Notes = reader["Notes"].ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                return supplier;
            }
        }
    }
}
