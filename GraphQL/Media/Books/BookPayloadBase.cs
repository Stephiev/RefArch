using System.Collections.Generic;
using LibrarySystem.GraphQL.Common;
using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL.Media.Books
{
    public class BookPayloadBase : Payload
    {
        protected BookPayloadBase(Book book)
        {
            Book = book;
        }

        protected BookPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Book? Book { get; }
    }
}