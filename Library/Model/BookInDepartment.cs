using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

public class BookInDepartment
{
    [Key]
    public required int Id { get; set; } // Идентификатор записи
    public required int InventoryNumber { get; set; } // Инвентарный номер книги
    public required int DepartmentId { get; set; } // Идентификатор отдела
    public required int Quantity { get; set; } // Количество книг
}