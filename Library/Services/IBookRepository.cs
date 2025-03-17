using Library.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Domain.Services;

public interface IBookRepository
{
    Task<IList<Book>> GetAll();
    Task<Book?> GetByInventoryNumber(int inventoryNumber);
    Task<Book?> GetByCatalogCode(string catalogCode);
    Task<Book> Add(Book book);
    Task<Book> Update(Book book);
    Task<bool> Delete(int inventoryNumber);
    Task<IList<BookInDepartment>> GetBookAvailability(int inventoryNumber);
    Task<IList<(string PublicationType, int Quantity)>> GetBooksCountByPublicationType();
}