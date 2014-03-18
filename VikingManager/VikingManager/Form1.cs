using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VikingManager
{
    public partial class Form1 : Form
    {
        //Fields
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private DateTime lastFrameStarted = new DateTime();
        

        //Form1
        #region Form1 stuff
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 40;
            pnl_Target.Visible = false;
            tab_Cities.AutoScroll = true;
            pnl_Build.Visible = false;
        }

        private void tab_Build_Click(object sender, EventArgs e)
        {
            
        }
        #region Attack Buttons
        private void btn_Atk_London_Click(object sender, EventArgs e)
        {
            if (pnl_Target.Visible == false)
                pnl_Target.Visible = true;
            else
                pnl_Target.Visible = false;
        }

        private void btn_Atk_NewYork_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atk_Berlin_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atk_Paris_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atk_Rom_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atk_Barcelona_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atk_Athen_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atk_Venice_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atk_Amsterdam_Click(object sender, EventArgs e)
        {

        }

        // Confirm
        private void btn_Confirm_Target_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Target_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Build Buttons
        private void btn_Build_Ship_Yard_Click(object sender, EventArgs e)
        {
            BuildingAdd(7);
        }

        private void btn_Build_Field_Click(object sender, EventArgs e)
        {
            BuildingAdd(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Build_Armory_Click(object sender, EventArgs e)
        {
            BuildingAdd(4);
        }

        private void Btn_Build_Brewery_Click(object sender, EventArgs e)
        {
            BuildingAdd(5);
        }

        private void btn_Build_Infirmary_Click(object sender, EventArgs e)
        {
            BuildingAdd(6);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Build_Camp_Click(object sender, EventArgs e)
        {
            BuildingAdd(3);
        }
        #endregion

        private void btn_Show_Build_Pnl_Click(object sender, EventArgs e)
        {
            if (pnl_Build.Visible == false)
                pnl_Build.Visible = true;
            else
                pnl_Build.Visible = false;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateText();
        }
        #endregion

        //Functions
        /// <summary>
        /// Initializes the content required to start the game. Not necessary if we create the database manually and add that to the game.
        /// </summary>
        public void SetupWorld()
        {
            //Starting FPS timer
            lastFrameStarted = DateTime.Now;
        }

        /// <summary>
        /// Makes sure all the update functions is called every frame
        /// </summary>
        //public void GameLoop()
        //{
        //    //Time spent since last loop
        //    TimeSpan deltaTime = DateTime.Now - lastFrameStarted;

        //    //Convert deltaTime to milliseconds, 1ms minimum
        //    int milliSeconds = deltaTime.Milliseconds > 0 ? deltaTime.Milliseconds : 1;
        //    currentFPS = 1000 / milliSeconds;

        //    //Set new frame start
        //    lastFrameStarted = DateTime.Now;

        //    UpdateText();

        //}
        /// <summary>
        /// Update function - should update the text in the textboxes and stuff
        /// </summary>
        public void UpdateText()
        {

            ReadText("select SUM(Repair) from Building where BuildTypeID = 7", lbl_Building_stats, "Shipyards repair per minute");

        }

        /// <summary>
        /// Reads text from database
        /// </summary>
        /// <param name="query"></param>
        /// <param name="label"></param>
        /// <param name="extraText"></param>
        public void ReadText(string query, Label label, string extraText)
        {
            SetConnection();
            sql_con.Open();
            SQLiteCommand selectCommand = new SQLiteCommand(query, sql_con);
            SQLiteDataReader dataReader = selectCommand.ExecuteReader();

            while (dataReader.Read())
            {
                label.Text = String.Format("{0}: {1}", extraText, dataReader[0].ToString());
            }

            dataReader.Close();
            sql_con.Close();
        }

        public void SetConnection()
        {
            sql_con = new SQLiteConnection(@"Data Source=Database\VikingManagerDB;Version=3;New=False;Compress=True;");
        }

        #region ReadStuff
        #endregion

        #region AddStuff
        /*
        /// <summary>
        /// add inhabitant
        /// </summary>
        public void InhabitantAdd()
        {
            if (soldier == true)
            {
                string soldierQuery = "insert into Inhabitant values (null,1,soldier+ID,25,10,5,8,1,4)";
                ExecuteQuery(soldierQuery);
            }
            else
            {
                string civilQuery = "insert into Inhabitant values (null,1,Civil+ID,1,null,null,null,null,1)";
                ExecuteQuery(civilQuery);
            }
        }
        /// <summary>
        /// add soldier
        /// </summary>
        public void SoldierAdd()
        {
            if (Crew == true)
            {
                string prisenorQuery = "insert into Soldier values (null,1,prisenor+ID,1,null,null,null,null,1)";
                ExecuteQuery(prisenorQuery);
            }
            else
            {
                string prisenorQuery = "insert into Soldier values (null,1,prisenor+ID,1,null,null,null,null,1)";
                ExecuteQuery(prisenorQuery);
            }
        }
        */
        /// <summary>
        /// Adding ships if you have a shipyard
        /// </summary>
        public void ShipAdd()
        {
            string ShipyardCheckQuery = "select Count(BuildTypeID) from Building where BuildTypeID = 7";
            if (!string.IsNullOrEmpty(ShipyardCheckQuery))
            {
                string shipQuery = "insert into Ship values (null,1,50,50,1)";
                ExecuteQuery(shipQuery);
            }
        }
        /// <summary>
        /// Adding building
        /// </summary>
        public void BuildingAdd(int buildingType)
        {
            string buildingQuery;
            switch (buildingType)
            {
                //field
                case 1:
                    buildingQuery = "insert into Building values (null,1,1,1,20,null,15,null,null,null,null)";
                    ExecuteQuery(buildingQuery);
                    break;
                //Wall
                case 2:
                    buildingQuery = "insert into Building values (null,2,1,1,25,null,null,null,null,null,20)";
                    ExecuteQuery(buildingQuery);
                    break;
                //Camp
                case 3:
                    buildingQuery = "insert into Building values (null,3,1,1,35,null,null,null,null,null,null)";
                    ExecuteQuery(buildingQuery);
                    break;
                //Armory
                case 4:
                    buildingQuery = "insert into Building values (null,4,1,1,30,null,null,10,null,null,null)";
                    ExecuteQuery(buildingQuery);
                    break;
                //Brewery
                case 5:
                    buildingQuery = "insert into Building values (null,5,1,1,20,null,null,null,20,null,null)";
                    ExecuteQuery(buildingQuery);
                    break;
                //Infirmary
                case 6:
                    buildingQuery = "insert into Building values (null,6,1,1,25,null,null,null,null,5,null)";
                    ExecuteQuery(buildingQuery);
                    break;
                //Shipyard
                case 7:
                    buildingQuery = "insert into Building values(null,7,1,1,20,10,null,null,null,null,null)";
                    ExecuteQuery(buildingQuery);
                    break;
            }

        }
        #endregion

        #region ModifyStuff
        public void ModifySoldier(int soldierID)
        {

        }
        #endregion

        #region Deletestuff
        public void DeleteSoldier(int soldierID)
        {
            string soldierDeleteQuery = "Delete ID from Soldier where SoldierID == SoldierID";
            ExecuteQuery(soldierDeleteQuery);
        }

        public void DeleteShip(int shipID)
        {
            string shipDeleteQuery = "Delete ID from Ship where ShipID == ShipID";

            ExecuteQuery(shipDeleteQuery);
        }
        #endregion

        /// <summary>
        /// Executes the given query.
        /// </summary>
        /// <param name="txtQuery"></param>
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
