namespace AssignmentManagementApp.Tests
{
    public class AssignmentTests
    {
        [Fact]
        public void Should_Have_A_Title()
        {
            var assignment = new Assignment
            {
                Title = "Default Title" // Set the required property to required
            };

            Assert.NotNull(assignment.Title);
        }
    }
}