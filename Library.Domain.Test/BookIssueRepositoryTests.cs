using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Model;
using Library.Domain.Services.InMemory;
using Xunit;

namespace Library.Domain.Tests
{
    public class BookIssueRepositoryTests
    {
        [Fact]
        public async Task GetIssuedBooksOrderedByTitle_Success()
        {
            var repo = new BookIssueInMemoryRepository();
            var issuedBooks = await repo.GetIssuedBooksOrderedByTitle();

            Assert.NotNull(issuedBooks);
            Assert.True(issuedBooks.Count > 0);
        }

        [Fact]
        public async Task GetTop5ReadersByPeriod_Success()
        {
            var repo = new BookIssueInMemoryRepository();
            var topReaders = await repo.GetTop5ReadersByPeriod(new DateTime(2023, 1, 1), new DateTime(2023, 12, 31));

            Assert.NotNull(topReaders);
            Assert.True(topReaders.Count <= 5);
        }

        [Fact]
        public async Task GetReadersWithDelayedBooks_Success()
        {
            var repo = new BookIssueInMemoryRepository();
            var readersWithDelays = await repo.GetReadersWithDelayedBooks();

            Assert.NotNull(readersWithDelays);
        }
    }
}