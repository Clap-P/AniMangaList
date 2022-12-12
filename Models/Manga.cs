using System.ComponentModel.DataAnnotations;

namespace AniMangaList.Models;

public class Manga
{

    public int Id { get; set; }

    [StringLenght(50, MinimumLenght = 3)]
    [Required]
    [Display(Name = "Nom")]
    public string Name { get; set; }


    public string? Description { get; set; }
    public virtual Image image { get; set; }


    [Range(1, 1800)]
    [Required]
    [Display(Name = "Prix")]
    public decimal Price { get; set; }
}
