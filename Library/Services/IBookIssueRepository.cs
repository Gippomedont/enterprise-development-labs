using Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Domain.Services;

public interface IBookIssueRepository
{
    Task<IList<BookIssue>> GetAll();
    Task<BookIssue?> GetById(int id);
    Task<BookIssue> Add(BookIssue bookIssue);
    Task<BookIssue> Update(BookIssue bookIssue);
    Task<bool> Delete(int id);
    Task<IList<BookIssue>> GetIssuedBooksOrderedByTitle();
    Task<IList<Reader>> GetTop5ReadersByPeriod(DateTime startDate, DateTime endDate);
    Task<IList<Reader>> GetReadersWithDelayedBooks();
}