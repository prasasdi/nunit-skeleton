using CustomClassLibrary;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            // assign

            // act

            // assert
            Assert.AreEqual(0, CustomSolution.Foo(10));
            
            //Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            // assign

            // act

            // assert
            Assert.AreEqual(0, 10 % 2);

            //Assert.Pass();
        }
    }
}