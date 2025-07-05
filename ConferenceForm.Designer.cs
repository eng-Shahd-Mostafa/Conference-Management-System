namespace Conference_Management_System
{
    partial class ConferenceForm
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
            btnAddConference = new Button();
            btnSearchConference = new Button();
            conferenceTable = new DataGridView();
            btnDeleteConference = new Button();
            btnUpdateConference = new Button();
            ((System.ComponentModel.ISupportInitialize)conferenceTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(966, 37);
            label1.TabIndex = 0;
            label1.Text = "List of Conferences";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddConference
            // 
            btnAddConference.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddConference.ForeColor = SystemColors.HotTrack;
            btnAddConference.Location = new Point(12, 69);
            btnAddConference.MaximumSize = new Size(200, 50);
            btnAddConference.MinimumSize = new Size(173, 38);
            btnAddConference.Name = "btnAddConference";
            btnAddConference.Size = new Size(173, 38);
            btnAddConference.TabIndex = 1;
            btnAddConference.Text = "Add Conference";
            btnAddConference.UseVisualStyleBackColor = true;
            btnAddConference.Click += btnAddConference_Click;
            // 
            // btnSearchConference
            // 
            btnSearchConference.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchConference.ForeColor = SystemColors.HotTrack;
            btnSearchConference.Location = new Point(252, 69);
            btnSearchConference.MaximumSize = new Size(200, 50);
            btnSearchConference.MinimumSize = new Size(173, 38);
            btnSearchConference.Name = "btnSearchConference";
            btnSearchConference.Size = new Size(173, 38);
            btnSearchConference.TabIndex = 2;
            btnSearchConference.Text = "Search Conference";
            btnSearchConference.UseVisualStyleBackColor = true;
            btnSearchConference.Click += btnSearchConference_Click;
            // 
            // conferenceTable
            // 
            conferenceTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            conferenceTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conferenceTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            conferenceTable.Location = new Point(12, 123);
            conferenceTable.MultiSelect = false;
            conferenceTable.Name = "conferenceTable";
            conferenceTable.RowHeadersVisible = false;
            conferenceTable.RowHeadersWidth = 51;
            conferenceTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            conferenceTable.Size = new Size(966, 351);
            conferenceTable.TabIndex = 3;
            // 
            // btnDeleteConference
            // 
            btnDeleteConference.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteConference.Font = new Font("Britannic Bold", 9F);
            btnDeleteConference.ForeColor = SystemColors.HotTrack;
            btnDeleteConference.Location = new Point(805, 68);
            btnDeleteConference.MaximumSize = new Size(200, 50);
            btnDeleteConference.MinimumSize = new Size(173, 38);
            btnDeleteConference.Name = "btnDeleteConference";
            btnDeleteConference.Size = new Size(173, 38);
            btnDeleteConference.TabIndex = 4;
            btnDeleteConference.Text = "Delete Conference";
            btnDeleteConference.UseVisualStyleBackColor = true;
            btnDeleteConference.Click += btnDeleteConference_Click;
            // 
            // btnUpdateConference
            // 
            btnUpdateConference.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateConference.Font = new Font("Britannic Bold", 9F);
            btnUpdateConference.ForeColor = SystemColors.HotTrack;
            btnUpdateConference.Location = new Point(576, 69);
            btnUpdateConference.MaximumSize = new Size(200, 50);
            btnUpdateConference.MinimumSize = new Size(173, 38);
            btnUpdateConference.Name = "btnUpdateConference";
            btnUpdateConference.Size = new Size(173, 38);
            btnUpdateConference.TabIndex = 5;
            btnUpdateConference.Text = "Update Conference";
            btnUpdateConference.UseVisualStyleBackColor = true;
            btnUpdateConference.Click += btnUpdateConference_Click;
            // 
            // ConferenceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 486);
            Controls.Add(btnUpdateConference);
            Controls.Add(btnDeleteConference);
            Controls.Add(conferenceTable);
            Controls.Add(btnSearchConference);
            Controls.Add(btnAddConference);
            Controls.Add(label1);
            Name = "ConferenceForm";
            Text = "Conference Data";
            ((System.ComponentModel.ISupportInitialize)conferenceTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddConference;
        private Button btnSearchConference;
        private DataGridView conferenceTable;
        private Button btnDeleteConference;
        private Button btnUpdateConference;
    }
}