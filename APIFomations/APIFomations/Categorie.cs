namespace APIFomations
{
    public class Categorie
    {
        public string Titre { get; set; }

        public int Count { get; set; }

        public string Desc { get; set; }

        public string Image { get; set; }

        public Categorie(string t,int c,string d,string i) 
        { 
        Titre = t;
        Count = c;
        Desc = d;
        Image = i;

        }

    } 
}
