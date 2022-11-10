﻿using Project_Library.Models;

namespace Project_Library.Logics
{
    internal static class LibrarianManager
    {
        public static List<Librarian> GetLibrarians()
        {
            using var context = new LibraryManagementContext();
            return context.Librarians.ToList();
        }

        public static Librarian? GetLibrarian(int librarianId)
        {
            using var context = new LibraryManagementContext();
            return context.Librarians.FirstOrDefault(x => x.LibrarianId == librarianId);
        }

        public static void AddLibrarian(Librarian data)
        {
            using var context = new LibraryManagementContext();
            context.Librarians.Add(data);
            context.SaveChanges();
        }

        public static void UpdateLibrarian(Librarian data)
        {
            using var context = new LibraryManagementContext();
            context.Librarians.Update(data);
            context.SaveChanges();
        }

        public static void DeleteLibrarian(Librarian data)
        {
            using var context = new LibraryManagementContext();
            context.Librarians.Remove(data);
            context.SaveChanges();
        }
    }
}