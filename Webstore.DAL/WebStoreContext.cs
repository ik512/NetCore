﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;
using WebStore.DomainNew.Entities;

namespace Webstore.DAL
{
    public class WebStoreContext:DbContext
    {
        public WebStoreContext(DbContextOptions options ) :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
