﻿using System;
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

        private DateTime lastFrameStarted = new DateTime();
        private float currentFPS;

        public GameWorld()
        {
            SetupWorld();
        }

        public void SetupWorld()
        {
            //Starting FPS timert
            lastFrameStarted = DateTime.Now;
        }
        /// <summary>
        /// Makes sure all the update functions is called every frames
        /// </summary>
        public void GameLoop()
        {
            //Time spent since last loop
            TimeSpan deltaTime = DateTime.Now - lastFrameStarted;

            //Convert deltaTime to milliseconds, 1ms minimum
            int milliSeconds = deltaTime.Milliseconds > 0 ? deltaTime.Milliseconds : 1;
            currentFPS = 1000 / milliSeconds;

            //Set new frame start
            lastFrameStarted = DateTime.Now;

            Update();

        }

        public void Update()
        {

        }


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
            string txtSQLQuery = "insert into figur4 values (null,'ole')";
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
