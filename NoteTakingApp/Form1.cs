using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        private List<string> notes;
        public Form1()
        {
            InitializeComponent();
            notes = new List<string>();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string note = textBoxNote.Text;
            if (!string.IsNullOrWhiteSpace(note))
            {
                notes.Add(note);
                listBoxNotes.Items.Add(note);
                textBoxNote.Clear();
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            int index = listBoxNotes.SelectedIndex;
            if (index != -1)
            {
                notes.RemoveAt(index);
                listBoxNotes.Items.RemoveAt(index);
            }
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sfd.FileName, notes);
            }
        }

        private void btnLoadNotes_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                notes.Clear();
                listBoxNotes.Items.Clear();
                notes.AddRange(File.ReadAllLines(ofd.FileName));
                listBoxNotes.Items.AddRange(notes.ToArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }*/
    }
}
