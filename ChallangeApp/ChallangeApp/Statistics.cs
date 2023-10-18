using System.ComponentModel;

namespace ChallangeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public char AvargeLatter 
        { 
            get
            {
                switch (this.Avarge)
                {
                    case var avarge when avarge >= 80:
                        return 'A';
                    case var avarge when avarge >= 60:
                        return 'B';
                    case var avarge when avarge >= 40:
                        return 'C';
                    case var avarge when avarge >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        public float Avarge 
        {
            get
            {
                return this.Sum / this.Count;            
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade; 
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }
    }
}
