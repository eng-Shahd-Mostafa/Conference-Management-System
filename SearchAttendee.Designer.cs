namespace Conference_Management_System
{
    partial class SearchAttendee
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
            tbAttendeeName = new TextBox();
            btnSearch = new Button();
            btnCancel = new Button();
            tbAteendeeId = new TextBox();
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
            label1.Text = "Search Attendee";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 144);
            label2.Name = "label2";
            label2.Size = new Size(144, 34);
            label2.TabIndex = 1;
            label2.Text = "ATTENDEE ID";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(61, 265);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 2;
            label3.Text = "ATTENDEE NAME";
            // 
            // tbAttendeeName
            // 
            tbAttendeeName.Location = new Point(317, 263);
            tbAttendeeName.Name = "tbAttendeeName";
            tbAttendeeName.Size = new Size(413, 27);
            tbAttendeeName.TabIndex = 5;
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
            // tbAteendeeId
            // 
            tbAteendeeId.Location = new Point(317, 151);
            tbAteendeeId.Name = "tbAteendeeId";
            tbAteendeeId.Size = new Size(413, 27);
            tbAteendeeId.TabIndex = 9;
            // 
            // SearchAttendee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 498);
            Controls.Add(tbAteendeeId);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(tbAttendeeName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(1034, 545);
            MinimumSize = new Size(1034, 545);
            Name = "SearchAttendee";
            Text = "SearchِAttendee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbYear;
        private TextBox tbAttendeeName;
        private TextBox tbLocation;
        private Button btnSearch;
        private Button btnCancel;
        private TextBox tbAteendeeId;
    }
}