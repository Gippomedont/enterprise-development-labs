using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

public class BookIssue
{
    [Key]
    public required int Id { get; set; } // Идентификатор выдачи
    public required int InventoryNumber { get; set; } // Инвентарный номер книги
    public required int ReaderId { get; set; } // Идентификатор читателя
    public required DateTime IssueDate { get; set; } // Дата выдачи
    public required int DaysIssued { get; set; } // Количество дней на выдачу
    public DateTime? ReturnDate { get; set; } // Дата возврата

    // Навигационное свойство для связи с книгой
    public Book? Book { get; set; }
}