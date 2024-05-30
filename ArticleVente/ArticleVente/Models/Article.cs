namespace ArticleVente.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }

        public  Article() { }
        public Article(int id, string nom,double prix, int quantite )
        {
            Id = id;
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
        }


    }
}
