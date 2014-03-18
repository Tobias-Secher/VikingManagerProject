namespace VikingManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Current_Mission = new System.Windows.Forms.Label();
            this.rtb_Current_Mission = new System.Windows.Forms.RichTextBox();
            this.tc_Main_Stats = new System.Windows.Forms.TabControl();
            this.tab_Ciry_Stat = new System.Windows.Forms.TabPage();
            this.lbl_City_Stats = new System.Windows.Forms.Label();
            this.tab_Build = new System.Windows.Forms.TabPage();
            this.lbl_Building_stats = new System.Windows.Forms.Label();
            this.tab_Camp = new System.Windows.Forms.TabPage();
            this.lbl_Camp_Stats = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Cities = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_Atk_Amsterdam = new System.Windows.Forms.Button();
            this.btn_Atk_Venice = new System.Windows.Forms.Button();
            this.btn_Atk_Athen = new System.Windows.Forms.Button();
            this.btn_Atk_Barcelona = new System.Windows.Forms.Button();
            this.btn_Atk_Rom = new System.Windows.Forms.Button();
            this.btn_Atk_Paris = new System.Windows.Forms.Button();
            this.lbl_Atk_Berlin_Perc = new System.Windows.Forms.Label();
            this.lbl_Atk_NY_Perc = new System.Windows.Forms.Label();
            this.btn_Atk_Berlin = new System.Windows.Forms.Button();
            this.btn_Atk_NewYork = new System.Windows.Forms.Button();
            this.lbl_Atl_London_Prec = new System.Windows.Forms.Label();
            this.btn_Atk_London = new System.Windows.Forms.Button();
            this.tab_Soldier = new System.Windows.Forms.TabPage();
            this.tab_Ship = new System.Windows.Forms.TabPage();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_Show_Build_Pnl = new System.Windows.Forms.Button();
            this.pnl_Target = new System.Windows.Forms.Panel();
            this.btn_Cancel_Target = new System.Windows.Forms.Button();
            this.btn_Confirm_Target = new System.Windows.Forms.Button();
            this.lbl_Target_Info = new System.Windows.Forms.Label();
            this.lbl_Crew_Info = new System.Windows.Forms.Label();
            this.lbl_Ship_Info = new System.Windows.Forms.Label();
            this.rtb_Atk_Target_Info = new System.Windows.Forms.RichTextBox();
            this.rtb_Atk_Crew_Info = new System.Windows.Forms.RichTextBox();
            this.rtb_Atk_Ship_Info = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_Build = new System.Windows.Forms.Panel();
            this.pnl_Show_Buildings = new System.Windows.Forms.Panel();
            this.lbl_Show_Buildings = new System.Windows.Forms.Label();
            this.btn_Build_Camp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Build_Infirmary = new System.Windows.Forms.Button();
            this.Btn_Build_Brewery = new System.Windows.Forms.Button();
            this.btn_Build_Armory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Build_Field = new System.Windows.Forms.Button();
            this.btn_Build_Ship_Yard = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grid = new System.Windows.Forms.DataGridView();
            this.tc_Main_Stats.SuspendLayout();
            this.tab_Ciry_Stat.SuspendLayout();
            this.tab_Build.SuspendLayout();
            this.tab_Camp.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Cities.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_Target.SuspendLayout();
            this.pnl_Build.SuspendLayout();
            this.pnl_Show_Buildings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Current_Mission
            // 
            this.lbl_Current_Mission.AutoSize = true;
            this.lbl_Current_Mission.Location = new System.Drawing.Point(2, 4);
            this.lbl_Current_Mission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Current_Mission.Name = "lbl_Current_Mission";
            this.lbl_Current_Mission.Size = new System.Drawing.Size(79, 13);
            this.lbl_Current_Mission.TabIndex = 0;
            this.lbl_Current_Mission.Text = "Current Mission";
            // 
            // rtb_Current_Mission
            // 
            this.rtb_Current_Mission.Location = new System.Drawing.Point(2, 21);
            this.rtb_Current_Mission.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_Current_Mission.Name = "rtb_Current_Mission";
            this.rtb_Current_Mission.ReadOnly = true;
            this.rtb_Current_Mission.Size = new System.Drawing.Size(144, 279);
            this.rtb_Current_Mission.TabIndex = 1;
            this.rtb_Current_Mission.Text = "";
            // 
            // tc_Main_Stats
            // 
            this.tc_Main_Stats.Controls.Add(this.tab_Ciry_Stat);
            this.tc_Main_Stats.Controls.Add(this.tab_Build);
            this.tc_Main_Stats.Controls.Add(this.tab_Camp);
            this.tc_Main_Stats.Location = new System.Drawing.Point(2, 328);
            this.tc_Main_Stats.Margin = new System.Windows.Forms.Padding(2);
            this.tc_Main_Stats.Name = "tc_Main_Stats";
            this.tc_Main_Stats.SelectedIndex = 0;
            this.tc_Main_Stats.Size = new System.Drawing.Size(344, 251);
            this.tc_Main_Stats.TabIndex = 2;
            // 
            // tab_Ciry_Stat
            // 
            this.tab_Ciry_Stat.Controls.Add(this.lbl_City_Stats);
            this.tab_Ciry_Stat.Location = new System.Drawing.Point(4, 22);
            this.tab_Ciry_Stat.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Ciry_Stat.Name = "tab_Ciry_Stat";
            this.tab_Ciry_Stat.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Ciry_Stat.Size = new System.Drawing.Size(336, 225);
            this.tab_Ciry_Stat.TabIndex = 0;
            this.tab_Ciry_Stat.Text = "City";
            this.tab_Ciry_Stat.UseVisualStyleBackColor = true;
            // 
            // lbl_City_Stats
            // 
            this.lbl_City_Stats.AutoSize = true;
            this.lbl_City_Stats.Location = new System.Drawing.Point(6, 6);
            this.lbl_City_Stats.Name = "lbl_City_Stats";
            this.lbl_City_Stats.Size = new System.Drawing.Size(51, 13);
            this.lbl_City_Stats.TabIndex = 0;
            this.lbl_City_Stats.Text = "City Stats";
            // 
            // tab_Build
            // 
            this.tab_Build.Controls.Add(this.lbl_Building_stats);
            this.tab_Build.Location = new System.Drawing.Point(4, 22);
            this.tab_Build.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Build.Name = "tab_Build";
            this.tab_Build.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Build.Size = new System.Drawing.Size(336, 225);
            this.tab_Build.TabIndex = 1;
            this.tab_Build.Text = "Build";
            this.tab_Build.UseVisualStyleBackColor = true;
            this.tab_Build.Click += new System.EventHandler(this.tab_Build_Click);
            // 
            // lbl_Building_stats
            // 
            this.lbl_Building_stats.AutoSize = true;
            this.lbl_Building_stats.Location = new System.Drawing.Point(6, 6);
            this.lbl_Building_stats.Name = "lbl_Building_stats";
            this.lbl_Building_stats.Size = new System.Drawing.Size(68, 13);
            this.lbl_Building_stats.TabIndex = 0;
            this.lbl_Building_stats.Text = "building stats";
            // 
            // tab_Camp
            // 
            this.tab_Camp.Controls.Add(this.lbl_Camp_Stats);
            this.tab_Camp.Location = new System.Drawing.Point(4, 22);
            this.tab_Camp.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Camp.Name = "tab_Camp";
            this.tab_Camp.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Camp.Size = new System.Drawing.Size(336, 225);
            this.tab_Camp.TabIndex = 2;
            this.tab_Camp.Text = "Camp";
            this.tab_Camp.UseVisualStyleBackColor = true;
            // 
            // lbl_Camp_Stats
            // 
            this.lbl_Camp_Stats.AutoSize = true;
            this.lbl_Camp_Stats.Location = new System.Drawing.Point(4, 6);
            this.lbl_Camp_Stats.Name = "lbl_Camp_Stats";
            this.lbl_Camp_Stats.Size = new System.Drawing.Size(58, 13);
            this.lbl_Camp_Stats.TabIndex = 0;
            this.lbl_Camp_Stats.Text = "camp stats";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Cities);
            this.tabControl1.Controls.Add(this.tab_Soldier);
            this.tabControl1.Controls.Add(this.tab_Ship);
            this.tabControl1.Location = new System.Drawing.Point(165, 21);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(181, 282);
            this.tabControl1.TabIndex = 3;
            // 
            // tab_Cities
            // 
            this.tab_Cities.Controls.Add(this.button7);
            this.tab_Cities.Controls.Add(this.btn_Atk_Amsterdam);
            this.tab_Cities.Controls.Add(this.btn_Atk_Venice);
            this.tab_Cities.Controls.Add(this.btn_Atk_Athen);
            this.tab_Cities.Controls.Add(this.btn_Atk_Barcelona);
            this.tab_Cities.Controls.Add(this.btn_Atk_Rom);
            this.tab_Cities.Controls.Add(this.btn_Atk_Paris);
            this.tab_Cities.Controls.Add(this.lbl_Atk_Berlin_Perc);
            this.tab_Cities.Controls.Add(this.lbl_Atk_NY_Perc);
            this.tab_Cities.Controls.Add(this.btn_Atk_Berlin);
            this.tab_Cities.Controls.Add(this.btn_Atk_NewYork);
            this.tab_Cities.Controls.Add(this.lbl_Atl_London_Prec);
            this.tab_Cities.Controls.Add(this.btn_Atk_London);
            this.tab_Cities.Location = new System.Drawing.Point(4, 22);
            this.tab_Cities.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Cities.Name = "tab_Cities";
            this.tab_Cities.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Cities.Size = new System.Drawing.Size(173, 256);
            this.tab_Cities.TabIndex = 0;
            this.tab_Cities.Text = "Cities";
            this.tab_Cities.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 256);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Nuuk";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_Atk_Amsterdam
            // 
            this.btn_Atk_Amsterdam.Location = new System.Drawing.Point(5, 227);
            this.btn_Atk_Amsterdam.Name = "btn_Atk_Amsterdam";
            this.btn_Atk_Amsterdam.Size = new System.Drawing.Size(90, 23);
            this.btn_Atk_Amsterdam.TabIndex = 11;
            this.btn_Atk_Amsterdam.Text = "Amsterdam";
            this.btn_Atk_Amsterdam.UseVisualStyleBackColor = true;
            this.btn_Atk_Amsterdam.Click += new System.EventHandler(this.btn_Atk_Amsterdam_Click);
            // 
            // btn_Atk_Venice
            // 
            this.btn_Atk_Venice.Location = new System.Drawing.Point(4, 197);
            this.btn_Atk_Venice.Name = "btn_Atk_Venice";
            this.btn_Atk_Venice.Size = new System.Drawing.Size(91, 23);
            this.btn_Atk_Venice.TabIndex = 10;
            this.btn_Atk_Venice.Text = " Venice";
            this.btn_Atk_Venice.UseVisualStyleBackColor = true;
            this.btn_Atk_Venice.Click += new System.EventHandler(this.btn_Atk_Venice_Click);
            // 
            // btn_Atk_Athen
            // 
            this.btn_Atk_Athen.Location = new System.Drawing.Point(5, 167);
            this.btn_Atk_Athen.Name = "btn_Atk_Athen";
            this.btn_Atk_Athen.Size = new System.Drawing.Size(90, 23);
            this.btn_Atk_Athen.TabIndex = 9;
            this.btn_Atk_Athen.Text = "Athen";
            this.btn_Atk_Athen.UseVisualStyleBackColor = true;
            this.btn_Atk_Athen.Click += new System.EventHandler(this.btn_Atk_Athen_Click);
            // 
            // btn_Atk_Barcelona
            // 
            this.btn_Atk_Barcelona.Location = new System.Drawing.Point(5, 137);
            this.btn_Atk_Barcelona.Name = "btn_Atk_Barcelona";
            this.btn_Atk_Barcelona.Size = new System.Drawing.Size(90, 23);
            this.btn_Atk_Barcelona.TabIndex = 8;
            this.btn_Atk_Barcelona.Text = "Barcelona";
            this.btn_Atk_Barcelona.UseVisualStyleBackColor = true;
            this.btn_Atk_Barcelona.Click += new System.EventHandler(this.btn_Atk_Barcelona_Click);
            // 
            // btn_Atk_Rom
            // 
            this.btn_Atk_Rom.Location = new System.Drawing.Point(5, 107);
            this.btn_Atk_Rom.Name = "btn_Atk_Rom";
            this.btn_Atk_Rom.Size = new System.Drawing.Size(90, 23);
            this.btn_Atk_Rom.TabIndex = 7;
            this.btn_Atk_Rom.Text = "Rom";
            this.btn_Atk_Rom.UseVisualStyleBackColor = true;
            this.btn_Atk_Rom.Click += new System.EventHandler(this.btn_Atk_Rom_Click);
            // 
            // btn_Atk_Paris
            // 
            this.btn_Atk_Paris.Location = new System.Drawing.Point(3, 77);
            this.btn_Atk_Paris.Name = "btn_Atk_Paris";
            this.btn_Atk_Paris.Size = new System.Drawing.Size(92, 23);
            this.btn_Atk_Paris.TabIndex = 6;
            this.btn_Atk_Paris.Text = "Paris";
            this.btn_Atk_Paris.UseVisualStyleBackColor = true;
            this.btn_Atk_Paris.Click += new System.EventHandler(this.btn_Atk_Paris_Click);
            // 
            // lbl_Atk_Berlin_Perc
            // 
            this.lbl_Atk_Berlin_Perc.AutoSize = true;
            this.lbl_Atk_Berlin_Perc.ForeColor = System.Drawing.Color.Red;
            this.lbl_Atk_Berlin_Perc.Location = new System.Drawing.Point(103, 52);
            this.lbl_Atk_Berlin_Perc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Atk_Berlin_Perc.Name = "lbl_Atk_Berlin_Perc";
            this.lbl_Atk_Berlin_Perc.Size = new System.Drawing.Size(30, 13);
            this.lbl_Atk_Berlin_Perc.TabIndex = 5;
            this.lbl_Atk_Berlin_Perc.Text = "25 %";
            // 
            // lbl_Atk_NY_Perc
            // 
            this.lbl_Atk_NY_Perc.AutoSize = true;
            this.lbl_Atk_NY_Perc.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Atk_NY_Perc.Location = new System.Drawing.Point(103, 32);
            this.lbl_Atk_NY_Perc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Atk_NY_Perc.Name = "lbl_Atk_NY_Perc";
            this.lbl_Atk_NY_Perc.Size = new System.Drawing.Size(30, 13);
            this.lbl_Atk_NY_Perc.TabIndex = 4;
            this.lbl_Atk_NY_Perc.Text = "50 %";
            // 
            // btn_Atk_Berlin
            // 
            this.btn_Atk_Berlin.Location = new System.Drawing.Point(4, 52);
            this.btn_Atk_Berlin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Atk_Berlin.Name = "btn_Atk_Berlin";
            this.btn_Atk_Berlin.Size = new System.Drawing.Size(91, 19);
            this.btn_Atk_Berlin.TabIndex = 3;
            this.btn_Atk_Berlin.Text = "Berlin";
            this.btn_Atk_Berlin.UseVisualStyleBackColor = true;
            this.btn_Atk_Berlin.Click += new System.EventHandler(this.btn_Atk_Berlin_Click);
            // 
            // btn_Atk_NewYork
            // 
            this.btn_Atk_NewYork.Location = new System.Drawing.Point(4, 28);
            this.btn_Atk_NewYork.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Atk_NewYork.Name = "btn_Atk_NewYork";
            this.btn_Atk_NewYork.Size = new System.Drawing.Size(91, 19);
            this.btn_Atk_NewYork.TabIndex = 2;
            this.btn_Atk_NewYork.Text = "New York";
            this.btn_Atk_NewYork.UseVisualStyleBackColor = true;
            this.btn_Atk_NewYork.Click += new System.EventHandler(this.btn_Atk_NewYork_Click);
            // 
            // lbl_Atl_London_Prec
            // 
            this.lbl_Atl_London_Prec.AutoSize = true;
            this.lbl_Atl_London_Prec.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Atl_London_Prec.Location = new System.Drawing.Point(103, 6);
            this.lbl_Atl_London_Prec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Atl_London_Prec.Name = "lbl_Atl_London_Prec";
            this.lbl_Atl_London_Prec.Size = new System.Drawing.Size(36, 13);
            this.lbl_Atl_London_Prec.TabIndex = 1;
            this.lbl_Atl_London_Prec.Text = "100 %";
            // 
            // btn_Atk_London
            // 
            this.btn_Atk_London.Location = new System.Drawing.Point(4, 4);
            this.btn_Atk_London.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Atk_London.Name = "btn_Atk_London";
            this.btn_Atk_London.Size = new System.Drawing.Size(91, 19);
            this.btn_Atk_London.TabIndex = 0;
            this.btn_Atk_London.Text = "London";
            this.btn_Atk_London.UseVisualStyleBackColor = true;
            this.btn_Atk_London.Click += new System.EventHandler(this.btn_Atk_London_Click);
            // 
            // tab_Soldier
            // 
            this.tab_Soldier.Location = new System.Drawing.Point(4, 22);
            this.tab_Soldier.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Soldier.Name = "tab_Soldier";
            this.tab_Soldier.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Soldier.Size = new System.Drawing.Size(173, 256);
            this.tab_Soldier.TabIndex = 1;
            this.tab_Soldier.Text = "Crew";
            this.tab_Soldier.UseVisualStyleBackColor = true;
            // 
            // tab_Ship
            // 
            this.tab_Ship.Location = new System.Drawing.Point(4, 22);
            this.tab_Ship.Name = "tab_Ship";
            this.tab_Ship.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ship.Size = new System.Drawing.Size(173, 256);
            this.tab_Ship.TabIndex = 2;
            this.tab_Ship.Text = "Ship";
            this.tab_Ship.UseVisualStyleBackColor = true;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.btn_Show_Build_Pnl);
            this.pnl_Main.Controls.Add(this.rtb_Current_Mission);
            this.pnl_Main.Controls.Add(this.tabControl1);
            this.pnl_Main.Controls.Add(this.lbl_Current_Mission);
            this.pnl_Main.Controls.Add(this.tc_Main_Stats);
            this.pnl_Main.Location = new System.Drawing.Point(9, 10);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(353, 594);
            this.pnl_Main.TabIndex = 4;
            // 
            // btn_Show_Build_Pnl
            // 
            this.btn_Show_Build_Pnl.Location = new System.Drawing.Point(165, 310);
            this.btn_Show_Build_Pnl.Name = "btn_Show_Build_Pnl";
            this.btn_Show_Build_Pnl.Size = new System.Drawing.Size(177, 35);
            this.btn_Show_Build_Pnl.TabIndex = 4;
            this.btn_Show_Build_Pnl.Text = "Build";
            this.btn_Show_Build_Pnl.UseVisualStyleBackColor = true;
            this.btn_Show_Build_Pnl.Click += new System.EventHandler(this.btn_Show_Build_Pnl_Click);
            // 
            // pnl_Target
            // 
            this.pnl_Target.Controls.Add(this.btn_Cancel_Target);
            this.pnl_Target.Controls.Add(this.btn_Confirm_Target);
            this.pnl_Target.Controls.Add(this.lbl_Target_Info);
            this.pnl_Target.Controls.Add(this.lbl_Crew_Info);
            this.pnl_Target.Controls.Add(this.lbl_Ship_Info);
            this.pnl_Target.Controls.Add(this.rtb_Atk_Target_Info);
            this.pnl_Target.Controls.Add(this.rtb_Atk_Crew_Info);
            this.pnl_Target.Controls.Add(this.rtb_Atk_Ship_Info);
            this.pnl_Target.Location = new System.Drawing.Point(380, 11);
            this.pnl_Target.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Target.Name = "pnl_Target";
            this.pnl_Target.Size = new System.Drawing.Size(456, 593);
            this.pnl_Target.TabIndex = 5;
            // 
            // btn_Cancel_Target
            // 
            this.btn_Cancel_Target.Location = new System.Drawing.Point(171, 523);
            this.btn_Cancel_Target.Name = "btn_Cancel_Target";
            this.btn_Cancel_Target.Size = new System.Drawing.Size(145, 23);
            this.btn_Cancel_Target.TabIndex = 7;
            this.btn_Cancel_Target.Text = "Cancel";
            this.btn_Cancel_Target.UseVisualStyleBackColor = true;
            this.btn_Cancel_Target.Click += new System.EventHandler(this.btn_Cancel_Target_Click);
            // 
            // btn_Confirm_Target
            // 
            this.btn_Confirm_Target.Location = new System.Drawing.Point(4, 523);
            this.btn_Confirm_Target.Name = "btn_Confirm_Target";
            this.btn_Confirm_Target.Size = new System.Drawing.Size(145, 23);
            this.btn_Confirm_Target.TabIndex = 6;
            this.btn_Confirm_Target.Text = "Confirm";
            this.btn_Confirm_Target.UseVisualStyleBackColor = true;
            this.btn_Confirm_Target.Click += new System.EventHandler(this.btn_Confirm_Target_Click);
            // 
            // lbl_Target_Info
            // 
            this.lbl_Target_Info.AutoSize = true;
            this.lbl_Target_Info.Location = new System.Drawing.Point(7, 309);
            this.lbl_Target_Info.Name = "lbl_Target_Info";
            this.lbl_Target_Info.Size = new System.Drawing.Size(38, 13);
            this.lbl_Target_Info.TabIndex = 5;
            this.lbl_Target_Info.Text = "Target";
            // 
            // lbl_Crew_Info
            // 
            this.lbl_Crew_Info.AutoSize = true;
            this.lbl_Crew_Info.Location = new System.Drawing.Point(262, 4);
            this.lbl_Crew_Info.Name = "lbl_Crew_Info";
            this.lbl_Crew_Info.Size = new System.Drawing.Size(31, 13);
            this.lbl_Crew_Info.TabIndex = 4;
            this.lbl_Crew_Info.Text = "Crew";
            // 
            // lbl_Ship_Info
            // 
            this.lbl_Ship_Info.AutoSize = true;
            this.lbl_Ship_Info.Location = new System.Drawing.Point(4, 4);
            this.lbl_Ship_Info.Name = "lbl_Ship_Info";
            this.lbl_Ship_Info.Size = new System.Drawing.Size(33, 13);
            this.lbl_Ship_Info.TabIndex = 3;
            this.lbl_Ship_Info.Text = "Ships";
            // 
            // rtb_Atk_Target_Info
            // 
            this.rtb_Atk_Target_Info.Location = new System.Drawing.Point(4, 327);
            this.rtb_Atk_Target_Info.Name = "rtb_Atk_Target_Info";
            this.rtb_Atk_Target_Info.ReadOnly = true;
            this.rtb_Atk_Target_Info.Size = new System.Drawing.Size(428, 169);
            this.rtb_Atk_Target_Info.TabIndex = 2;
            this.rtb_Atk_Target_Info.Text = "";
            // 
            // rtb_Atk_Crew_Info
            // 
            this.rtb_Atk_Crew_Info.Location = new System.Drawing.Point(262, 19);
            this.rtb_Atk_Crew_Info.Name = "rtb_Atk_Crew_Info";
            this.rtb_Atk_Crew_Info.ReadOnly = true;
            this.rtb_Atk_Crew_Info.Size = new System.Drawing.Size(170, 283);
            this.rtb_Atk_Crew_Info.TabIndex = 1;
            this.rtb_Atk_Crew_Info.Text = "";
            // 
            // rtb_Atk_Ship_Info
            // 
            this.rtb_Atk_Ship_Info.Location = new System.Drawing.Point(4, 19);
            this.rtb_Atk_Ship_Info.Name = "rtb_Atk_Ship_Info";
            this.rtb_Atk_Ship_Info.ReadOnly = true;
            this.rtb_Atk_Ship_Info.Size = new System.Drawing.Size(160, 283);
            this.rtb_Atk_Ship_Info.TabIndex = 0;
            this.rtb_Atk_Ship_Info.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_Build
            // 
            this.pnl_Build.Controls.Add(this.pnl_Show_Buildings);
            this.pnl_Build.Controls.Add(this.btn_Build_Camp);
            this.pnl_Build.Controls.Add(this.button2);
            this.pnl_Build.Controls.Add(this.btn_Build_Infirmary);
            this.pnl_Build.Controls.Add(this.Btn_Build_Brewery);
            this.pnl_Build.Controls.Add(this.btn_Build_Armory);
            this.pnl_Build.Controls.Add(this.button1);
            this.pnl_Build.Controls.Add(this.btn_Build_Field);
            this.pnl_Build.Controls.Add(this.btn_Build_Ship_Yard);
            this.pnl_Build.Location = new System.Drawing.Point(842, 13);
            this.pnl_Build.Name = "pnl_Build";
            this.pnl_Build.Size = new System.Drawing.Size(437, 591);
            this.pnl_Build.TabIndex = 6;
            // 
            // pnl_Show_Buildings
            // 
            this.pnl_Show_Buildings.Controls.Add(this.grid);
            this.pnl_Show_Buildings.Controls.Add(this.lbl_Show_Buildings);
            this.pnl_Show_Buildings.Location = new System.Drawing.Point(4, 177);
            this.pnl_Show_Buildings.Name = "pnl_Show_Buildings";
            this.pnl_Show_Buildings.Size = new System.Drawing.Size(430, 367);
            this.pnl_Show_Buildings.TabIndex = 8;
            // 
            // lbl_Show_Buildings
            // 
            this.lbl_Show_Buildings.AutoSize = true;
            this.lbl_Show_Buildings.Location = new System.Drawing.Point(4, 9);
            this.lbl_Show_Buildings.Name = "lbl_Show_Buildings";
            this.lbl_Show_Buildings.Size = new System.Drawing.Size(35, 13);
            this.lbl_Show_Buildings.TabIndex = 0;
            this.lbl_Show_Buildings.Text = "label1";
            // 
            // btn_Build_Camp
            // 
            this.btn_Build_Camp.Location = new System.Drawing.Point(166, 65);
            this.btn_Build_Camp.Name = "btn_Build_Camp";
            this.btn_Build_Camp.Size = new System.Drawing.Size(75, 55);
            this.btn_Build_Camp.TabIndex = 7;
            this.btn_Build_Camp.Text = "Camp";
            this.btn_Build_Camp.UseVisualStyleBackColor = true;
            this.btn_Build_Camp.Click += new System.EventHandler(this.btn_Build_Camp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "infirmary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Build_Infirmary
            // 
            this.btn_Build_Infirmary.Location = new System.Drawing.Point(4, 65);
            this.btn_Build_Infirmary.Name = "btn_Build_Infirmary";
            this.btn_Build_Infirmary.Size = new System.Drawing.Size(75, 55);
            this.btn_Build_Infirmary.TabIndex = 5;
            this.btn_Build_Infirmary.Text = "infirmary";
            this.btn_Build_Infirmary.UseVisualStyleBackColor = true;
            this.btn_Build_Infirmary.Click += new System.EventHandler(this.btn_Build_Infirmary_Click);
            // 
            // Btn_Build_Brewery
            // 
            this.Btn_Build_Brewery.Location = new System.Drawing.Point(328, 4);
            this.Btn_Build_Brewery.Name = "Btn_Build_Brewery";
            this.Btn_Build_Brewery.Size = new System.Drawing.Size(75, 55);
            this.Btn_Build_Brewery.TabIndex = 4;
            this.Btn_Build_Brewery.Text = "Brewery";
            this.Btn_Build_Brewery.UseVisualStyleBackColor = true;
            this.Btn_Build_Brewery.Click += new System.EventHandler(this.Btn_Build_Brewery_Click);
            // 
            // btn_Build_Armory
            // 
            this.btn_Build_Armory.Location = new System.Drawing.Point(247, 4);
            this.btn_Build_Armory.Name = "btn_Build_Armory";
            this.btn_Build_Armory.Size = new System.Drawing.Size(75, 55);
            this.btn_Build_Armory.TabIndex = 3;
            this.btn_Build_Armory.Text = "Armory";
            this.btn_Build_Armory.UseVisualStyleBackColor = true;
            this.btn_Build_Armory.Click += new System.EventHandler(this.btn_Build_Armory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Field";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Build_Field
            // 
            this.btn_Build_Field.Location = new System.Drawing.Point(85, 4);
            this.btn_Build_Field.Name = "btn_Build_Field";
            this.btn_Build_Field.Size = new System.Drawing.Size(75, 55);
            this.btn_Build_Field.TabIndex = 1;
            this.btn_Build_Field.Text = "Field";
            this.btn_Build_Field.UseVisualStyleBackColor = true;
            this.btn_Build_Field.Click += new System.EventHandler(this.btn_Build_Field_Click);
            // 
            // btn_Build_Ship_Yard
            // 
            this.btn_Build_Ship_Yard.Location = new System.Drawing.Point(4, 4);
            this.btn_Build_Ship_Yard.Name = "btn_Build_Ship_Yard";
            this.btn_Build_Ship_Yard.Size = new System.Drawing.Size(75, 55);
            this.btn_Build_Ship_Yard.TabIndex = 0;
            this.btn_Build_Ship_Yard.Text = "Ship Yard";
            this.btn_Build_Ship_Yard.UseVisualStyleBackColor = true;
            this.btn_Build_Ship_Yard.Click += new System.EventHandler(this.btn_Build_Ship_Yard_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(228, 9);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(199, 355);
            this.grid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 613);
            this.Controls.Add(this.pnl_Build);
            this.Controls.Add(this.pnl_Target);
            this.Controls.Add(this.pnl_Main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tc_Main_Stats.ResumeLayout(false);
            this.tab_Ciry_Stat.ResumeLayout(false);
            this.tab_Ciry_Stat.PerformLayout();
            this.tab_Build.ResumeLayout(false);
            this.tab_Build.PerformLayout();
            this.tab_Camp.ResumeLayout(false);
            this.tab_Camp.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_Cities.ResumeLayout(false);
            this.tab_Cities.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Target.ResumeLayout(false);
            this.pnl_Target.PerformLayout();
            this.pnl_Build.ResumeLayout(false);
            this.pnl_Show_Buildings.ResumeLayout(false);
            this.pnl_Show_Buildings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Current_Mission;
        private System.Windows.Forms.RichTextBox rtb_Current_Mission;
        private System.Windows.Forms.TabControl tc_Main_Stats;
        private System.Windows.Forms.TabPage tab_Ciry_Stat;
        private System.Windows.Forms.TabPage tab_Build;
        private System.Windows.Forms.TabPage tab_Camp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Cities;
        private System.Windows.Forms.TabPage tab_Soldier;
        private System.Windows.Forms.Label lbl_Atl_London_Prec;
        private System.Windows.Forms.Button btn_Atk_London;
        private System.Windows.Forms.Label lbl_Atk_Berlin_Perc;
        private System.Windows.Forms.Label lbl_Atk_NY_Perc;
        private System.Windows.Forms.Button btn_Atk_Berlin;
        private System.Windows.Forms.Button btn_Atk_NewYork;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Target;
        private System.Windows.Forms.Button btn_Cancel_Target;
        private System.Windows.Forms.Button btn_Confirm_Target;
        private System.Windows.Forms.Label lbl_Target_Info;
        private System.Windows.Forms.Label lbl_Crew_Info;
        private System.Windows.Forms.Label lbl_Ship_Info;
        private System.Windows.Forms.RichTextBox rtb_Atk_Target_Info;
        private System.Windows.Forms.RichTextBox rtb_Atk_Crew_Info;
        private System.Windows.Forms.RichTextBox rtb_Atk_Ship_Info;
        private System.Windows.Forms.TabPage tab_Ship;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Atk_Amsterdam;
        private System.Windows.Forms.Button btn_Atk_Venice;
        private System.Windows.Forms.Button btn_Atk_Athen;
        private System.Windows.Forms.Button btn_Atk_Barcelona;
        private System.Windows.Forms.Button btn_Atk_Rom;
        private System.Windows.Forms.Button btn_Atk_Paris;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lbl_City_Stats;
        private System.Windows.Forms.Label lbl_Building_stats;
        private System.Windows.Forms.Label lbl_Camp_Stats;
        private System.Windows.Forms.Panel pnl_Build;
        private System.Windows.Forms.Button btn_Build_Camp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Build_Infirmary;
        private System.Windows.Forms.Button Btn_Build_Brewery;
        private System.Windows.Forms.Button btn_Build_Armory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Build_Field;
        private System.Windows.Forms.Button btn_Build_Ship_Yard;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_Show_Build_Pnl;
        private System.Windows.Forms.Panel pnl_Show_Buildings;
        private System.Windows.Forms.Label lbl_Show_Buildings;
        private System.Windows.Forms.DataGridView grid;
    }
}

