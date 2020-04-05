using System.Data;
using System.Data.Common;
namespace MemorizeWords
{
   public class db
    {

        private string TableName;
        static DbProviderFactory fact;
        DbDataAdapter adapter;
        public db(string _tn)
        {
            TableName = _tn;
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Description");
            dt.Columns.Add("InvariantName");
            dt.Columns.Add("AssemblyQualifiedName");
            dt.Rows.Add("ADO.NET Provider for SQLite", "ADO.NET Provider for SQLite ", "System.Data.SQLite",
                            "System.Data.SQLite.SQLiteFactory, System.Data.SQLite");
            fact = DbProviderFactories.GetFactory(dt.Rows[0]);
            DbConnection conn = fact.CreateConnection();
            conn.ConnectionString = "data source=Memorize.db";
            adapter = fact.CreateDataAdapter();
            adapter.SelectCommand = conn.CreateCommand();
            DbCommand com = fact.CreateCommand();
            conn.Open();
            com.Connection = conn;
           
            com.CommandText= "CREATE TABLE IF NOT EXISTS 'dic' ('Word'  TEXT NOT NULL,'Meaning'   TEXT NOT NULL,'ID'    INTEGER NOT NULL,'ve'    BLOB,'va'    BLOB,PRIMARY KEY('Word'));";
            com.ExecuteNonQuery();
            conn.Close();
            
        }
        public DataTable Get()
        {
            
            adapter.SelectCommand.CommandText = "select * from "+TableName;
            DbCommandBuilder cb = fact.CreateCommandBuilder();
            cb.DataAdapter = adapter;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.Constraints.Add("pk_sno", dt.Columns[0], true);
            return dt;
        }
        public void UDT(DataTable dt)
        {
            adapter.Update(dt);
        }


    }
}
