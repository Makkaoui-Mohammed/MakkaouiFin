namespace MakkaouiFin.Models
{
    public class Panier
    {
        internal readonly object LignePanier;

        public int PanierID { get; set; }
        public string Description { get; set; }
        //quest:9
        //public List<LignePanier> LignePaniers { get; set; }
    }
}