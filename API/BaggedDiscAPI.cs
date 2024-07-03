﻿using DiscGoAPI.Models;

namespace DiscGoAPI.API
{
    public class BaggedDiscAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/baggedDiscs/{bagId}", (DiscGoAPIDbContext db, int bagId) =>
            {
                var baggedDiscs = db.BaggedDiscs.Where(d => d.BagId == bagId);
                if (baggedDiscs.Any())
                {
                    return Results.Ok(baggedDiscs);
                }
                else
                {
                    return Results.NotFound("");
                }
            });

            app.MapGet("/baggedDiscs/discInfo", (DiscGoAPIDbContext db, int Id) =>
            {
                var singleDisc = db.BaggedDiscs.FirstOrDefault(d => d.Id == Id);
                if (singleDisc != null)
                {
                    return Results.Ok(singleDisc);
                }else
                {
                    return Results.NotFound("");
                }
            });

            app.MapPost("/baggedDiscs", (DiscGoAPIDbContext db, BaggedDisc discToAdd) =>
            {
                db.BaggedDiscs.Add(discToAdd);
                db.SaveChanges();
                return Results.Created($"/baggedDiscs/{discToAdd.Id}", discToAdd);
            });

            app.MapPut("/baggedDiscs/{baggedDiscId}", (DiscGoAPIDbContext db, int baggedDiscId, BaggedDisc updatedDisc) =>
            {
                var discToUpdate = db.BaggedDiscs.FirstOrDefault(d => d.Id == baggedDiscId);
                if (discToUpdate != null)
                {
                    discToUpdate.Birdies = updatedDisc.Birdies;
                    discToUpdate.Aces = updatedDisc.Aces;
                    db.SaveChanges();
                    return Results.Created($"/baggedDiscs/{discToUpdate.Id}", updatedDisc);
                }
                else
                {
                    return Results.NotFound("");
                }
            });

            app.MapDelete("/baggedDiscs/{baggedDiscId}", (DiscGoAPIDbContext db, int baggedDiscId) =>
            {
                var discToDelete = db.BaggedDiscs.FirstOrDefault(d => d.Id == baggedDiscId);
                if(discToDelete != null)
                {
                    db.BaggedDiscs.Remove(discToDelete);
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
