using Microsoft.Maui.Controls;
using NoteTakingApp.Maui;
using System.Collections.ObjectModel;

namespace NoteTakingApp.Maui;

public partial class MainPage : ContentPage
{
    ObservableCollection<Note> notes;

    public MainPage()
    {
        InitializeComponent();
        notes = new ObservableCollection<Note>();
        NotesCollectionView.ItemsSource = notes;
    }

    private void TitleEditor_TextChanged(object sender, TextChangedEventArgs e)
    {
        

    }

    private void NoteEditor_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void AddNoteButton_Clicked(object sender, EventArgs e)
    {
        string title = TitleEditor.Text;
        string text = NoteEditor.Text;

        if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(text))
        {
            Note newNote = new Note(title, text);
            notes.Add(newNote);

            TitleEditor.Text = string.Empty;
            NoteEditor.Text = string.Empty;
        }

        else
        {
            DisplayAlert("Error", "Please enter a note title and body", "OK");
        }
    }

    private void ClearNoteButton_Clicked(object sender, EventArgs e)
    {

    }

    private void DeleteNoteButton_Clicked(object sender, EventArgs e)
    {

    }

    private void NotesCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    
}
