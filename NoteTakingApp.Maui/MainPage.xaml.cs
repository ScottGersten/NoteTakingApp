using Microsoft.Maui.Controls;
using NoteTakingApp.Maui;
using System.Collections.ObjectModel;

namespace NoteTakingApp.Maui;
public class LockNoteConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        var note = value as Note;
        if (note != null && note.IsLocked)
        {
            return "******";
        }
        return note.Text;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
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
            if (selectedNote.IsLocked)
            {
                int attempts = 0;
                bool isUnlocked = false;

                while (attempts < 5 && !isUnlocked)
                {
                    string passwordInput = await DisplayPromptAsync("Password Required", "Enter the password to unlock this note:", "OK", "Cancel", "Enter password", maxLength: 20, keyboard: Keyboard.Text);

                    if (passwordInput == selectedNote.Password)
                    {
                        isUnlocked = true;
                    }
                    
                    else
                    {
                        attempts++;
                        if (attempts == 5)
                        {
                            notes.Remove(selectedNote);
                            await DisplayAlert("Note Deleted", "You have exceeded the maximum password attempts. The note has been deleted.", "OK");
                            return;
                        }

                        await DisplayAlert("Incorrect Password", $"Incorrect password. You have {5 - attempts} attempts remaining.", "OK");

                    }
                }

                if (isUnlocked)
                {
                    var navigationParameter = new Dictionary<string, object>
                    {
                        {"SelectedNote", selectedNote }
                    };
                    await Shell.Current.GoToAsync(nameof(NoteDetailsPage), navigationParameter);
                }
            }
            else
            {
                var navigationParameter = new Dictionary<string, object>
                {
                    {"SelectedNote", selectedNote }
                };
                await Shell.Current.GoToAsync(nameof(NoteDetailsPage), navigationParameter);
            }


            

            
        }
        else
        {
            await DisplayAlert("Error", "Please select a note to view", "OK");
        }

    }

    private void NotesDataGrid_SelectionChanged(object sender, Telerik.Maui.Controls.DataGrid.DataGridSelectionChangedEventArgs e)
    {

    }

    private async void LockNoteButton_Clicked(object sender, EventArgs e)
    {
        if (NotesDataGrid.SelectedItem is Note selectedNote)
        {
            string password = await DisplayPromptAsync("Lock Note", "Enter your password", "OK", "Cancel", "Enter password", maxLength: 20, keyboard: Keyboard.Text);

            if (!string.IsNullOrEmpty(password))
            {
                selectedNote.Password = password;
                NotesDataGrid.ItemsSource = null;
                NotesDataGrid.ItemsSource = notes;
            }
        }

        else
        {
            await DisplayAlert("Error", "Please select a note to lock", "OK");
        }

    }
}
