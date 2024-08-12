namespace NoteTakingApp.Maui;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void TitleEditor_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void NoteEditor_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void AddNoteButton_Clicked(object sender, EventArgs e)
    {

    }

    private void ClearNoteButton_Clicked(object sender, EventArgs e)
    {

    }

    private void DeleteNoteButton_Clicked(object sender, EventArgs e)
    {

    }

    /*private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void MyButtonClicked(object sender, EventArgs e)
    {
        *//*var client = new HttpClient();
        var result = await client.GetStringAsync("google.com");
        File.WriteAllText("text.txt",result);
        await File.WriteAllTextAsync("text.txt", result);*//*

        if (!string.IsNullOrEmpty(NoteText.Text))
        {
            string note_text = NoteText.Text;
        }
        else
        {
            var k = await DisplayAlert("Alert", "Would you like to save?", "Yes", "No");




        }

    }

    private void NoteText_TextChanged(object sender, TextChangedEventArgs e)
    {
        WatermarkLabel.IsVisible = string.IsNullOrEmpty(NoteText.Text);
    }*/
}
