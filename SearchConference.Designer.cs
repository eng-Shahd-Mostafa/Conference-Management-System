namespace Conference_Management_System
{
    partial class SearchConference
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbYear = new TextBox();
            tbCity = new TextBox();
            tbLocation = new TextBox();
            btnSearch = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(992, 37);
            label1.TabIndex = 0;
            label1.Text = "Search Conference";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 136);
            label2.Name = "label2";
            label2.Size = new Size(62, 34);
            label2.TabIndex = 1;
            label2.Text = "YEAR";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(61, 202);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "CITY";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(61, 272);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "LOCATION";
            // 
            // tbYear
            // 
            tbYear.Location = new Point(317, 136);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(413, 27);
            tbYear.TabIndex = 4;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(317, 200);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(413, 27);
            tbCity.TabIndex = 5;
            // 
            // tbLocation
            // 
            tbLocation.Location = new Point(317, 270);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(413, 27);
            tbLocation.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(225, 401);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 39);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(629, 401);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 39);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SearchConference
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 498);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(tbLocation);
            Controls.Add(tbCity);
            Controls.Add(tbYear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(1034, 545);
            MinimumSize = new Size(1034, 545);
            Name = "SearchConference";
            Text = "SearchConference";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbYear;
        private TextBox tbCity;
        private TextBox tbLocation;
        private Button btnSearch;
        private Button btnCancel;
    }
}