﻿using System;
using JWTAuthenticationAspNetCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthenticationAspNetCore.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
