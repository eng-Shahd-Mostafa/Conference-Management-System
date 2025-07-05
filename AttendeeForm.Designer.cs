namespace Conference_Management_System
{
    partial class AttendeeForm
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
            btnSearchAttendee = new Button();
            AttendeeTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AttendeeTable).BeginInit();
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
            label1.Text = "List of Attendees";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSearchAttendee
            // 
            btnSearchAttendee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchAttendee.Font = new Font("Britannic Bold", 9F);
            btnSearchAttendee.ForeColor = SystemColors.HotTrack;
            btnSearchAttendee.Location = new Point(769, 66);
            btnSearchAttendee.MaximumSize = new Size(200, 50);
            btnSearchAttendee.MinimumSize = new Size(200, 50);
            btnSearchAttendee.Name = "btnSearchAttendee";
            btnSearchAttendee.Size = new Size(200, 50);
            btnSearchAttendee.TabIndex = 4;
            btnSearchAttendee.Text = "Search Attendee";
            btnSearchAttendee.UseVisualStyleBackColor = true;
            btnSearchAttendee.Click += btnSearchAttendee_Click;
            // 
            // AttendeeTable
            // 
            AttendeeTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AttendeeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttendeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendeeTable.Location = new Point(21, 122);
            AttendeeTable.MultiSelect = false;
            AttendeeTable.Name = "AttendeeTable";
            AttendeeTable.RowHeadersVisible = false;
            AttendeeTable.RowHeadersWidth = 51;
            AttendeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AttendeeTable.Size = new Size(948, 352);
            AttendeeTable.TabIndex = 5;
            // 
            // AttendeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 486);
            Controls.Add(AttendeeTable);
            Controls.Add(btnSearchAttendee);
            Controls.Add(label1);
            Name = "AttendeeForm";
            Text = "AttendeeForm";
            ((System.ComponentModel.ISupportInitialize)AttendeeTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSearchAttendee;
        private DataGridView AttendeeTable;
    }
}