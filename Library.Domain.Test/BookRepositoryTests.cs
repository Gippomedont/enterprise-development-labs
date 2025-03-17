using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Model;
using Library.Domain.Services.InMemory;
using Xunit;

namespace Library.Domain.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public async Task GetBookByCatalogCode_Success()
        {
            var repo = new BookInMemoryRepository();
            var book = await repo.GetByCatalogCode("A123");

            Assert.NotNull(book);
            Assert.Equal("Основы SQL", book?.Title);
        }

        [Fact]
        public async Task GetBookAvailability_Success()
        {
            var repo = new BookInMemoryRepository();
            var availability = await repo.GetBookAvailability(1);

            Assert.NotNull(availability);
            Assert.True(availability.Count > 0);
        }

        [Fact]
        public async Task GetBooksCountByPublicationType_Success()
        {
            var repo = new BookInMemoryRepository();
            var counts = await repo.GetBooksCountByPublicationType();

            Assert.NotNull(counts);
            Assert.True(counts.Count > 0);
        }
    }
}