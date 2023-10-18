namespace ChallangeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            var grades = new List<float>();
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
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
            var grades = new List<float>();
            switch (grade)
            {
                case 'A':
                case 'a':
                    grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    grades.Add(20);
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
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
















