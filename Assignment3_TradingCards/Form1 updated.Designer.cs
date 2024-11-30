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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Restore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.MainList.Location = new System.Drawing.Point(12, 12);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(697, 270);
            this.MainList.TabIndex = 0;
            this.MainList.UseCompatibleStateImageBehavior = false;
            this.MainList.View = System.Windows.Forms.View.Details;
            this.MainList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MainList_Selected);
            // 
            // PlayerName
            // 
            this.PlayerName.Text = "Name";
            this.PlayerName.Width = 113;
            // 
            // Team
            // 
            this.Team.Text = "Team";
            // 
            // Goals
            // 
            this.Goals.Text = "Goals ";
            this.Goals.Width = 55;
            // 
            // Height
            // 
            this.Height.Text = "Height";
            // 
            // Assists
            // 
            this.Assists.Text = "Assists";
            // 
            // PassAccuracy
            // 
            this.PassAccuracy.Text = "Pass Accuracy";
            this.PassAccuracy.Width = 107;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            // 
            // btn_GetData
            // 
            this.btn_GetData.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_GetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GetData.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_GetData.Location = new System.Drawing.Point(23, 288);
            this.btn_GetData.Name = "btn_GetData";
            this.btn_GetData.Size = new System.Drawing.Size(127, 40);
            this.btn_GetData.TabIndex = 1;
            this.btn_GetData.Text = "Get Data";
            this.btn_GetData.UseVisualStyleBackColor = false;
            this.btn_GetData.Click += new System.EventHandler(this.btn_GetData_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(733, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(237, 270);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(749, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTeam.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTeam.Location = new System.Drawing.Point(749, 341);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(53, 20);
            this.labelTeam.TabIndex = 4;
            this.labelTeam.Text = "Team";
            this.labelTeam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelRating.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRating.Location = new System.Drawing.Point(743, 194);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(48, 17);
            this.labelRating.TabIndex = 5;
            this.labelRating.Text = "Rate";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelHeight.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHeight.Location = new System.Drawing.Point(743, 280);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(68, 17);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height";
            // 
            // labelAssists
            // 
            this.labelAssists.AutoSize = true;
            this.labelAssists.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelAssists.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssists.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelAssists.Location = new System.Drawing.Point(743, 145);
            this.labelAssists.Name = "labelAssists";
            this.labelAssists.Size = new System.Drawing.Size(78, 17);
            this.labelAssists.TabIndex = 7;
            this.labelAssists.Text = "Assists";
            // 
            // labelPassAccuracy
            // 
            this.labelPassAccuracy.AutoSize = true;
            this.labelPassAccuracy.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelPassAccuracy.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassAccuracy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPassAccuracy.Location = new System.Drawing.Point(743, 238);
            this.labelPassAccuracy.Name = "labelPassAccuracy";
            this.labelPassAccuracy.Size = new System.Drawing.Size(138, 17);
            this.labelPassAccuracy.TabIndex = 8;
            this.labelPassAccuracy.Text = "Pass Accuracy";
            // 
            // labelGoalsScored
            // 
            this.labelGoalsScored.AutoSize = true;
            this.labelGoalsScored.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelGoalsScored.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalsScored.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelGoalsScored.Location = new System.Drawing.Point(743, 98);
            this.labelGoalsScored.Name = "labelGoalsScored";
            this.labelGoalsScored.Size = new System.Drawing.Size(58, 17);
            this.labelGoalsScored.TabIndex = 9;
            this.labelGoalsScored.Text = "Goals";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Delete.Location = new System.Drawing.Point(571, 289);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(127, 40);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(715, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 368);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Restore
            // 
            this.btn_Restore.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Restore.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Restore.Location = new System.Drawing.Point(571, 341);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(127, 40);
            this.btn_Restore.TabIndex = 12;
            this.btn_Restore.Text = "Restore";
            this.btn_Restore.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1018, 503);
            this.Controls.Add(this.btn_Restore);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Restore;
    }
}

