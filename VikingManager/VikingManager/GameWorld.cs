using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace VikingManager
{
    class GameWorld
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public void SetConnection()
        {
            sql_con = new SQLiteConnection(@"Data Source=C:\Users\Ole\testole.db;Version=3;New=False;Compress=True;");
        }

        public void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select id, desc from mains";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            //   Grid.DataSource = DT;
            sql_con.Close();
        }

        public void Add()
        {
            string txtSQLQuery = "insert into  figur4 values (null,'ole')";
            //txtSQLQuery = "create table figur4(id integer,navn varchar(4), primary key(id))";

            ExecuteQuery(txtSQLQuery);
        }

        public void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
    }
}
