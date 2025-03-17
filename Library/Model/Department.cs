using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Model;

public class Department
{
    [Key]
    public required int Id { get; set; } // Идентификатор отдела
    public required string Name { get; set; } // Название отдела
}