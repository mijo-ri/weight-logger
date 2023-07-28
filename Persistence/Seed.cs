using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            // No seed needed if data already exist
            if (context.Logs.Any()) return;

            var logs = new List<Log>
            {
                new Log { Date = new DateOnly(2023, 7, 17), Weight = 90.6f },
                new Log { Date = new DateOnly(2023, 7, 18), Weight = 90.3f },
                new Log { Date = new DateOnly(2023, 7, 19), Weight = 90.4f },
                new Log { Date = new DateOnly(2023, 7, 20), Weight = 89.7f },
                new Log { Date = new DateOnly(2023, 7, 21), Weight = 90.1f },
                new Log { Date = new DateOnly(2023, 7, 24), Weight = 90.3f },
            };

            // Add the logs to the context
            await context.Logs.AddRangeAsync(logs);

            // Save the changes
            await context.SaveChangesAsync();
        }
    }
}
