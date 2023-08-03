using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee()
        {
        }
        public Employee(string name,string surname )
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; } 
        public string Surname { get; private set; }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(char grade)
        {
            //if (grade == 'S')
            //{
            //    this.grades.Add(100);
            //}
            //else if (grade == 'A')
            //{
            //    this.grades.Add(80);
            //}
            //else if (grade == 'B')
            //{
            //    this.grades.Add(60);
            //}
            //else if (grade == 'C')
            //{
            //    this.grades.Add(40);
            //}
            //else if (grade == 'D')
            //{
            //    this.grades.Add(20);
            //}
            //else
            //    Console.WriteLine("Wrong Letter");


            switch(grade)
            {
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
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
            //var index = 0;

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
