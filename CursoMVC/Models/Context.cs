﻿using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-T2KJ082;Database=CursoMVC;Integrated Security=True;  TrustServerCertificate=True");
        }

    }
}
