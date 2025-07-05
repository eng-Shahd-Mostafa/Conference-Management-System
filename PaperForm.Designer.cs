namespace Conference_Management_System
{
    partial class PaperForm
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
            btnSearchPaper = new Button();
            paperTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)paperTable).BeginInit();
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
            label1.Text = "List of Papers";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSearchPaper
            // 
            btnSearchPaper.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchPaper.Font = new Font("Britannic Bold", 9F);
            btnSearchPaper.ForeColor = SystemColors.HotTrack;
            btnSearchPaper.Location = new Point(769, 66);
            btnSearchPaper.MaximumSize = new Size(200, 50);
            btnSearchPaper.MinimumSize = new Size(200, 50);
            btnSearchPaper.Name = "btnSearchPaper";
            btnSearchPaper.Size = new Size(200, 50);
            btnSearchPaper.TabIndex = 4;
            btnSearchPaper.Text = "Search Paper";
            btnSearchPaper.UseVisualStyleBackColor = true;
            btnSearchPaper.Click += btnSearchPaper_Click;
            // 
            // paperTable
            // 
            paperTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paperTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paperTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paperTable.Location = new Point(21, 122);
            paperTable.MultiSelect = false;
            paperTable.Name = "paperTable";
            paperTable.RowHeadersVisible = false;
            paperTable.RowHeadersWidth = 51;
            paperTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            paperTable.Size = new Size(948, 352);
            paperTable.TabIndex = 5;
            // 
            // PaperForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 486);
            Controls.Add(paperTable);
            Controls.Add(btnSearchPaper);
            Controls.Add(label1);
            Name = "PaperForm";
            Text = "PaperForm";
            ((System.ComponentModel.ISupportInitialize)paperTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSearchPaper;
        private DataGridView paperTable;
    }
}