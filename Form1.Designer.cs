namespace Conference_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnConference = new Button();
            btnSession = new Button();
            btnAttendee = new Button();
            btnParticipant = new Button();
            btnPaper = new Button();
            btnReport = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(154, 28);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(696, 33);
            label1.TabIndex = 0;
            label1.Text = "Conference Management System Dashboard";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConference
            // 
            btnConference.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConference.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConference.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConference.ForeColor = SystemColors.HotTrack;
            btnConference.Location = new Point(19, 115);
            btnConference.Margin = new Padding(0, 20, 50, 20);
            btnConference.MaximumSize = new Size(500, 70);
            btnConference.Name = "btnConference";
            btnConference.Size = new Size(350, 70);
            btnConference.TabIndex = 1;
            btnConference.Text = "CONFERENCE";
            btnConference.UseVisualStyleBackColor = true;
            btnConference.Click += btnConference_Click;
            // 
            // btnSession
            // 
            btnSession.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSession.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSession.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSession.ForeColor = SystemColors.HotTrack;
            btnSession.Location = new Point(627, 115);
            btnSession.Margin = new Padding(0, 20, 50, 20);
            btnSession.MaximumSize = new Size(500, 70);
            btnSession.Name = "btnSession";
            btnSession.Size = new Size(350, 70);
            btnSession.TabIndex = 2;
            btnSession.Text = "SESSION";
            btnSession.UseVisualStyleBackColor = true;
            btnSession.Click += btnSession_Click;
            // 
            // btnAttendee
            // 
            btnAttendee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAttendee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAttendee.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendee.ForeColor = SystemColors.HotTrack;
            btnAttendee.Location = new Point(19, 409);
            btnAttendee.Margin = new Padding(0, 20, 50, 20);
            btnAttendee.MaximumSize = new Size(500, 70);
            btnAttendee.Name = "btnAttendee";
            btnAttendee.Size = new Size(350, 70);
            btnAttendee.TabIndex = 3;
            btnAttendee.Text = "ATTENDEE REPORT";
            btnAttendee.UseVisualStyleBackColor = true;
            btnAttendee.Click += btnAttendee_Click;
            // 
            // btnParticipant
            // 
            btnParticipant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnParticipant.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnParticipant.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnParticipant.ForeColor = SystemColors.HotTrack;
            btnParticipant.Location = new Point(19, 264);
            btnParticipant.Margin = new Padding(0, 20, 50, 20);
            btnParticipant.MaximumSize = new Size(500, 70);
            btnParticipant.Name = "btnParticipant";
            btnParticipant.Size = new Size(350, 70);
            btnParticipant.TabIndex = 4;
            btnParticipant.Text = "PARTICIPANT";
            btnParticipant.UseVisualStyleBackColor = true;
            btnParticipant.Click += btnParticipant_Click;
            // 
            // btnPaper
            // 
            btnPaper.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPaper.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaper.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaper.ForeColor = SystemColors.HotTrack;
            btnPaper.Location = new Point(627, 264);
            btnPaper.Margin = new Padding(0, 20, 50, 20);
            btnPaper.MaximumSize = new Size(500, 70);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(350, 70);
            btnPaper.TabIndex = 7;
            btnPaper.Text = "PAPER";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReport.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.ForeColor = SystemColors.HotTrack;
            btnReport.Location = new Point(627, 409);
            btnReport.Margin = new Padding(0, 20, 50, 20);
            btnReport.MaximumSize = new Size(500, 70);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(350, 70);
            btnReport.TabIndex = 8;
            btnReport.Text = "CONFERENCE REPORT";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(991, 515);
            Controls.Add(btnReport);
            Controls.Add(btnPaper);
            Controls.Add(btnParticipant);
            Controls.Add(btnAttendee);
            Controls.Add(btnSession);
            Controls.Add(btnConference);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(1009, 562);
            MinimumSize = new Size(1009, 562);
            Name = "Form1";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnConference;
        private Button btnSession;
        private Button btnAttendee;
        private Button btnParticipant;
        private Button btnPaper;
        private Button btnReport;
    }
}
