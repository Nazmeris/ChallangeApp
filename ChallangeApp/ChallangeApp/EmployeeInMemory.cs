namespace ChallangeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade((float)result);
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade((float)result);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Latter");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                char.TryParse(grade, result: out char result1);
                this.AddGrade(result1);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade((float)result);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avarge = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Sum = 0;


            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarge += grade;
                statistics.Sum += grade;
            }

            statistics.Avarge /= this.grades.Count;

            switch (statistics.Avarge)
            {
                case var avarge when avarge >= 80:
                    statistics.AvargeLatter = 'A';
                    break;
                case var avarge when avarge >= 60:
                    statistics.AvargeLatter = 'B';
                    break;
                case var avarge when avarge >= 40:
                    statistics.AvargeLatter = 'C';
                    break;
                case var avarge when avarge >= 20:
                    statistics.AvargeLatter = 'D';
                    break;
                default:
                    statistics.AvargeLatter = 'E';
                    break;

            }

            return statistics;

        }
    }
}
