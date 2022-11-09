using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class ReturnBookManager
    {
        public static void ReturnBook(ReturnBookModel data, int librarianId, int condition)
        {
            using var context = new LibraryManagementContext();
            LendBookDetail? lendDetail = LendBookManager.GetLendBookDetail(data.TicketId);
            Book? returnBook = BookManager.GetBook(data.BookId);

            ReturnBook general = new()
            {
                CardNumber = data.ReaderCard,
                LibrarianId = librarianId,
                ReturnDate = DateTime.Now
            };

            ReturnBookDetail detail = new()
            {
                BookId = data.BookId,
                ReturnCondition = condition
            };

            general.ReturnBookDetails.Add(detail);
            context.ReturnBooks.Add(general);

            if (lendDetail != null) context.LendBookDetails.Remove(lendDetail);

            if (returnBook != null)
            {
                BookInfo? returnBookInfo = BookInfoManager.GetBookInfo(returnBook.TitleId);
                if (returnBookInfo != null && condition != 3)
                {
                    returnBook.Condition = condition;
                    BookManager.UpdateBook(returnBook);

                    returnBookInfo.InStock += 1;
                    context.BookInfos.Update(returnBookInfo);
                }
            }

            context.SaveChanges();
        }
    }
}