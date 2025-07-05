namespace Conference_Management_System
{
    partial class CreateConference
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
            tbLocation = new TextBox();
            tbChairmanName = new TextBox();
            tbChairmanId = new TextBox();
            tbYear = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
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
            label1.Text = "Add Conference";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 100);
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
            btnYear.Size = new Size(62, 25);
            btnYear.TabIndex = 2;
            btnYear.Text = "YEAR";
            // 
            // btnCity
            // 
            btnCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCity.Location = new Point(65, 210);
            btnCity.Name = "btnCity";
            btnCity.Size = new Size(62, 25);
            btnCity.TabIndex = 3;
            btnCity.Text = "CITY";
            // 
            // btnLocation
            // 
            btnLocation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLocation.Location = new Point(65, 262);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(97, 25);
            btnLocation.TabIndex = 4;
            btnLocation.Text = "LOCATION";
            // 
            // BtnChairmanName
            // 
            BtnChairmanName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BtnChairmanName.Location = new Point(65, 321);
            BtnChairmanName.Name = "BtnChairmanName";
            BtnChairmanName.Size = new Size(158, 25);
            BtnChairmanName.TabIndex = 5;
            BtnChairmanName.Text = "CHAIRMAN NAME";
            // 
            // btnChairmanId
            // 
            btnChairmanId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnChairmanId.Location = new Point(65, 380);
            btnChairmanId.Name = "btnChairmanId";
            btnChairmanId.Size = new Size(146, 25);
            btnChairmanId.TabIndex = 6;
            btnChairmanId.Text = "CHAIRMAN ID";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(306, 208);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(413, 27);
            tbCity.TabIndex = 7;
            // 
            // tbLocation
            // 
            tbLocation.Location = new Point(306, 260);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(413, 27);
            tbLocation.TabIndex = 8;
            // 
            // tbChairmanName
            // 
            tbChairmanName.Location = new Point(306, 321);
            tbChairmanName.Name = "tbChairmanName";
            tbChairmanName.Size = new Size(413, 27);
            tbChairmanName.TabIndex = 9;
            // 
            // tbChairmanId
            // 
            tbChairmanId.Location = new Point(306, 378);
            tbChairmanId.Name = "tbChairmanId";
            tbChairmanId.Size = new Size(413, 27);
            tbChairmanId.TabIndex = 10;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(306, 157);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(413, 27);
            tbYear.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(234, 447);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 39);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            // CreateConference
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 498);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbYear);
            Controls.Add(tbChairmanId);
            Controls.Add(tbChairmanName);
            Controls.Add(tbLocation);
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
            Name = "CreateConference";
            Text = "Create Conference";
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
        private TextBox tbLocation;
        private TextBox tbChairmanName;
        private TextBox tbChairmanId;
        private TextBox tbYear;
        private Button btnSave;
        private Button btnCancel;
    }
}