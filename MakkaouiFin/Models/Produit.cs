using System.ComponentModel.DataAnnotations;

namespace MakkaouiFin.Models
{
    public class Produit
    {
        public int ProduitID { get; set; }

        [Required(ErrorMessage = "Please write the Name of product  ")]
        [StringLength(10, ErrorMessage = "Name length can't be more than 8.")]
        public string? Nom { get; set; }

        public float? Price { get; set; }

    }
}