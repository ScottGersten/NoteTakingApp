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
            btnAddNote = new Button();
            btnDeleteNote = new Button();
            btnSaveNotes = new Button();
            btnLoadNotes = new Button();
            colorDialog1 = new ColorDialog();
            listViewNotes = new ListView();
            btnViewNote = new Button();
            SuspendLayout();
            // 
            // btnAddNote
            // 
            btnAddNote.BackColor = SystemColors.ActiveCaption;
            btnAddNote.Cursor = Cursors.Hand;
            btnAddNote.Location = new Point(53, 544);
            btnAddNote.Margin = new Padding(4, 5, 4, 5);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(130, 103);
            btnAddNote.TabIndex = 2;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = false;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.BackColor = SystemColors.ActiveCaption;
            btnDeleteNote.Cursor = Cursors.Hand;
            btnDeleteNote.Location = new Point(373, 544);
            btnDeleteNote.Margin = new Padding(4, 5, 4, 5);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(130, 103);
            btnDeleteNote.TabIndex = 3;
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = false;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // btnSaveNotes
            // 
            btnSaveNotes.BackColor = SystemColors.HotTrack;
            btnSaveNotes.Cursor = Cursors.Hand;
            btnSaveNotes.Location = new Point(652, 540);
            btnSaveNotes.Margin = new Padding(4, 5, 4, 5);
            btnSaveNotes.Name = "btnSaveNotes";
            btnSaveNotes.Size = new Size(130, 103);
            btnSaveNotes.TabIndex = 4;
            btnSaveNotes.Text = "Save all notes to file";
            btnSaveNotes.UseVisualStyleBackColor = false;
            btnSaveNotes.Click += btnSaveNotes_Click;
            // 
            // btnLoadNotes
            // 
            btnLoadNotes.BackColor = SystemColors.HotTrack;
            btnLoadNotes.Cursor = Cursors.Hand;
            btnLoadNotes.Location = new Point(826, 540);
            btnLoadNotes.Margin = new Padding(4, 5, 4, 5);
            btnLoadNotes.Name = "btnLoadNotes";
            btnLoadNotes.Size = new Size(130, 103);
            btnLoadNotes.TabIndex = 5;
            btnLoadNotes.Text = "Load all notes from file";
            btnLoadNotes.UseVisualStyleBackColor = false;
            btnLoadNotes.Click += btnLoadNotes_Click;
            // 
            // listViewNotes
            // 
            listViewNotes.Location = new Point(53, 42);
            listViewNotes.Margin = new Padding(4, 5, 4, 5);
            listViewNotes.MultiSelect = false;
            listViewNotes.Name = "listViewNotes";
            listViewNotes.Size = new Size(891, 492);
            listViewNotes.TabIndex = 7;
            listViewNotes.UseCompatibleStateImageBehavior = false;
            listViewNotes.View = View.List;
            // 
            // btnViewNote
            // 
            btnViewNote.BackColor = SystemColors.ActiveCaption;
            btnViewNote.Cursor = Cursors.Hand;
            btnViewNote.Location = new Point(214, 544);
            btnViewNote.Margin = new Padding(4, 5, 4, 5);
            btnViewNote.Name = "btnViewNote";
            btnViewNote.Size = new Size(130, 103);
            btnViewNote.TabIndex = 9;
            btnViewNote.Text = "View Note";
            btnViewNote.UseVisualStyleBackColor = false;
            btnViewNote.Click += btnViewNote_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 750);
            Controls.Add(btnViewNote);
            Controls.Add(listViewNotes);
            Controls.Add(btnLoadNotes);
            Controls.Add(btnSaveNotes);
            Controls.Add(btnDeleteNote);
            Controls.Add(btnAddNote);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
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
        private Button btnAddNote;
        private Button btnDeleteNote;
        private Button btnSaveNotes;
        private Button btnLoadNotes;
        //private Button btnPickBackColor;
        private ColorDialog colorDialog1;
        private ListView listViewNotes;
        //private Button btnPickTextColor;
        private Button btnViewNote;
    }
}
