using ChallangeApp;
using System.Reflection.Metadata;

User user1 = new User("Adam", "Adamowicz", "40");
User user2 = new User("Ewa", "Adamowicz", "38");
User user3 = new User("Ada", "Adamowicz", "26");

user1.AddScore(7);
user1.AddScore(8);
user1.AddScore(5);
user1.AddScore(4);
user1.AddScore(9);

user2.AddScore(9);
user2.AddScore(4);
user2.AddScore(1);
user2.AddScore(10);
user2.AddScore(10);

user3.AddScore(3);
user3.AddScore(5);
user3.AddScore(8);
user3.AddScore(5);
user3.AddScore(9);

List<User> users = new List<User>()
{
    user1, user2, user3
};

int maxResult = -1;
User? userWithMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWithMaxResult = user;
        maxResult = user.Result;
    }
}


Console.WriteLine("Najwyższą liczbę ocen otrzymała -" + " " + userWithMaxResult.Name + " " + userWithMaxResult.Surname + " " + userWithMaxResult.Age +
                 " " + "lat z wynikiem" + " " + userWithMaxResult.Result + " " + "punktów.");
