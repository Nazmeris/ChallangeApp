namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfScores_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "asddas324", "29");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;


            // assert
            Assert.AreEqual(11, result);

        }

    }
}