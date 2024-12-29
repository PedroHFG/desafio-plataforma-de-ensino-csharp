namespace Course.Entities
{
    internal class Task : Lesson
    {
        public string Description { get; set; }
        public int QuestionCount { get; set; }

        public Task()
        {

        }

        public Task(string title, string description, int questionCount) : base(title)
        {
            Description = description;
            QuestionCount = questionCount;
        }

        public override int Duration()
        {
            return QuestionCount * 5 * 60;
        }
    }
}
