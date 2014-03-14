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
            this.tab_Build = new System.Windows.Forms.TabPage();
            this.tab_Camp = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Cities = new System.Windows.Forms.TabPage();
            this.lbl_Atk_Berlin_Perc = new System.Windows.Forms.Label();
            this.lbl_Atk_NY_Perc = new System.Windows.Forms.Label();
            this.btn_Atk_Berlin = new System.Windows.Forms.Button();
            this.btn_Atk_NewYork = new System.Windows.Forms.Button();
            this.lbl_Atl_London_Prec = new System.Windows.Forms.Label();
            this.btn_Atk_London = new System.Windows.Forms.Button();
            this.tab_Soldier = new System.Windows.Forms.TabPage();
            this.tab_Ship = new System.Windows.Forms.TabPage();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancel_Target = new System.Windows.Forms.Button();
            this.btn_Confirm_Target = new System.Windows.Forms.Button();
            this.lbl_Target_Info = new System.Windows.Forms.Label();
            this.lbl_Crew_Info = new System.Windows.Forms.Label();
            this.lbl_Ship_Info = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tc_Main_Stats.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Cities.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tab_Ciry_Stat.Location = new System.Drawing.Point(4, 22);
            this.tab_Ciry_Stat.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Ciry_Stat.Name = "tab_Ciry_Stat";
            this.tab_Ciry_Stat.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Ciry_Stat.Size = new System.Drawing.Size(336, 225);
            this.tab_Ciry_Stat.TabIndex = 0;
            this.tab_Ciry_Stat.Text = "City";
            this.tab_Ciry_Stat.UseVisualStyleBackColor = true;
            // 
            // tab_Build
            // 
            this.tab_Build.Location = new System.Drawing.Point(4, 22);
            this.tab_Build.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Build.Name = "tab_Build";
            this.tab_Build.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Build.Size = new System.Drawing.Size(336, 225);
            this.tab_Build.TabIndex = 1;
            this.tab_Build.Text = "Build";
            this.tab_Build.UseVisualStyleBackColor = true;
            // 
            // tab_Camp
            // 
            this.tab_Camp.Location = new System.Drawing.Point(4, 22);
            this.tab_Camp.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Camp.Name = "tab_Camp";
            this.tab_Camp.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Camp.Size = new System.Drawing.Size(336, 225);
            this.tab_Camp.TabIndex = 2;
            this.tab_Camp.Text = "Camp";
            this.tab_Camp.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Cities);
            this.tabControl1.Controls.Add(this.tab_Soldier);
            this.tabControl1.Controls.Add(this.tab_Ship);
            this.tabControl1.Location = new System.Drawing.Point(184, 21);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(162, 278);
            this.tabControl1.TabIndex = 3;
            // 
            // tab_Cities
            // 
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
            this.tab_Cities.Size = new System.Drawing.Size(154, 252);
            this.tab_Cities.TabIndex = 0;
            this.tab_Cities.Text = "Cities";
            this.tab_Cities.UseVisualStyleBackColor = true;
            // 
            // lbl_Atk_Berlin_Perc
            // 
            this.lbl_Atk_Berlin_Perc.AutoSize = true;
            this.lbl_Atk_Berlin_Perc.ForeColor = System.Drawing.Color.Red;
            this.lbl_Atk_Berlin_Perc.Location = new System.Drawing.Point(104, 54);
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
            this.lbl_Atk_NY_Perc.Location = new System.Drawing.Point(104, 34);
            this.lbl_Atk_NY_Perc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Atk_NY_Perc.Name = "lbl_Atk_NY_Perc";
            this.lbl_Atk_NY_Perc.Size = new System.Drawing.Size(30, 13);
            this.lbl_Atk_NY_Perc.TabIndex = 4;
            this.lbl_Atk_NY_Perc.Text = "50 %";
            // 
            // btn_Atk_Berlin
            // 
            this.btn_Atk_Berlin.Location = new System.Drawing.Point(5, 54);
            this.btn_Atk_Berlin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Atk_Berlin.Name = "btn_Atk_Berlin";
            this.btn_Atk_Berlin.Size = new System.Drawing.Size(91, 19);
            this.btn_Atk_Berlin.TabIndex = 3;
            this.btn_Atk_Berlin.Text = "Berlin";
            this.btn_Atk_Berlin.UseVisualStyleBackColor = true;
            // 
            // btn_Atk_NewYork
            // 
            this.btn_Atk_NewYork.Location = new System.Drawing.Point(5, 30);
            this.btn_Atk_NewYork.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Atk_NewYork.Name = "btn_Atk_NewYork";
            this.btn_Atk_NewYork.Size = new System.Drawing.Size(91, 19);
            this.btn_Atk_NewYork.TabIndex = 2;
            this.btn_Atk_NewYork.Text = "New York";
            this.btn_Atk_NewYork.UseVisualStyleBackColor = true;
            // 
            // lbl_Atl_London_Prec
            // 
            this.lbl_Atl_London_Prec.AutoSize = true;
            this.lbl_Atl_London_Prec.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Atl_London_Prec.Location = new System.Drawing.Point(104, 8);
            this.lbl_Atl_London_Prec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Atl_London_Prec.Name = "lbl_Atl_London_Prec";
            this.lbl_Atl_London_Prec.Size = new System.Drawing.Size(36, 13);
            this.lbl_Atl_London_Prec.TabIndex = 1;
            this.lbl_Atl_London_Prec.Text = "100 %";
            // 
            // btn_Atk_London
            // 
            this.btn_Atk_London.Location = new System.Drawing.Point(5, 6);
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
            this.tab_Soldier.Size = new System.Drawing.Size(154, 252);
            this.tab_Soldier.TabIndex = 1;
            this.tab_Soldier.Text = "Crew";
            this.tab_Soldier.UseVisualStyleBackColor = true;
            // 
            // tab_Ship
            // 
            this.tab_Ship.Location = new System.Drawing.Point(4, 22);
            this.tab_Ship.Name = "tab_Ship";
            this.tab_Ship.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ship.Size = new System.Drawing.Size(154, 252);
            this.tab_Ship.TabIndex = 2;
            this.tab_Ship.Text = "Ship";
            this.tab_Ship.UseVisualStyleBackColor = true;
            // 
            // pnl_Main
            // 
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancel_Target);
            this.panel1.Controls.Add(this.btn_Confirm_Target);
            this.panel1.Controls.Add(this.lbl_Target_Info);
            this.panel1.Controls.Add(this.lbl_Crew_Info);
            this.panel1.Controls.Add(this.lbl_Ship_Info);
            this.panel1.Controls.Add(this.richTextBox3);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(380, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 593);
            this.panel1.TabIndex = 5;
            // 
            // btn_Cancel_Target
            // 
            this.btn_Cancel_Target.Location = new System.Drawing.Point(171, 523);
            this.btn_Cancel_Target.Name = "btn_Cancel_Target";
            this.btn_Cancel_Target.Size = new System.Drawing.Size(145, 23);
            this.btn_Cancel_Target.TabIndex = 7;
            this.btn_Cancel_Target.Text = "Cancel";
            this.btn_Cancel_Target.UseVisualStyleBackColor = true;
            // 
            // btn_Confirm_Target
            // 
            this.btn_Confirm_Target.Location = new System.Drawing.Point(4, 523);
            this.btn_Confirm_Target.Name = "btn_Confirm_Target";
            this.btn_Confirm_Target.Size = new System.Drawing.Size(145, 23);
            this.btn_Confirm_Target.TabIndex = 6;
            this.btn_Confirm_Target.Text = "Confirm";
            this.btn_Confirm_Target.UseVisualStyleBackColor = true;
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
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(4, 327);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(428, 169);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(262, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(170, 283);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(160, 283);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tc_Main_Stats.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_Cities.ResumeLayout(false);
            this.tab_Cities.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancel_Target;
        private System.Windows.Forms.Button btn_Confirm_Target;
        private System.Windows.Forms.Label lbl_Target_Info;
        private System.Windows.Forms.Label lbl_Crew_Info;
        private System.Windows.Forms.Label lbl_Ship_Info;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tab_Ship;
        private System.Windows.Forms.Timer timer1;
    }
}

