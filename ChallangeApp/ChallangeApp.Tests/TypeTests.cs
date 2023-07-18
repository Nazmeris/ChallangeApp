namespace ChallangeApp
{
    public class TypeTests
    {
        [Test]
        public void NumbersAreNotEqueal()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;
            // act
            // assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void FloatsAreEqueal()
        {
            // arrange
            float number3 = 134.2f;
            float number4 = 134.2f;
            // act
            // assert            
            Assert.AreEqual(number3, number4);
        }
        [Test]
        public void doubleAreEqueal()
        {
            // arrange
            double number1 = 134.2;
            double number2 = 134.2;            
            // act
            // assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void UsersAreDifferent()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Tomasz");
            // act
            // assert
            Assert.AreNotEqual(user1, user2);

        }
      
        [Test]
        public void StringAreTheSame()
        {
            // arrange
            string nam1 = ("Ewa");
            string nam2 = ("Ewa");
            // act
            // assert
            Assert.AreEqual(nam1, nam2);

        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}

