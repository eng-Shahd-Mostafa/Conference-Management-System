namespace Conference_Management_System
{
    partial class SessionForm
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
            btnAddSession = new Button();
            btnSearchSession = new Button();
            btnUpdateSession = new Button();
            btnDeleteSession = new Button();
            sessionTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)sessionTable).BeginInit();
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
            label1.Text = "List of Sessions";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddSession
            // 
            btnAddSession.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSession.ForeColor = SystemColors.HotTrack;
            btnAddSession.Location = new Point(12, 78);
            btnAddSession.MaximumSize = new Size(200, 50);
            btnAddSession.MinimumSize = new Size(173, 38);
            btnAddSession.Name = "btnAddSession";
            btnAddSession.Size = new Size(173, 38);
            btnAddSession.TabIndex = 1;
            btnAddSession.Text = "Add Session";
            btnAddSession.UseVisualStyleBackColor = true;
            btnAddSession.Click += btnAddSession_Click;
            // 
            // btnSearchSession
            // 
            btnSearchSession.Font = new Font("Britannic Bold", 9F);
            btnSearchSession.ForeColor = SystemColors.HotTrack;
            btnSearchSession.Location = new Point(262, 78);
            btnSearchSession.MaximumSize = new Size(200, 50);
            btnSearchSession.MinimumSize = new Size(173, 38);
            btnSearchSession.Name = "btnSearchSession";
            btnSearchSession.Size = new Size(173, 38);
            btnSearchSession.TabIndex = 2;
            btnSearchSession.Text = "Search Session";
            btnSearchSession.UseVisualStyleBackColor = true;
            btnSearchSession.Click += btnSearchSession_Click;
            // 
            // btnUpdateSession
            // 
            btnUpdateSession.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateSession.Font = new Font("Britannic Bold", 9F);
            btnUpdateSession.ForeColor = SystemColors.HotTrack;
            btnUpdateSession.Location = new Point(534, 78);
            btnUpdateSession.MaximumSize = new Size(200, 50);
            btnUpdateSession.MinimumSize = new Size(173, 38);
            btnUpdateSession.Name = "btnUpdateSession";
            btnUpdateSession.Size = new Size(173, 38);
            btnUpdateSession.TabIndex = 3;
            btnUpdateSession.Text = "Update Session";
            btnUpdateSession.UseVisualStyleBackColor = true;
            btnUpdateSession.Click += btnUpdateSession_Click;
            // 
            // btnDeleteSession
            // 
            btnDeleteSession.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteSession.Font = new Font("Britannic Bold", 9F);
            btnDeleteSession.ForeColor = SystemColors.HotTrack;
            btnDeleteSession.Location = new Point(805, 78);
            btnDeleteSession.MaximumSize = new Size(200, 50);
            btnDeleteSession.MinimumSize = new Size(173, 38);
            btnDeleteSession.Name = "btnDeleteSession";
            btnDeleteSession.Size = new Size(173, 38);
            btnDeleteSession.TabIndex = 4;
            btnDeleteSession.Text = "Delete Session";
            btnDeleteSession.UseVisualStyleBackColor = true;
            btnDeleteSession.Click += btnDeleteSession_Click;
            // 
            // sessionTable
            // 
            sessionTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sessionTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sessionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sessionTable.Location = new Point(21, 122);
            sessionTable.MultiSelect = false;
            sessionTable.Name = "sessionTable";
            sessionTable.RowHeadersVisible = false;
            sessionTable.RowHeadersWidth = 51;
            sessionTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sessionTable.Size = new Size(948, 352);
            sessionTable.TabIndex = 5;
            // 
            // SessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 486);
            Controls.Add(sessionTable);
            Controls.Add(btnDeleteSession);
            Controls.Add(btnUpdateSession);
            Controls.Add(btnSearchSession);
            Controls.Add(btnAddSession);
            Controls.Add(label1);
            Name = "SessionForm";
            Text = "SessionForm";
            ((System.ComponentModel.ISupportInitialize)sessionTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAddSession;
        private Button btnSearchSession;
        private Button btnUpdateSession;
        private Button btnDeleteSession;
        private DataGridView sessionTable;
    }
}