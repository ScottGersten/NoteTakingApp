using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace NoteTakingApp.Maui;
[QueryProperty(nameof(SelectedNote), "SelectedNote")]


public partial class NoteDetailsPage : ContentPage
{
	
	private Note currNote;

	public Note SelectedNote
	{
		get => currNote;
		set
		{
			currNote = value;
			Title = currNote.Title;
			NoteEditor.Text = currNote.Text;
		}
	}
	public NoteDetailsPage()
	{
		InitializeComponent();
		
	}

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
		currNote.Text = NoteEditor.Text;

		await Shell.Current.GoToAsync("..");
    }

    private async void CancelButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");

    }
}