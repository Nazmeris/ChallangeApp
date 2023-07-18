namespace ChallangeApp
{
    public class User
    {
        private List<int> score = new List<int>();

        public User(string name)
        {
            this.Name = name;

        }

        public string Name { get; private set; }
        
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
        public void SubtractScore(int number)
        {
            this.score.Add(-number);
        }
    }
}
