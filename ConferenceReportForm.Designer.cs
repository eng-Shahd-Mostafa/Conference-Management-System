namespace Conference_Management_System
{
    partial class ConferenceReportForm
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
            btnSearchConference = new Button();
            ConferenceTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ConferenceTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(966, 37);
            label1.TabIndex = 0;
            label1.Text = "List of Conferences";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSearchConference
            // 
            btnSearchConference.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchConference.Font = new Font("Britannic Bold", 9F);
            btnSearchConference.ForeColor = SystemColors.HotTrack;
            btnSearchConference.Location = new Point(769, 66);
            btnSearchConference.MaximumSize = new Size(200, 50);
            btnSearchConference.MinimumSize = new Size(200, 50);
            btnSearchConference.Name = "btnSearchConference";
            btnSearchConference.Size = new Size(200, 50);
            btnSearchConference.TabIndex = 4;
            btnSearchConference.Text = "Search Conference";
            btnSearchConference.UseVisualStyleBackColor = true;
            btnSearchConference.Click += btnSearchConference_Click;
            // 
            // ConferenceTable
            // 
            ConferenceTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConferenceTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConferenceTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConferenceTable.Location = new Point(21, 122);
            ConferenceTable.MultiSelect = false;
            ConferenceTable.Name = "ConferenceTable";
            ConferenceTable.RowHeadersVisible = false;
            ConferenceTable.RowHeadersWidth = 51;
            ConferenceTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ConferenceTable.Size = new Size(948, 352);
            ConferenceTable.TabIndex = 5;
            // 
            // ConferenceReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 486);
            Controls.Add(ConferenceTable);
            Controls.Add(btnSearchConference);
            Controls.Add(label1);
            Name = "ConferenceReportForm";
            Text = "ConferenceReportForm";
            ((System.ComponentModel.ISupportInitialize)ConferenceTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSearchConference;
        private DataGridView ConferenceTable;
    }
}