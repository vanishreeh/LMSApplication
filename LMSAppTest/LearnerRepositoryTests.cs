using LMSApp.Repository;

namespace LMSAppTest
{
    public class LearnerRepositoryTests
    {
        [Fact]
        
        public void Constructor_ShouldCreateNewListWithDefaultLearners()
        {
            // Arrange
            LearnerRepository repo1 = new LearnerRepository();

            LearnerRepository repo2 = new LearnerRepository();

            // Act
            var learners1 = repo1.GetAll();
            var learners2 = repo2.GetAll();

            // Assert
            Assert.NotNull(learners1);
            Assert.NotNull(learners2);

            // Both lists should contain 3 default learners
            Assert.Equal(3, learners1.Count);
            Assert.Equal(3, learners2.Count);

            // Both should be different List objects
            Assert.NotSame(learners1, learners2);
        }
    }
}
