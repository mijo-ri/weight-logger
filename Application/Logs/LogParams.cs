namespace Application.Logs
{
    public class LogParams
    {
        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
    }
}
