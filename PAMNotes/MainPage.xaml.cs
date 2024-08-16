namespace PAMNotes
{
    public partial class MainPage : ContentPage
    {
        string filePath = Path.Combine(FileSystem.AppDataDirectory,"Notes.txt");
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
                NoteEditor.Text = File.ReadAllText(filePath);
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            string texto = NoteEditor.Text;
            File.WriteAllText(filePath, texto);
            DisplayAlert("Sucesso", "Operação concluida!", "Ok");

        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                DisplayAlert("Sucesso", "Operação concluida com sucesso!", "Ok");
            }
            else
            {
                DisplayAlert("Alerta", "Arquivo não encontrado", "Ok");
            }
        }
    }
}