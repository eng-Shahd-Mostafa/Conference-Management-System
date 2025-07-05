namespace Conference_Management_System
{
    partial class SearchSession
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
            label5 = new Label();
            tbConferenceLocation = new TextBox();
            tbConferenceCity = new TextBox();
            tbConferenceYear = new TextBox();
            tbSessionId = new TextBox();
            btnSearch = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(992, 37);
            label1.TabIndex = 0;
            label1.Text = "Search Session";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(146, 131);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 1;
            label2.Text = "SESSION ID";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(137, 199);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 2;
            label3.Text = "CONFERENCE YEAR";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(137, 281);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 3;
            label4.Text = "CONFERENCE CITY";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(137, 353);
            label5.Name = "label5";
            label5.Size = new Size(217, 25);
            label5.TabIndex = 4;
            label5.Text = "CONFERENCE LOCATION";
            // 
            // tbConferenceLocation
            // 
            tbConferenceLocation.Location = new Point(363, 351);
            tbConferenceLocation.Name = "tbConferenceLocation";
            tbConferenceLocation.Size = new Size(413, 27);
            tbConferenceLocation.TabIndex = 5;
            // 
            // tbConferenceCity
            // 
            tbConferenceCity.Location = new Point(363, 279);
            tbConferenceCity.Name = "tbConferenceCity";
            tbConferenceCity.Size = new Size(413, 27);
            tbConferenceCity.TabIndex = 6;
            // 
            // tbConferenceYear
            // 
            tbConferenceYear.Location = new Point(363, 199);
            tbConferenceYear.Name = "tbConferenceYear";
            tbConferenceYear.Size = new Size(413, 27);
            tbConferenceYear.TabIndex = 7;
            // 
            // tbSessionId
            // 
            tbSessionId.Location = new Point(363, 129);
            tbSessionId.Name = "tbSessionId";
            tbSessionId.Size = new Size(413, 27);
            tbSessionId.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(211, 435);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 39);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(682, 435);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 39);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SearchSession
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 498);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(tbSessionId);
            Controls.Add(tbConferenceYear);
            Controls.Add(tbConferenceCity);
            Controls.Add(tbConferenceLocation);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(1034, 545);
            MinimumSize = new Size(1034, 545);
            Name = "SearchSession";
            Text = "SearchSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbConferenceLocation;
        private TextBox tbConferenceCity;
        private TextBox tbConferenceYear;
        private TextBox tbSessionId;
        private Button btnSearch;
        private Button btnCancel;
    }
}