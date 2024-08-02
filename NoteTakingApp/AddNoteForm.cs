using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NoteTakingApp
{
    public partial class AddNoteForm : Form
    {
        public Note NewNote { get; private set; }
        private Color selectedBackColor = Color.White;
        private Color selectedTextColor = Color.Black;

        public AddNoteForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(473, 448);
        }

        private void btnPickBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()  == DialogResult.OK)
            {
                selectedBackColor = colorDialog1.Color;
                textBoxNote.BackColor = selectedBackColor;
                textBoxTitle.BackColor = selectedBackColor;
            }
        }

        private void btnPickTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedTextColor = colorDialog1.Color;
                textBoxNote.ForeColor = selectedTextColor;
                textBoxTitle.ForeColor = selectedTextColor;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noteTitle = textBoxTitle.Text;
            string noteText = textBoxNote.Text;
            if (!string.IsNullOrEmpty(noteTitle) && !string.IsNullOrEmpty(noteText))
            {
                NewNote = new Note
                {
                    Title = noteTitle,
                    Text = noteText,
                    BackGroundColor = ColorTranslator.ToHtml(selectedBackColor),
                    TextColor = ColorTranslator.ToHtml(selectedTextColor)
                };
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Enter both a title and text for your note.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
