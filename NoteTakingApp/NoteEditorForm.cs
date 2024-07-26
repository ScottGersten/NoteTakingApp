using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteEditorForm : Form
    {
        public string NoteText { get; private set; }
        public Color NoteBackgroundColor { get; private set; }
        public Color NoteTextColor { get; private set; }
        public NoteEditorForm(string noteText, Color backgroundColor, Color textColor)
        {
            InitializeComponent();
            textBoxNoteEditor.Text = noteText;
            textBoxNoteEditor.BackColor = backgroundColor;
            textBoxNoteEditor.ForeColor = textColor;
            NoteBackgroundColor = backgroundColor;
            NoteTextColor = textColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NoteText = textBoxNoteEditor.Text;
            NoteBackgroundColor = textBoxNoteEditor.BackColor;
            NoteTextColor = textBoxNoteEditor.ForeColor;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
