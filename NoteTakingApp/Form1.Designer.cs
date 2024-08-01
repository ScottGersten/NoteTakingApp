namespace NoteTakingApp
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
            textBoxNote = new TextBox();
            btnAddNote = new Button();
            btnDeleteNote = new Button();
            btnSaveNotes = new Button();
            btnLoadNotes = new Button();
            btnPickBackColor = new Button();
            colorDialog1 = new ColorDialog();
            listViewNotes = new ListView();
            btnPickTextColor = new Button();
            btnViewNote = new Button();
            textBoxTitle = new TextBox();
            SuspendLayout();
            // 
            // textBoxNote
            // 
            textBoxNote.AcceptsReturn = true;
            textBoxNote.AcceptsTab = true;
            textBoxNote.AllowDrop = true;
            textBoxNote.Location = new Point(148, 54);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(354, 215);
            textBoxNote.TabIndex = 0;
            // 
            // btnAddNote
            // 
            btnAddNote.BackColor = SystemColors.ActiveCaption;
            btnAddNote.Cursor = Cursors.Hand;
            btnAddNote.Location = new Point(12, 66);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(91, 62);
            btnAddNote.TabIndex = 2;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = false;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.BackColor = SystemColors.ActiveCaption;
            btnDeleteNote.Cursor = Cursors.Hand;
            btnDeleteNote.Location = new Point(12, 134);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(91, 58);
            btnDeleteNote.TabIndex = 3;
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = false;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // btnSaveNotes
            // 
            btnSaveNotes.BackColor = SystemColors.HotTrack;
            btnSaveNotes.Cursor = Cursors.Hand;
            btnSaveNotes.Location = new Point(593, 109);
            btnSaveNotes.Name = "btnSaveNotes";
            btnSaveNotes.Size = new Size(75, 60);
            btnSaveNotes.TabIndex = 4;
            btnSaveNotes.Text = "Save all notes to file";
            btnSaveNotes.UseVisualStyleBackColor = false;
            btnSaveNotes.Click += btnSaveNotes_Click;
            // 
            // btnLoadNotes
            // 
            btnLoadNotes.BackColor = SystemColors.HotTrack;
            btnLoadNotes.Cursor = Cursors.Hand;
            btnLoadNotes.Location = new Point(593, 206);
            btnLoadNotes.Name = "btnLoadNotes";
            btnLoadNotes.Size = new Size(75, 63);
            btnLoadNotes.TabIndex = 5;
            btnLoadNotes.Text = "Load all notes from file";
            btnLoadNotes.UseVisualStyleBackColor = false;
            btnLoadNotes.Click += btnLoadNotes_Click;
            // 
            // btnPickBackColor
            // 
            btnPickBackColor.BackColor = SystemColors.Info;
            btnPickBackColor.Cursor = Cursors.Hand;
            btnPickBackColor.Location = new Point(12, 266);
            btnPickBackColor.Name = "btnPickBackColor";
            btnPickBackColor.Size = new Size(91, 61);
            btnPickBackColor.TabIndex = 6;
            btnPickBackColor.Text = "Pick Background Color";
            btnPickBackColor.UseVisualStyleBackColor = false;
            btnPickBackColor.Click += btnPickBackColor_Click;
            // 
            // listViewNotes
            // 
            listViewNotes.Location = new Point(148, 293);
            listViewNotes.MultiSelect = false;
            listViewNotes.Name = "listViewNotes";
            listViewNotes.Size = new Size(354, 105);
            listViewNotes.TabIndex = 7;
            listViewNotes.UseCompatibleStateImageBehavior = false;
            listViewNotes.View = View.List;
            // 
            // btnPickTextColor
            // 
            btnPickTextColor.BackColor = SystemColors.Info;
            btnPickTextColor.Cursor = Cursors.Hand;
            btnPickTextColor.Location = new Point(12, 206);
            btnPickTextColor.Name = "btnPickTextColor";
            btnPickTextColor.Size = new Size(91, 54);
            btnPickTextColor.TabIndex = 8;
            btnPickTextColor.Text = "Pick Text Color";
            btnPickTextColor.UseVisualStyleBackColor = false;
            btnPickTextColor.Click += btnPickTextColor_Click;
            // 
            // btnViewNote
            // 
            btnViewNote.BackColor = SystemColors.WindowFrame;
            btnViewNote.Cursor = Cursors.Hand;
            btnViewNote.Location = new Point(12, 333);
            btnViewNote.Name = "btnViewNote";
            btnViewNote.Size = new Size(91, 65);
            btnViewNote.TabIndex = 9;
            btnViewNote.Text = "View Note";
            btnViewNote.UseVisualStyleBackColor = false;
            btnViewNote.Click += btnViewNote_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(148, 12);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(354, 23);
            textBoxTitle.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(textBoxTitle);
            Controls.Add(btnViewNote);
            Controls.Add(btnPickTextColor);
            Controls.Add(listViewNotes);
            Controls.Add(btnPickBackColor);
            Controls.Add(btnLoadNotes);
            Controls.Add(btnSaveNotes);
            Controls.Add(btnDeleteNote);
            Controls.Add(btnAddNote);
            Controls.Add(textBoxNote);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            SaveNotesToFile();
        }

        private void BtnPickTextColor_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxNote;
        private Button btnAddNote;
        private Button btnDeleteNote;
        private Button btnSaveNotes;
        private Button btnLoadNotes;
        private Button btnPickBackColor;
        private ColorDialog colorDialog1;
        private ListView listViewNotes;
        private Button btnPickTextColor;
        private Button btnViewNote;
        private TextBox textBoxTitle;
    }
}
