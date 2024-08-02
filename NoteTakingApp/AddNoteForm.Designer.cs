namespace NoteTakingApp
{
    partial class AddNoteForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button btnPickBackColor;
        private System.Windows.Forms.Button btnPickTextColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColorDialog colorDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxNote = new TextBox();
            textBoxTitle = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnPickBackColor = new Button();
            btnPickTextColor = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(20, 44);
            textBoxNote.Margin = new Padding(6, 3, 6, 3);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(431, 189);
            textBoxNote.TabIndex = 0;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(20, 12);
            textBoxTitle.Margin = new Padding(6, 3, 6, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(431, 31);
            textBoxTitle.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(20, 342);
            btnSave.Margin = new Padding(6, 3, 6, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 56);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Info;
            btnCancel.Location = new Point(258, 342);
            btnCancel.Margin = new Padding(6, 3, 6, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(175, 56);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPickBackColor
            // 
            btnPickBackColor.BackColor = SystemColors.AppWorkspace;
            btnPickBackColor.Location = new Point(20, 245);
            btnPickBackColor.Margin = new Padding(6, 3, 6, 3);
            btnPickBackColor.Name = "btnPickBackColor";
            btnPickBackColor.Size = new Size(175, 74);
            btnPickBackColor.TabIndex = 4;
            btnPickBackColor.Text = "Pick Background Color";
            btnPickBackColor.UseVisualStyleBackColor = false;
            btnPickBackColor.Click += btnPickBackColor_Click;
            // 
            // btnPickTextColor
            // 
            btnPickTextColor.BackColor = SystemColors.AppWorkspace;
            btnPickTextColor.Location = new Point(258, 245);
            btnPickTextColor.Margin = new Padding(6, 3, 6, 3);
            btnPickTextColor.Name = "btnPickTextColor";
            btnPickTextColor.Size = new Size(175, 74);
            btnPickTextColor.TabIndex = 5;
            btnPickTextColor.Text = "Pick Text Color";
            btnPickTextColor.UseVisualStyleBackColor = false;
            btnPickTextColor.Click += btnPickTextColor_Click;
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 438);
            Controls.Add(btnPickTextColor);
            Controls.Add(btnPickBackColor);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxNote);
            Margin = new Padding(6, 3, 6, 3);
            Name = "AddNoteForm";
            Text = "Add Note";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
