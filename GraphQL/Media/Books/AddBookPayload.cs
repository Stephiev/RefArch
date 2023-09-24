using System.Collections.Generic;
using LibrarySystem.GraphQL.Common;
using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL.Media.Books
{
    public class AddBookPayload : BookPayloadBase
    {
        public AddBookPayload(Book speaker)
            : base(speaker)
        {
        }

        public AddBookPayload(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }
    }
}