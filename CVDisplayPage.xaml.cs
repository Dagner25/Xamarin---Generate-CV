using Xamarin.Forms;

namespace MyApp
{
    public partial class CVDisplayPage : ContentPage
    {
        public CVDisplayPage(string name, string email, string phone, string address, string skills, string experience)
        {
            InitializeComponent();

            // Asignar los datos ingresados a las etiquetas
            NameLabel.Text = name;
            EmailLabel.Text = email;
            PhoneLabel.Text = phone;
            AddressLabel.Text = address;
            SkillsLabel.Text = skills;
            ExperienceLabel.Text = experience;
        }
    }
}
