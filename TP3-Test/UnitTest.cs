using Xunit;
using TP3_Logic;

namespace TP3_Test
{
    public class UnitTest
    {

        [Fact]
        public void Exercise3_ShouldThrowException()
        {
            // Arrange
            var logic = new Logic();

            // Act & Assert
            Assert.Throws<Exception>(() => logic.Exercise3());
        }

        [Fact]
        public void DivisionByZero()
        {
            // Arrange
            double dividend = 10;
            double divider = 0;

            // Act
            string result = dividend.DivisionBy(divider);

            // Assert
            Assert.Equal("Solo Goku divide por cero!", result);
        }
    }
}