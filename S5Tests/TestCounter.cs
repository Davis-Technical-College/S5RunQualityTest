using S5RunQualityTest;
using S5RunQualityTest.Pages;
namespace S5Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAccumulator()
        {
            //Test value to increment the accumulator
            int incremtedValue = 5;
            //Arrange
            var ctx = new Counter();
            
            //get the current value of the accumulator
            int currentAccumulator = ctx.accumulator;
            //Act
            int returnedValue = ctx.UpdateAccumulator(incremtedValue);
            int expectedValue = currentAccumulator + incremtedValue;
            //Assert
            Assert.True(returnedValue == expectedValue);
        }
    }
}