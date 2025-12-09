using Microsoft.EntityFrameworkCore;
using InvoicePro.Data;

var builder = new DbContextOptionsBuilder<InvoiceProDbContext>();

builder.UseSqlServer("Server=localhost;Database=InvoiceProDb;Trusted_Connection=True;TrustServerCertificate=True;");

// creating an instance
using var db = new InvoiceProDbContext(builder.Options);

Console.WriteLine("Database connection successful!");
