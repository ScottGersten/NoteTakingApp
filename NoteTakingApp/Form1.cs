using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NoteTakingApp
{
    
    public partial class Form1 : Form
    {
        private List<Note> notes;
        private Color selectedBackColor = Color.White;
        private Color selectedTextColor = Color.Black;
        private const string NotesFilePath = "notes.json";
        public Form1()
        {
            InitializeComponent();
            notes = new List<Note>();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string noteTitle = textBoxTitle.Text;
            string noteText = textBoxNote.Text;
            if (!string.IsNullOrWhiteSpace(noteText) &&
                !string.IsNullOrWhiteSpace(noteTitle))
            {
                Note note = new Note { Title = noteTitle, 
                    Text = noteText, 
                    BackGroundColor = ColorTranslator.ToHtml(selectedBackColor),
                    TextColor = ColorTranslator.ToHtml(selectedTextColor)};

                notes.Add(note);
                ListViewItem item = new ListViewItem(note.Title);
                item.BackColor = selectedBackColor;
                item.ForeColor = selectedTextColor;

                listViewNotes.Items.Add(item);

                textBoxTitle.Clear();
                textBoxNote.Clear();
                textBoxNote.BackColor = Color.White;
                textBoxNote.ForeColor = Color.Black;
                selectedBackColor = Color.White;
                selectedTextColor = Color.Black;
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
                    ListViewItem item = new ListViewItem(note.Title);
                    item.BackColor = note.GetBackgroundColor(); ;
                    item.ForeColor = note.GetTextColor();
                    listViewNotes.Items.Add(item);
                }

            }
        }

        private void btnPickBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
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

        private void btnViewNote_Click(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count > 0)
            {
                int index = listViewNotes.SelectedItems[0].Index;
                Note selectedNote = notes[index];
                using (NoteEditorForm editor = new NoteEditorForm(selectedNote.Title, selectedNote.Text, selectedNote.GetBackgroundColor(), selectedNote.GetTextColor()))
                {
                    if (editor.ShowDialog() == DialogResult.OK)
                    {
                        selectedNote.Title = editor.NoteTitle;
                        selectedNote.Text = editor.NoteText;
                        selectedNote.BackGroundColor = ColorTranslator.ToHtml(editor.NoteBackgroundColor);
                        selectedNote.TextColor = ColorTranslator.ToHtml(editor.NoteTextColor);

                        ListViewItem item = listViewNotes.Items[index];
                        item.Text = selectedNote.Title;
                        item.BackColor = selectedNote.GetBackgroundColor();
                        item.ForeColor = selectedNote.GetTextColor();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotesFromFile();
        }

        private void LoadNotesFromFile()
        {
            if (File.Exists(NotesFilePath))
            {
                string json = File.ReadAllText(NotesFilePath);
                notes = JsonSerializer.Deserialize<List<Note>>(json);
                PopulateListView();
            }
        }

        private void PopulateListView()
        {
            listViewNotes.Items.Clear();
            foreach (var note in notes)
            {
                ListViewItem item = new ListViewItem(note.Title)
                {
                    BackColor = note.GetBackgroundColor(),
                    ForeColor = note.GetTextColor()
                };
                listViewNotes.Items.Add(item);

            }
        }

        private void SaveNotesToFile()
        {
            string json = JsonSerializer.Serialize(notes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(NotesFilePath, json);
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
        public string Title { get; set; }
        public string Text { get; set; }
        public string BackGroundColor { get; set; }
        public string TextColor { get; set; }

        public Note() { }
        public Note(string title, string text, Color backgroundColor, Color textColor)
        {
            Title = title;
            Text = text;
            BackGroundColor = ColorTranslator.ToHtml(backgroundColor);
            TextColor = ColorTranslator.ToHtml(textColor);
        }
        public Color GetBackgroundColor()
        {
            return ColorTranslator.FromHtml(BackGroundColor);
        }

        public Color GetTextColor()
        {
            return ColorTranslator.FromHtml(TextColor);
        }
    }
}
