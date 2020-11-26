using System;
using System.Collections.Generic;
using Xunit;

namespace GreatBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void GetBookReturnsDifferentObjects(){
            var book1=GetBook("Book1");
            var book2=GetBook("Book2");
            Assert.Equal("",book1.name);
            Assert.Equal("",book2.name);


        }
        Book GetBook(String name)
        {
           return new Book(name);
        }
}
