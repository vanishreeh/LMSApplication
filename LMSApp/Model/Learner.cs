namespace LMSApp.Model
{
    public class Learner
    {
        public int LearnerId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Course { get; set; } = string.Empty;

        public int Age { get; set; }
    }
}
