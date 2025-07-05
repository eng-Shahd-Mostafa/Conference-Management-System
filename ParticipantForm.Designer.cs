namespace Conference_Management_System
{
    partial class ParticipantForm
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
            btnSearchParticipant = new Button();
            participantTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)participantTable).BeginInit();
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
            label1.Text = "List of Participnt";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSearchParticipant
            // 
            btnSearchParticipant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchParticipant.Font = new Font("Britannic Bold", 9F);
            btnSearchParticipant.ForeColor = SystemColors.HotTrack;
            btnSearchParticipant.Location = new Point(769, 66);
            btnSearchParticipant.MaximumSize = new Size(200, 50);
            btnSearchParticipant.MinimumSize = new Size(200, 50);
            btnSearchParticipant.Name = "btnSearchParticipant";
            btnSearchParticipant.Size = new Size(200, 50);
            btnSearchParticipant.TabIndex = 4;
            btnSearchParticipant.Text = "Search Participant";
            btnSearchParticipant.UseVisualStyleBackColor = true;
            btnSearchParticipant.Click += btnSearchParticipant_Click;
            // 
            // participantTable
            // 
            participantTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            participantTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            participantTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            participantTable.Location = new Point(21, 122);
            participantTable.MultiSelect = false;
            participantTable.Name = "participantTable";
            participantTable.RowHeadersVisible = false;
            participantTable.RowHeadersWidth = 51;
            participantTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            participantTable.Size = new Size(948, 352);
            participantTable.TabIndex = 5;
            // 
            // ParticipantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 486);
            Controls.Add(participantTable);
            Controls.Add(btnSearchParticipant);
            Controls.Add(label1);
            Name = "ParticipantForm";
            Text = "ParticipantForm";
            ((System.ComponentModel.ISupportInitialize)participantTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSearchParticipant;
        private DataGridView participantTable;
    }
}