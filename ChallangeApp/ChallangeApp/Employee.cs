using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ChallangeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee()
        { }
        public Employee(string name,string surname, int age)
            : base(name, surname, age)
        {
        }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrade(char grade)
        {
            switch(grade)
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

        public void AddGrade(string grade)
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
        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade((float)result);
        }
        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade((float)result);
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade((float)result);
        }
        public Statistics GetStatistics()
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
