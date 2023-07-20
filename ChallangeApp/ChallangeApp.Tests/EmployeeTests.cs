using System.Security.Cryptography.X509Certificates;

namespace ChallangeApp
{ 
    public class EmployeeTests
    {

        string employeeName = "John";
        string employeeSurname = "Shepard";

        Employee employee2 = new Employee("Miranda", "Lawson");
        Employee employee1 = new Employee("John", "Shepard");


        public Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }

        

        [Test]
        public void GetEmployeesNameAndSurname()
        {

            //Arrange
            var employee1 = GetEmployee(employeeName, employeeSurname);

            //Assert
            Assert.AreEqual(employeeName, employee1.Name);
            Assert.AreEqual(employeeSurname, employee1.Surname);

        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectSumAsResult()
        {

            //Arrange            
            employee1.AddGrade(7);
            employee1.AddGrade(2);
            employee1.AddGrade(6);

            employee2.AddGrade(6);
            employee2.AddGrade(3);
            employee2.AddGrade(9);

            //Act
            var statistics2 = employee2.GetStatistics();
            var statistics1 = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(15, statistics1.Sum);
            Assert.AreEqual(18, statistics2.Sum);

        }

        [Test]
        public void WhenEmployeeCollectNewGrades_ShouldReturnCorrectMinMaxUsingGetStatistics()
        {

            //Arrange            
            employee1.AddGrade(7);
            employee1.AddGrade(2);
            employee1.AddGrade(6);

            employee2.AddGrade(6);
            employee2.AddGrade(3);
            employee2.AddGrade(9);

            //Act
            var statistics2 = employee2.GetStatistics();
            var statistics1 = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(9, statistics2.Max);
            Assert.AreEqual(3, statistics2.Min);
            Assert.AreEqual(7, statistics1.Max);
            Assert.AreEqual(2, statistics1.Min);

        }

        [Test]
        public void WhenEmployeeCollectNewGrades_ShouldReturnCorrectAvargeUsingGetStatistics()
        {

            //Arrange            


            employee1.AddGrade(7);
            employee1.AddGrade(2);
            employee1.AddGrade(6);

            employee2.AddGrade(6);
            employee2.AddGrade(3);
            employee2.AddGrade(9);


            //Act
            var statistics2 = employee2.GetStatistics();
            var statistics1 = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(5, statistics1.Avarge);
            Assert.AreEqual(6, statistics2.Avarge);
            

        }
    }

    
}

