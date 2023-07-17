namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectScores_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "asddas324", "29");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(7);
            

            // act
            var result = user.Result;


            // assert
            Assert.AreEqual(18, result);

        }
        [Test]
        public void WhenUserSubtrackScores_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "asddas324", "29");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(7);
            user.SubtractScore(3);
            user.SubtractScore(2);

            // act
            var result = user.Result;


            // assert
            Assert.AreEqual(13, result);

        }

    }
}