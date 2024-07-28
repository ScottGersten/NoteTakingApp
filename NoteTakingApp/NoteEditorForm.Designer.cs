namespace NoteTakingApp
{
    partial class NoteEditorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxTitleEditor;
        private System.Windows.Forms.TextBox textBoxNoteEditor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPickBackgroundColor;
        private System.Windows.Forms.Button btnPickTextColor;

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
            textBoxNoteEditor = new TextBox();
            textBoxTitleEditor = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnPickBackgroundColor = new Button();
            btnPickTextColor = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // textBoxNoteEditor
            // 
            textBoxNoteEditor.Location = new Point(20, 23);
            textBoxNoteEditor.Margin = new Padding(6, 5, 6, 5);
            textBoxNoteEditor.Multiline = true;
            textBoxNoteEditor.Name = "textBoxNoteEditor";
            textBoxNoteEditor.Size = new Size(431, 342);
            textBoxNoteEditor.TabIndex = 0;
            // 
            // textBoxTitleEditor
            // 
            textBoxTitleEditor.Location = new Point(12, 12);
            textBoxTitleEditor.Name = "textBoxTitleEditor";
            textBoxTitleEditor.Size = new Size(260, 31);
            textBoxTitleEditor.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 380);
            btnSave.Margin = new Padding(6, 5, 6, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 45);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(329, 380);
            btnCancel.Margin = new Padding(6, 5, 6, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPickBackgroundColor
            // 
            btnPickBackgroundColor.Location = new Point(12, 38);
            btnPickBackgroundColor.Name = "btnPickBackgroundColor";
            btnPickBackgroundColor.Size = new Size(130, 23);
            btnPickBackgroundColor.TabIndex = 4;
            btnPickBackgroundColor.Text = "Pick Background Color";
            btnPickBackgroundColor.UseVisualStyleBackColor = true;
            btnPickBackgroundColor.Click += btnPickBackgroundColor_Click;
            // 
            // btnPickTextColor
            // 
            btnPickTextColor.Location = new Point(148, 38);
            btnPickTextColor.Name = "btnPickTextColor";
            btnPickTextColor.Size = new Size(124, 23);
            btnPickTextColor.TabIndex = 5;
            btnPickTextColor.Text = "Pick Text Color";
            btnPickTextColor.UseVisualStyleBackColor = true;
            btnPickTextColor.Click += btnPickTextColor_Click;
            // 
            // NoteEditorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 448);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(textBoxNoteEditor);
            Margin = new Padding(6, 5, 6, 5);
            Name = "NoteEditorForm";
            Text = "Edit Note";
            ResumeLayout(false);
            PerformLayout();
        }

        private ColorDialog colorDialog1;
    }
}
