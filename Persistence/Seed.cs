using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any() && !context.Logs.Any())
            {
                // Seed users
                var users = new List<AppUser>
                {
                    new AppUser { DisplayName = "Migi", UserName = "migi", Email = "michi.rieser@gmail.com" },
                    new AppUser { DisplayName = "Lea", UserName = "lea", Email = "lea.glaettli@bluewin.ch" }
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Qwer1234!");
                }

                // Seed logs
                var logs = new List<Log>
                {
                    new Log { Date = new DateOnly(2023, 7, 17), Weight = 90.6f, AppUser = users[0] },
                    new Log { Date = new DateOnly(2023, 7, 18), Weight = 90.3f, AppUser = users[0] },
                    new Log { Date = new DateOnly(2023, 7, 19), Weight = 90.4f, AppUser = users[0] },
                    new Log { Date = new DateOnly(2023, 7, 20), Weight = 89.7f, AppUser = users[0] },
                    new Log { Date = new DateOnly(2023, 7, 21), Weight = 90.1f, AppUser = users[0] },
                    new Log { Date = new DateOnly(2023, 7, 24), Weight = 90.3f, AppUser = users[0] },
                    new Log { Date = new DateOnly(2023, 7, 23), Weight = 56.2f, AppUser = users[1] },
                    new Log { Date = new DateOnly(2023, 7, 24), Weight = 56.1f, AppUser = users[1] },
                };

                // Add the logs to the context
                await context.Logs.AddRangeAsync(logs);

                // Save the changes
                await context.SaveChangesAsync();
            }
        }
    }
}
