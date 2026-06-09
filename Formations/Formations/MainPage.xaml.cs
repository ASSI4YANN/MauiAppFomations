using Formations.Pages;
using Newtonsoft.Json;
namespace Formations
{
    public partial class MainPage : ContentPage
    {
     List<Categorie> categories = new List<Categorie>();// ma varible privée : categories
         public List<Categorie> Categories
        {
            get {  return categories; } // va retourner la liste des categories.
            set { categories = value; } // va attribuer une valeur a ma liste de catégorie.
        
        }
        public MainPage()
        {
            InitializeComponent();
            LoadDataFromAPI();
            //LoadDataFromLOCAL();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnexionPage());
        }
        /// <summary>
        /// Pour charger les données de l'API
        /// </summary>
        public async void LoadDataFromAPI()
        {
            HttpClient client = new HttpClient(); // pour créé un objet client que l'on va pouvoir utiliser pour faire la requête vers l'API
       
            var RestURL = "http://10.0.2.2:5030/Categorie/"; // l'URL pour afficher le JSON
            client.BaseAddress = new Uri(RestURL);
            HttpResponseMessage response = await client.GetAsync(RestURL);
            var content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<Categorie>>(content);
            lv.ItemsSource = Items; // lv c'est la ListView crée dans MainPage.xaml
        }

        public async void LoadDataFromLOCAL()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("Categorie.json");
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();
            var Items = JsonConvert.DeserializeObject<List<Categorie>>(content);
            lv.ItemsSource = Items; 



        }
    }

}
