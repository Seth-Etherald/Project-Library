﻿using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class LendBookManager
    {
        public static void AddLendBook(LendBookDetail data, Book lendBook)
        {
            using var context = new LibraryManagementContext();
            BookInfo? bookInfo = BookInfoManager.GetBookInfo(lendBook.TitleId);
            if (bookInfo != null)
            {
                bookInfo.InStock -= 1;
                BookInfoManager.UpdateBookInfo(bookInfo);

                data.Books.Add(lendBook);
                context.LendBookDetails.Attach(data).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            lendBook.Condition = 3;
            context.Books.Update(lendBook);
            context.SaveChanges();
        }
    }
}