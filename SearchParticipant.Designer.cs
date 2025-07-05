namespace Conference_Management_System
{
    partial class SearchParticipant
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
            tbName = new TextBox();
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
            label1.Text = "Search Participant";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 214);
            label2.Name = "label2";
            label2.Size = new Size(112, 34);
            label2.TabIndex = 1;
            label2.Text = "NAME";
            // 
            // tbName
            // 
            tbName.Location = new Point(358, 214);
            tbName.Name = "tbName";
            tbName.Size = new Size(439, 27);
            tbName.TabIndex = 4;
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
            // SearchParticipant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 498);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(1034, 545);
            MinimumSize = new Size(1034, 545);
            Name = "SearchParticipant";
            Text = "SearchParticipant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private Button btnSearch;
        private Button btnCancel;
    }
}