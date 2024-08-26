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
        NotesDataGrid.ItemsSource = notes;
    }

    private void TitleEditor_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(!string.IsNullOrEmpty(TitleEditor.Text))
        {
            TitleLabel.Text = string.Empty;
        }
        else
        {
            TitleLabel.Text = "Enter Note Title Here...";
        }
        

    }

    private void NoteEditor_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrEmpty(NoteEditor.Text))
        {
            NoteLabel.Text = string.Empty;
        }
        else
        {
            NoteLabel.Text = "Enter Note Here...";
        }

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
        TitleEditor.Text = string.Empty;
        NoteEditor.Text = string.Empty;

    }

    private void DeleteNoteButton_Clicked(object sender, EventArgs e)
    {
        if (NotesDataGrid.SelectedItem != null)
        {
            Note note = (Note)NotesDataGrid.SelectedItem;
            notes.Remove(note);
        }

        else
        {
            DisplayAlert("Error", "Please select a note to delete", "OK");
        }

    }

    private void NotesCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private async void ViewNoteButton_Clicked(object sender, EventArgs e)
    {
        if(NotesDataGrid.SelectedItem is Note selectedNote)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                {"SelectedNote", selectedNote }
            };

            await Shell.Current.GoToAsync(nameof(NoteDetailsPage), navigationParameter);
        }
        else
        {
            await DisplayAlert("Error", "Please select a note to view", "OK");
        }

    }

    private void NotesDataGrid_SelectionChanged(object sender, Telerik.Maui.Controls.DataGrid.DataGridSelectionChangedEventArgs e)
    {

    }
}
