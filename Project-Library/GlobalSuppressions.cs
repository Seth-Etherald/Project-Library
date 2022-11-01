// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Minor Code Smell",
    "S3251:Implementations should be provided for \"partial\" methods",
    Justification = "Currently unnecessary to implement any method.",
    Scope = "member",
    Target = "~M:Project_Library.Models.LibraryManagementContext.OnModelCreatingPartial(Microsoft.EntityFrameworkCore.ModelBuilder)")]