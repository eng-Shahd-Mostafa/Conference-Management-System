namespace Conference_Management_System
{
    partial class UpdateConference
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
            btnYear = new Label();
            btnCity = new Label();
            btnLocation = new Label();
            BtnChairmanName = new Label();
            btnChairmanId = new Label();
            tbCity = new TextBox();
            tbNewCity = new TextBox();
            tbNewLocation = new TextBox();
            tbChairmanName = new TextBox();
            tbYear = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbLocation = new TextBox();
            tbChairmanId = new TextBox();
            tbNewYear = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(1001, 34);
            label1.TabIndex = 0;
            label1.Text = "Update Conference";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(1001, 34);
            label2.TabIndex = 1;
            label2.Text = "CHAIRMAN NAME AND CHAIRMAN ID Must Exist in CHAIRMAN TABLE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYear
            // 
            btnYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYear.Location = new Point(65, 157);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(158, 25);
            btnYear.TabIndex = 2;
            btnYear.Text = "Original YEAR";
            // 
            // btnCity
            // 
            btnCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCity.Location = new Point(65, 217);
            btnCity.Name = "btnCity";
            btnCity.Size = new Size(117, 25);
            btnCity.TabIndex = 3;
            btnCity.Text = "Original CITY";
            // 
            // btnLocation
            // 
            btnLocation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLocation.Location = new Point(38, 277);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(173, 25);
            btnLocation.TabIndex = 4;
            btnLocation.Text = "Original LOCATION";
            // 
            // BtnChairmanName
            // 
            BtnChairmanName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnChairmanName.Location = new Point(38, 345);
            BtnChairmanName.Name = "BtnChairmanName";
            BtnChairmanName.Size = new Size(158, 25);
            BtnChairmanName.TabIndex = 5;
            BtnChairmanName.Text = "CHAIRMAN NAME";
            // 
            // btnChairmanId
            // 
            btnChairmanId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnChairmanId.Location = new Point(65, 400);
            btnChairmanId.Name = "btnChairmanId";
            btnChairmanId.Size = new Size(146, 25);
            btnChairmanId.TabIndex = 6;
            btnChairmanId.Text = "CHAIRMAN ID";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(234, 217);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(267, 27);
            tbCity.TabIndex = 7;
            // 
            // tbNewCity
            // 
            tbNewCity.Location = new Point(702, 222);
            tbNewCity.Name = "tbNewCity";
            tbNewCity.Size = new Size(267, 27);
            tbNewCity.TabIndex = 8;
            // 
            // tbNewLocation
            // 
            tbNewLocation.Location = new Point(702, 276);
            tbNewLocation.Name = "tbNewLocation";
            tbNewLocation.Size = new Size(267, 27);
            tbNewLocation.TabIndex = 9;
            // 
            // tbChairmanName
            // 
            tbChairmanName.Location = new Point(234, 343);
            tbChairmanName.Name = "tbChairmanName";
            tbChairmanName.Size = new Size(413, 27);
            tbChairmanName.TabIndex = 10;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(234, 155);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(267, 27);
            tbYear.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(234, 447);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 39);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(691, 447);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 39);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(566, 155);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 14;
            label3.Text = "NEW YEAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 257);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 15;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(566, 218);
            label5.Name = "label5";
            label5.Size = new Size(116, 31);
            label5.TabIndex = 16;
            label5.Text = "NEW CITY";
            // 
            // tbLocation
            // 
            tbLocation.Location = new Point(234, 277);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(267, 27);
            tbLocation.TabIndex = 17;
            // 
            // tbChairmanId
            // 
            tbChairmanId.Location = new Point(234, 399);
            tbChairmanId.Name = "tbChairmanId";
            tbChairmanId.Size = new Size(413, 27);
            tbChairmanId.TabIndex = 18;
            // 
            // tbNewYear
            // 
            tbNewYear.Location = new Point(702, 153);
            tbNewYear.Name = "tbNewYear";
            tbNewYear.Size = new Size(267, 27);
            tbNewYear.TabIndex = 19;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(533, 279);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 20;
            label6.Text = "NEW LOCATION";
            // 
            // UpdateConference
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 498);
            Controls.Add(label6);
            Controls.Add(tbNewYear);
            Controls.Add(tbChairmanId);
            Controls.Add(tbLocation);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(tbYear);
            Controls.Add(tbChairmanName);
            Controls.Add(tbNewLocation);
            Controls.Add(tbNewCity);
            Controls.Add(tbCity);
            Controls.Add(btnChairmanId);
            Controls.Add(BtnChairmanName);
            Controls.Add(btnLocation);
            Controls.Add(btnCity);
            Controls.Add(btnYear);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(1034, 545);
            MinimumSize = new Size(1034, 545);
            Name = "UpdateConference";
            Text = "Update Conference";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label btnYear;
        private Label btnCity;
        private Label btnLocation;
        private Label BtnChairmanName;
        private Label btnChairmanId;
        private TextBox tbCity;
        private TextBox tbNewCity;
        private TextBox tbNewLocation;
        private TextBox tbChairmanName;
        private TextBox tbYear;
        private Button btnUpdate;
        private Button btnCancel;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbLocation;
        private TextBox tbChairmanId;
        private TextBox tbNewYear;
        private Label label6;
    }
}