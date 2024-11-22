using Xamarin.Forms;

namespace MyApp
{
    public partial class CVFormPage : ContentPage
    {
        public CVFormPage()
        {
            InitializeComponent();
        }

        private async void OnGenerateCVClicked(object sender, EventArgs e)
        {
            // Recopilar datos del formulario
            var name = NameEntry.Text;
            var email = EmailEntry.Text;
            var phone = PhoneEntry.Text;
            var address = AddressEntry.Text;
            var skills = SkillsEditor.Text;
            var experience = ExperienceEditor.Text;

            // Navegar a la página de visualización del CV
            await Navigation.PushAsync(new CVDisplayPage(name, email, phone, address, skills, experience));
        }
    }
}
