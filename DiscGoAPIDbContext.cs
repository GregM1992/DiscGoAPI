using Microsoft.EntityFrameworkCore;
using DiscGoAPI.Models;
using System.Runtime.CompilerServices;

public class DiscGoAPIDbContext : DbContext
{

    public DbSet<Bag> Bags { get; set; }
    public DbSet<BaggedDisc> BaggedDiscs { get; set; }
    public DbSet<User> Users { get; set; }
    public DiscGoAPIDbContext(DbContextOptions<DiscGoAPIDbContext> context) : base(context)
    {



    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // seed data with campsite types
        modelBuilder.Entity<Bag>().HasData(new Bag[]
        {
        new Bag {Id = 1, BagName = "FavoriteBag", Favorite = true, UserId = "OTSAVyBcQ5R8N7OeGx6sHDr4RV53" },
        new Bag {Id = 2, UserId = "OTSAVyBcQ5R8N7OeGx6sHDr4RV53", BagName = "notFavorite",  Favorite = false },
        });
        modelBuilder.Entity<User>().HasData(new User[] {
        new User {Id = 1, Email = "myEmail.com", UserId = "OTSAVyBcQ5R8N7OeGx6sHDr4RV53", UserName = "discGuy32" },
        });
        modelBuilder.Entity<BaggedDisc>().HasData(new BaggedDisc[] {
            new BaggedDisc { Id = 2, DiscId = "hdye73-hfuye=3jdfuj", BagId = 1, Aces = 2, Birdies = 3, Brand = "axiom", Category = "putter", Color = "#343403", Fade = 3, Glide = 3, Name = "roc", Speed = 3, Stability = "over-stable", Turn = 3, Favorite = true },
        });

    }
}

