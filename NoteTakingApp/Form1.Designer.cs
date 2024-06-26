﻿namespace NoteTakingApp
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
            btnPickColor = new Button();
            colorDialog1 = new ColorDialog();
            listViewNotes = new ListView();
            SuspendLayout();
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(148, 66);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(354, 34);
            textBoxNote.TabIndex = 0;
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(12, 66);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(75, 62);
            btnAddNote.TabIndex = 2;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Location = new Point(12, 134);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(75, 58);
            btnDeleteNote.TabIndex = 3;
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // btnSaveNotes
            // 
            btnSaveNotes.Location = new Point(12, 198);
            btnSaveNotes.Name = "btnSaveNotes";
            btnSaveNotes.Size = new Size(75, 60);
            btnSaveNotes.TabIndex = 4;
            btnSaveNotes.Text = "Save Note";
            btnSaveNotes.UseVisualStyleBackColor = true;
            btnSaveNotes.Click += btnSaveNotes_Click;
            // 
            // btnLoadNotes
            // 
            btnLoadNotes.Location = new Point(12, 264);
            btnLoadNotes.Name = "btnLoadNotes";
            btnLoadNotes.Size = new Size(75, 63);
            btnLoadNotes.TabIndex = 5;
            btnLoadNotes.Text = "Load Note";
            btnLoadNotes.UseVisualStyleBackColor = true;
            btnLoadNotes.Click += btnLoadNotes_Click;
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(580, 178);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(75, 68);
            btnPickColor.TabIndex = 6;
            btnPickColor.Text = "Pick Color";
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // listViewNotes
            // 
            listViewNotes.Location = new Point(148, 134);
            listViewNotes.Name = "listViewNotes";
            listViewNotes.Size = new Size(354, 193);
            listViewNotes.TabIndex = 7;
            listViewNotes.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(listViewNotes);
            Controls.Add(btnPickColor);
            Controls.Add(btnLoadNotes);
            Controls.Add(btnSaveNotes);
            Controls.Add(btnDeleteNote);
            Controls.Add(btnAddNote);
            Controls.Add(textBoxNote);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNote;
        private Button btnAddNote;
        private Button btnDeleteNote;
        private Button btnSaveNotes;
        private Button btnLoadNotes;
        private Button btnPickColor;
        private ColorDialog colorDialog1;
        private ListView listViewNotes;
    }
}
