using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

public class Book
{
    [Key]
    public required int InventoryNumber { get; set; } // Инвентарный номер
    public required string CatalogCode { get; set; } // Шифр в каталоге
    public required string Authors { get; set; } // Авторы
    public required string Title { get; set; } // Название
    public required string PublicationType { get; set; } // Тип издания
    public required string PublicationPlace { get; set; } // Место издания
    public required int PublicationYear { get; set; } // Год издания
}