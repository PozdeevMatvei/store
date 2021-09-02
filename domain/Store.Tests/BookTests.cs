using System;
using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithSpace_ReturnFalse()
        {
            bool actual = Book.IsIsbn("   ");

            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithInvlaidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 123-234-442 0");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn13_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 123-123-44-44-125");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTreshStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxx Isbn 123-444-555-4 xaa");

            Assert.False(actual);
        }
    }
}
