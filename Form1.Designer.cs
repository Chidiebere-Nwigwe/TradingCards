namespace Assignment3_TradingCards
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
            this.MainList = new System.Windows.Forms.ListView();
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Goals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Assists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassAccuracy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_GetData = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelAssists = new System.Windows.Forms.Label();
            this.labelPassAccuracy = new System.Windows.Forms.Label();
            this.labelGoalsScored = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_placeholder = new System.Windows.Forms.Label();
            this.btn_Recover = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainList
            // 
            this.MainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayerName,
            this.Team,
            this.Goals,
            this.Height,
            this.Assists,
            this.PassAccuracy,
            this.Rating});
            this.MainList.GridLines = true;
            this.MainList.HideSelection = false;
            this.MainList.Location = new System.Drawing.Point(16, 15);
            this.MainList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(957, 336);
            this.MainList.TabIndex = 0;
            this.MainList.UseCompatibleStateImageBehavior = false;
            this.MainList.View = System.Windows.Forms.View.Details;
            this.MainList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MainList_Selected);
            // 
            // PlayerName
            // 
            this.PlayerName.Text = "Name";
            this.PlayerName.Width = 193;
            // 
            // Team
            // 
            this.Team.Text = "Team";
            this.Team.Width = 190;
            // 
            // Goals
            // 
            this.Goals.Text = "Goals ";
            this.Goals.Width = 105;
            // 
            // Height
            // 
            this.Height.Text = "Height";
            this.Height.Width = 101;
            // 
            // Assists
            // 
            this.Assists.Text = "Assists";
            this.Assists.Width = 109;
            // 
            // PassAccuracy
            // 
            this.PassAccuracy.Text = "Pass Accuracy";
            this.PassAccuracy.Width = 146;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            this.Rating.Width = 81;
            // 
            // btn_GetData
            // 
            this.btn_GetData.Location = new System.Drawing.Point(32, 360);
            this.btn_GetData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GetData.Name = "btn_GetData";
            this.btn_GetData.Size = new System.Drawing.Size(175, 50);
            this.btn_GetData.TabIndex = 1;
            this.btn_GetData.Text = "Get Data";
            this.btn_GetData.UseVisualStyleBackColor = true;
            this.btn_GetData.Click += new System.EventHandler(this.btn_GetData_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(983, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(326, 338);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelName.Location = new System.Drawing.Point(983, 15);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 23);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam.Location = new System.Drawing.Point(983, 340);
            this.labelTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(62, 23);
            this.labelTeam.TabIndex = 4;
            this.labelTeam.Text = "Team";
            this.labelTeam.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelRating.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRating.Location = new System.Drawing.Point(997, 185);
            this.labelRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(62, 23);
            this.labelRating.TabIndex = 5;
            this.labelRating.Text = "Rate";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelHeight.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelHeight.Location = new System.Drawing.Point(997, 292);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(88, 23);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height";
            // 
            // labelAssists
            // 
            this.labelAssists.AutoSize = true;
            this.labelAssists.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelAssists.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssists.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelAssists.Location = new System.Drawing.Point(997, 124);
            this.labelAssists.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAssists.Name = "labelAssists";
            this.labelAssists.Size = new System.Drawing.Size(101, 23);
            this.labelAssists.TabIndex = 7;
            this.labelAssists.Text = "Assists";
            // 
            // labelPassAccuracy
            // 
            this.labelPassAccuracy.AutoSize = true;
            this.labelPassAccuracy.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelPassAccuracy.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassAccuracy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelPassAccuracy.Location = new System.Drawing.Point(997, 240);
            this.labelPassAccuracy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassAccuracy.Name = "labelPassAccuracy";
            this.labelPassAccuracy.Size = new System.Drawing.Size(179, 23);
            this.labelPassAccuracy.TabIndex = 8;
            this.labelPassAccuracy.Text = "Pass Accuracy";
            // 
            // labelGoalsScored
            // 
            this.labelGoalsScored.AutoSize = true;
            this.labelGoalsScored.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelGoalsScored.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalsScored.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelGoalsScored.Location = new System.Drawing.Point(997, 65);
            this.labelGoalsScored.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoalsScored.Name = "labelGoalsScored";
            this.labelGoalsScored.Size = new System.Drawing.Size(75, 23);
            this.labelGoalsScored.TabIndex = 9;
            this.labelGoalsScored.Text = "Goals";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1134, 372);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(175, 50);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete Card";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_placeholder
            // 
            this.lbl_placeholder.AutoSize = true;
            this.lbl_placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeholder.Location = new System.Drawing.Point(28, 460);
            this.lbl_placeholder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placeholder.Name = "lbl_placeholder";
            this.lbl_placeholder.Size = new System.Drawing.Size(113, 25);
            this.lbl_placeholder.TabIndex = 11;
            this.lbl_placeholder.Text = "placeholder";
            // 
            // btn_Recover
            // 
            this.btn_Recover.Location = new System.Drawing.Point(292, 511);
            this.btn_Recover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Recover.Name = "btn_Recover";
            this.btn_Recover.Size = new System.Drawing.Size(260, 39);
            this.btn_Recover.TabIndex = 12;
            this.btn_Recover.Text = "Restore Deleted Player";
            this.btn_Recover.UseVisualStyleBackColor = true;
            this.btn_Recover.Click += new System.EventHandler(this.btn_Recover_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 511);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Click on Get Data to Populate List View ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 426);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Click on Picture to toggle and see other stats of Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Click on Name of Player to see Player\'s Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(603, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "To Recover Deleted Player, Choose From dropdown and Click Recover";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1350, 629);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Recover);
            this.Controls.Add(this.lbl_placeholder);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.labelGoalsScored);
            this.Controls.Add(this.labelPassAccuracy);
            this.Controls.Add(this.labelAssists);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btn_GetData);
            this.Controls.Add(this.MainList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MainList;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.ColumnHeader Goals;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Assists;
        private System.Windows.Forms.ColumnHeader PassAccuracy;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.Button btn_GetData;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelAssists;
        private System.Windows.Forms.Label labelPassAccuracy;
        private System.Windows.Forms.Label labelGoalsScored;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_placeholder;
        private System.Windows.Forms.Button btn_Recover;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

