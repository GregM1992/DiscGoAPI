using DiscGoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DiscGoAPI.API
{
    public class UserAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/users/{uid}", (DiscGoAPIDbContext db, string uid) => // get user by id
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == uid);

                if (user == null)
                {
                    return Results.NotFound("");
                }

                return Results.Ok(user);
            });

            app.MapGet("/checkuser/{uid}", (DiscGoAPIDbContext db, string uid) => // check for user
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == uid);

                if (user == null)
                {
                    return Results.NotFound("");
                }

                return Results.Ok(user);
            });

            app.MapPost("/users/register", (DiscGoAPIDbContext db, User newUser) => //register user
            {
                try
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    return Results.Created($"/users/{newUser.Id}", newUser);
                }
                catch (DbUpdateException)
                {
                    return Results.BadRequest("");
                }
            });

            app.MapPut("/users/{id}", (DiscGoAPIDbContext db, int id, User user) => // update user
            {
                var userBeingUpdated = db.Users.FirstOrDefault(u => u.Id == id);

                if (userBeingUpdated == null)
                {
                    return Results.NotFound("No user found");
                }

                userBeingUpdated.UserId = user.UserId;
                userBeingUpdated.UserName = user.UserName;
                userBeingUpdated.Email = user.Email;
                db.SaveChanges();
                return Results.Ok("User has been updated");
            });



        }
    }
}
