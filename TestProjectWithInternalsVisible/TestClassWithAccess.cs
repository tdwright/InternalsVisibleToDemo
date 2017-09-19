using NUnit.Framework;
using SharedLibrary;

namespace TestProjectWithInternalsVisible
{
    [TestFixture]
    public class TestClassWithAccess
    {
        [Test]
        public void CallingPublicMethodFromProjectWithAccess()
        {
            // Arrange
            var sut = new ClassWithMethods();

            // Act
            var greeting = sut.PublicMethod("human");

            // Assert
            Assert.AreEqual(greeting, "Hello human");
        }

        [Test]
        public void CallingInternalMethodFromProjectWithAccess()
        {
            // Arrange
            var sut = new ClassWithMethods();

            // Act
            var greeting = sut.InternalMethod("human");

            // Assert
            Assert.AreEqual(greeting, "Howdy human");
        }
    }
}
