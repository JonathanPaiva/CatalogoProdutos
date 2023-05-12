﻿using CatalogoProdutosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CatalogoProdutosAPI.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Categoria>? Categorias { get; set; }
        
        public DbSet<Produto>? Produtos { get; set; }
        
    }
}
