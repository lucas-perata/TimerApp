namespace TimerApp.Entity
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public required int Minutes { get; set; }
        public required Category Category { get; set; }
        public required DateTime DateTime { get; set; } = DateTime.UtcNow;

    }

    public enum Category
    {
        Study,// 0
        Work, // 1
        Programming, // 2
        Exercise, // 3
        Meditation, // 4
        Reading // 5
    }
}
