using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace NoteTakingApp
{
    
    public partial class Form1 : Form
    {
        private List<Note> notes;
        private Color selectedColor = Color.White;
        public Form1()
        {
            InitializeComponent();
            notes = new List<Note>();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string noteText = textBoxNote.Text;
            if (!string.IsNullOrWhiteSpace(noteText))
            {
                Note note = new Note { Text = noteText, BackGroundColor = ColorTranslator.ToHtml(selectedColor) };
                notes.Add(note);
                ListViewItem item = new ListViewItem(note.Text);
                item.BackColor = selectedColor;
                listViewNotes.Items.Add(item);
                textBoxNote.Clear();
                textBoxNote.BackColor = Color.White;
                selectedColor = Color.White;
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            /*int index = listViewNotes.SelectedIndices[0];
            if (index > 0)
            {
                notes.RemoveAt(index);
                listViewNotes.Items.RemoveAt(index);
            }*/

            if (listViewNotes.SelectedItems.Count > 0)
            {
                int index = listViewNotes.SelectedItems[0].Index;
                notes.RemoveAt(index);
                listViewNotes.Items.RemoveAt(index);
            }
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                /*Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt"*/

                Filter = "JSON Files (*.json|*.json|All Files (*.*)|*.*",
                DefaultExt = "json"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                /*File.WriteAllLines(sfd.FileName, notes);*/
                string json = JsonSerializer.Serialize(notes, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(sfd.FileName, json);
            }
        }

        private void btnLoadNotes_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JSON Files (*.json|*.json|All Files (*.*)|*.*",
                DefaultExt = "json"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                /*notes.Clear();
                listBoxNotes.Items.Clear();
                notes.AddRange(File.ReadAllLines(ofd.FileName));
                listBoxNotes.Items.AddRange(notes.ToArray());*/

                string json = File.ReadAllText(ofd.FileName);
                notes = JsonSerializer.Deserialize<List<Note>>(json);

                listViewNotes.Items.Clear();
                foreach( var note in notes)
                {
                    ListViewItem item = new ListViewItem(note.Text);
                    item.BackColor = note.GetColor(); ;
                    listViewNotes.Items.Add(item);
                }

            }
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
                textBoxNote.BackColor = selectedColor;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        /*private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }*/
    }
    
    [Serializable]
    public class Note
    {
        public string Text { get; set; }
        public string BackGroundColor { get; set; }

        public Note() { }
        public Note(string text, Color backgroundColor)
        {
            Text = text;
            BackGroundColor = ColorTranslator.ToHtml(backgroundColor);
        }
        public Color GetColor()
        {
            return ColorTranslator.FromHtml(BackGroundColor);
        }
    }
}
