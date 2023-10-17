//namespace ChallangeApp
//{
//    public class Supervisor : IEmployee
//    { 
    
//        private List<float> grades = new List<float>();

//        public Supervisor() 
//        { }

//        public Supervisor(string name, string surname)
//        {
//            this.Name = name;
//            this.Surname = surname;
//        }
//        public string Name { get; private set; }
//        public string Surname { get; private set; }

//        public void AddGrade(string grade)
//        {
//            switch (grade)
//            {
//                case "6":
//                    this.grades.Add(100);
//                    break;
//                case "-6":
//                case "6-":
//                    this.grades.Add(95);
//                    break;
//                case "+5":
//                case "5+":
//                    this.grades.Add(85);
//                    break;
//                case "5":
//                    this.grades.Add(80);
//                    break;
//                case "-5":
//                case "5-":
//                    this.grades.Add(75);
//                    break;
//                case "+4":
//                case "4+":
//                    this.grades.Add(65);
//                    break;
//                case "4":
//                    this.grades.Add(60);
//                    break;
//                case "-4":
//                case "4-":
//                    this.grades.Add(55);
//                    break;
//                case "+3":
//                case "3+":
//                    this.grades.Add(45);
//                    break;
//                case "3":
//                    this.grades.Add(40);
//                    break;
//                case "-3":
//                case "3-":
//                    this.grades.Add(35);
//                    break;
//                case "+2":
//                case "2+":
//                    this.grades.Add(25);
//                    break;
//                case "2":
//                    this.grades.Add(20);
//                    break;
//                case "-2":
//                case "2-":
//                    this.grades.Add(15);
//                    break;
//                case "+1":
//                case "1+":
//                    this.grades.Add(5);
//                    break;
//                case "1":
//                    this.grades.Add(0);
//                    break;
//                default:
//                    throw new Exception("Wrong grade");
//            }
//            //if (float.TryParse(grade, out float result))
//            //{
//            //    this.AddGrade(result);
//            //}
//            //else if (grade.Length == 1)
//            //{
//            //    char.TryParse(grade, result: out char result1);
//            //    this.AddGrade(result1);
//            //}
//            //else
//            //{
//            //    throw new Exception("String is not float");
//            //}
//        }


//        public void AddGrade(float grade)
//        {
//            if (grade >= 0 && grade <= 100)
//            {
//                this.grades.Add(grade);
//            }
//            else
//            {
//                throw new Exception("invalid grade value");
//            }
//        }

//        public void AddGrade(char grade)
//        {
//            switch (grade)
//            {
//                case 'A':
//                case 'a':
//                    this.grades.Add(100);
//                    break;
//                case 'B':
//                case 'b':
//                    this.grades.Add(80);
//                    break;
//                case 'C':
//                case 'c':
//                    this.grades.Add(60);
//                    break;
//                case 'D':
//                case 'd':
//                    this.grades.Add(40);
//                    break;
//                case 'E':
//                case 'e':
//                    this.grades.Add(20);
//                    break;
//                default:
//                    throw new Exception("Wrong Latter");
//            }
//        }
       
//        public void AddGrade(int grade)
//        {
//            float result = (float)grade;
//            this.AddGrade((float)result);
//        }
//        public void AddGrade(long grade)
//        {
//            float result = (float)grade;
//            this.AddGrade((float)result);
//        }
//        public void AddGrade(double grade)
//        {
//            float result = (float)grade;
//            this.AddGrade((float)result);
//        }
//        public Statistics GetStatistics()
//        {
//            var statistics = new Statistics();
//            statistics.Avarge = 0;
//            statistics.Max = float.MinValue;
//            statistics.Min = float.MaxValue;
//            statistics.Sum = 0;


//            foreach (var grade in this.grades)
//            {
//                statistics.Max = Math.Max(statistics.Max, grade);
//                statistics.Min = Math.Min(statistics.Min, grade);
//                statistics.Avarge += grade;
//                statistics.Sum += grade;
//            }

//            statistics.Avarge /= this.grades.Count;

//            switch (statistics.Avarge)
//            {
//                case var avarge when avarge >= 80:
//                    statistics.AvargeLatter = 'A';
//                    break;
//                case var avarge when avarge >= 60:
//                    statistics.AvargeLatter = 'B';
//                    break;
//                case var avarge when avarge >= 40:
//                    statistics.AvargeLatter = 'C';
//                    break;
//                case var avarge when avarge >= 20:
//                    statistics.AvargeLatter = 'D';
//                    break;
//                default:
//                    statistics.AvargeLatter = 'E';
//                    break;

//            }

//            return statistics;
//        }
//    }
//}



