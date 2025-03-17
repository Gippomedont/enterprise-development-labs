using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

public class Reader
{
    [Key]
    public required int Id { get; set; } // Идентификатор читателя
    public required string FullName { get; set; } // ФИО
    public required string Address { get; set; } // Адрес
    public required string Phone { get; set; } // Телефон
    public required DateTime RegistrationDate { get; set; } // Дата регистрации
}