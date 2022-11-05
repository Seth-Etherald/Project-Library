﻿using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class BookInfoManager
    {
        public static List<BookInfo> GetBookInfos()
        {
            using var context = new LibraryManagementContext();
            return context.BookInfos.ToList();
        }

        public static List<BookInfo> GetBookInfos(int titleId)
        {
            using var context = new LibraryManagementContext();
            return context.BookInfos.Where(x => x.TitleId == titleId).ToList();
        }

        public static BookInfo? GetBookInfo(int titleId)
        {
            using var context = new LibraryManagementContext();
            return context.BookInfos.FirstOrDefault(x => x.TitleId == titleId);
        }

        public static BookInfo? GetBookInfo(string title)
        {
            using var context = new LibraryManagementContext();
            return context.BookInfos.FirstOrDefault(x => x.Title.ToUpper() == title.ToUpper());
        }

        public static void AddBookInfo(BookInfo data)
        {
            using var context = new LibraryManagementContext();
            context.BookInfos.Add(data);
            context.SaveChanges();
        }

        public static void UpdateBookInfo(BookInfo data)
        {
            using var context = new LibraryManagementContext();
            context.BookInfos.Update(data);
            context.SaveChanges();
        }

        public static void DeleteBookInfo(List<BookInfo> data)
        {
            using var context = new LibraryManagementContext();
            context.BookInfos.RemoveRange(data);
            context.SaveChanges();
        }
    }
}