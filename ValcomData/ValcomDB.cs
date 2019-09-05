using System;
using System.Data.SqlClient;
using System.Xml;

namespace ValcomData
{
    public static class ValcomDB
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        private static string GetConnectionString()
        {
            XmlTextReader xmlReader = new XmlTextReader("csValcom.xml");
            return xmlReader.ReadElementString("Connection");
        }
    }
}
