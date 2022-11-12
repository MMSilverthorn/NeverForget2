namespace NeverForget2
{
    partial class NeverForget2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeverForget2));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.loadNoteButton = new System.Windows.Forms.Button();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.noteBoxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(776, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noteBox
            // 
            this.noteBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.noteBox.Location = new System.Drawing.Point(776, 70);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(334, 468);
            this.noteBox.TabIndex = 5;
            this.noteBox.TextChanged += new System.EventHandler(this.noteBox_TextChanged);
            // 
            // previousNotes
            // 
            this.previousNotes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(290, 34);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.RowTemplate.Height = 25;
            this.previousNotes.Size = new System.Drawing.Size(333, 439);
            this.previousNotes.TabIndex = 6;
            this.previousNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellContentClick);
            // 
            // loadNoteButton
            // 
            this.loadNoteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadNoteButton.Location = new System.Drawing.Point(672, 69);
            this.loadNoteButton.Name = "loadNoteButton";
            this.loadNoteButton.Size = new System.Drawing.Size(75, 23);
            this.loadNoteButton.TabIndex = 7;
            this.loadNoteButton.Text = "Load";
            this.loadNoteButton.UseVisualStyleBackColor = true;
            this.loadNoteButton.Click += new System.EventHandler(this.loadNoteButton_Click);
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveNoteButton.Location = new System.Drawing.Point(672, 99);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(75, 23);
            this.saveNoteButton.TabIndex = 8;
            this.saveNoteButton.Text = "Save";
            this.saveNoteButton.UseVisualStyleBackColor = true;
            this.saveNoteButton.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newNoteButton.Location = new System.Drawing.Point(672, 157);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(75, 23);
            this.newNoteButton.TabIndex = 10;
            this.newNoteButton.Text = "New";
            this.newNoteButton.UseVisualStyleBackColor = true;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteNoteButton.Location = new System.Drawing.Point(672, 128);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteNoteButton.TabIndex = 11;
            this.deleteNoteButton.Text = "Delete";
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(776, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(40, 17);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Title:";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // noteBoxLabel
            // 
            this.noteBoxLabel.AutoSize = true;
            this.noteBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noteBoxLabel.Location = new System.Drawing.Point(776, 50);
            this.noteBoxLabel.Name = "noteBoxLabel";
            this.noteBoxLabel.Size = new System.Drawing.Size(42, 17);
            this.noteBoxLabel.TabIndex = 13;
            this.noteBoxLabel.Text = "Note:";
            this.noteBoxLabel.Click += new System.EventHandler(this.noteBoxLabel_Click);
            // 
            // NeverForget2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 559);
            this.Controls.Add(this.noteBoxLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.saveNoteButton);
            this.Controls.Add(this.loadNoteButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "NeverForget2";
            this.Text = "NeverForget2";
            this.Load += new System.EventHandler(this.NeverForget2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
        private TextBox noteBox;
        private DataGridView previousNotes;
        private Button loadNoteButton;
        private Button saveNoteButton;
        private Button newNoteButton;
        private Button deleteNoteButton;
        private Label titleLabel;
        private Label noteBoxLabel;
    }
}