using DiscGoAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace DiscGoAPI.API
{
    public class BagAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/bags/usersBags/{userId}", (DiscGoAPIDbContext db, string userId) =>
            {
                var usersBags = db.Bags.Where(b => b.UserId == userId).ToList();
                if (usersBags.Count > 0)
                {
                    return Results.Ok(usersBags);
                }
                else
                {
                    return Results.NotFound("");
                }
            });

            app.MapGet("/bags/{bagId}", (DiscGoAPIDbContext db, int bagId) =>
            {
                var singleBag = db.Bags.Where(b => b.Id == bagId).ToList();
                if (!singleBag.Any())
                {
                    return Results.NotFound("");
                }
                else
                {
                    return Results.Ok(singleBag);
                }
            });

            app.MapPost("/bags", (DiscGoAPIDbContext db, Bag newBag) =>
            {
                db.Bags.Add(newBag);
                db.SaveChanges();
                return Results.Created($"/bags/{newBag.Id}", newBag);
            });

            app.MapPut("/bags/{bagId}", (DiscGoAPIDbContext db, int bagId, Bag updatedBag) =>
            {
                var bagToUpdate = db.Bags.FirstOrDefault(b => b.Id == bagId);
                if (bagToUpdate != null)
                {
                    bagToUpdate.BagName = updatedBag.BagName;
                    bagToUpdate.Favorite = updatedBag.Favorite;
                    db.SaveChanges();
                    return Results.Created($"/bags/{bagToUpdate.Id}", updatedBag);
                }
                else
                {
                    return Results.NotFound("");
                }
            });

            app.MapDelete("/bags/{bagId}", (DiscGoAPIDbContext db, int bagId) =>
            {
                var bagToDelete = db.Bags.FirstOrDefault(b => b.Id == bagId);
                if (bagToDelete != null)
                {
                    db.Remove(bagToDelete);
                    db.SaveChanges();
                    return Results.NoContent();
                }
                else
                {
                    return Results.NotFound("");
                }
            });
        }
    }
}
