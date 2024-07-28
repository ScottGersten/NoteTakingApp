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
        public string NoteTitle { get; private set; }
        public string NoteText { get; private set; }
        public Color NoteBackgroundColor { get; private set; }
        public Color NoteTextColor { get; private set; }
        public NoteEditorForm(string title, string text, Color backgroundColor, Color textColor)
        {
            InitializeComponent();
            NoteTitle = title;
            NoteText = text;
            NoteBackgroundColor = backgroundColor;
            NoteTextColor = textColor;
            textBoxTitleEditor.Text = title;
            textBoxNoteEditor.Text = text;
            textBoxNoteEditor.BackColor = backgroundColor;
            textBoxNoteEditor.ForeColor = textColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NoteTitle = textBoxTitleEditor.Text;
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

        private void btnPickBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NoteBackgroundColor = colorDialog1.Color;
                textBoxNoteEditor.BackColor = NoteBackgroundColor;
            }
        }

        private void btnPickTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NoteTextColor = colorDialog1.Color;
                textBoxNoteEditor.ForeColor = NoteTextColor;
            }
        }
    }
}
