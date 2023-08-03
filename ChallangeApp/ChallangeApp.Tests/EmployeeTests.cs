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
        public void WhenEmployeeCollectNewGrades_ShouldReturnCorrectGradeInLatter()
        {
            //Arrange
            var employee1 = new Employee("John", "Shepard");
            employee1.AddGrade(7);
            employee1.AddGrade(2);
            employee1.AddGrade(6);
            //Act
            var statistics = employee1.GetStatistics();
            //Assert
            Assert.AreEqual('E', statistics.AvargeLatter);
        }

        [Test]
        public void WhenEmployeeCollectNewGradesLatters_ShouldReturnCorrectGradeInLatter()
        {
             //Arrange
             var employee2 = new Employee("Sven", "Amber");
             employee2.AddGrade(7);
             employee2.AddGrade('C');
             employee2.AddGrade('B');
             //Act
             var statistics = employee2.GetStatistics();
             //Assert
             Assert.AreEqual('C', statistics.AvargeLatter);
        }
    }

    
}

