using DevConnect.Api.DevConnect.Domain.Entities;
using DevConnect.Api.DevConnect.Infrastructure.Data;
using DevConnect.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Api.Infrastructure.Data.Seed
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            context.Database.Migrate();

            if (!context.Users.Any())
            {
                var users = new List<User>
            {
                new User { Username = "john_doe", Email = "john@example.com" },
                new User { Username = "jane_smith", Email = "jane@example.com" },
            };

                context.Users.AddRange(users);
                context.SaveChanges();
            }

            if (!context.Posts.Any())
            {
                var user = context.Users.First(); // associate a post with a user
                var posts = new List<Post>
            {
                new Post { Title = "First Post", Body = "Hello world!", UserId = user.Id },
                new Post { Title = "Second Post", Body = "Another post", UserId = user.Id }
            };

                context.Posts.AddRange(posts);
                context.SaveChanges();
            }
        }
    }
}