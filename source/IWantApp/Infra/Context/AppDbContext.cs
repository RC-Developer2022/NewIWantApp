﻿using Flunt.Notifications;
using IWantApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IWantApp.Infra.Context;

public class AppDbContext : DbContext
{
    DbSet<Category> Categories { get; set; }
    DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Ignore<Notification>();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
