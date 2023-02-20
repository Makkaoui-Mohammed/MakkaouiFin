namespace MakkaouiFin.Models
{
    public class LignePanier
    {
        public int LignePanierID { get; set; }
        public int Quantite { get; set; }
        public int PanierID { get; set; }
        public int ProduitID { get; set; }
    }
}