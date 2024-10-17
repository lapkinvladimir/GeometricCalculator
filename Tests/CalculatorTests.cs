using ConsoleApp1;
namespace Tests

{
    public class CalculatorTests
    {
        [Test]
        public void TestAddition()
        {
            var calculator = new Calculator(5, 3, "+");
            Assert.AreEqual(8, calculator.Execute());
        }

        [Test]
        public void TestSubtraction()
        {
            var calculator = new Calculator(5, 3, "-");
            Assert.AreEqual(2, calculator.Execute());
        }

        [Test]
        public void TestMultiplication()
        {
            var calculator = new Calculator(5, 3, "*");
            Assert.AreEqual(15, calculator.Execute());
        }

        [Test]
        public void TestDivision()
        {
            var calculator = new Calculator(6, 3, "/");
            Assert.AreEqual(2, calculator.Execute());
        }
        
        [Test]
        public void TestDivisionByZero()
        {
            var calculator = new Calculator(6, 0, "/");
            Assert.Throws<DivideByZeroException>(() => calculator.Execute());
        }

        [Test]
        public void TestInvalidOperation()
        {
            var calculator = new Calculator(6, 3, "%");
            Assert.Throws<InvalidOperationException>(() => calculator.Execute());
        }

        [Test]
        public void TestAdditionNegativeNumbers()
        {
            var calculator = new Calculator(-5, -3, "+");
            Assert.AreEqual(-8, calculator.Execute());
        }

        [Test]
        public void TestSubtractionNegativeNumbers()
        {
            var calculator = new Calculator(-5, -3, "-");
            Assert.AreEqual(-2, calculator.Execute());
        }

        [Test]
        public void TestAdditionWithZero()
        {
            var calculator = new Calculator(5, 0, "+");
            Assert.AreEqual(5, calculator.Execute());
        }

        [Test]
        public void TestDivisionWithNegativeNumbers()
        {
            var calculator = new Calculator(-6, -3, "/");
            Assert.AreEqual(2, calculator.Execute());
        }

        [Test]
        public void TestDivisionWithDecimalNumbers()
        {
            var calculator = new Calculator(5.5, 2.5, "/");
            Assert.AreEqual(2.2, calculator.Execute());
        }
    }
}