using NUnit.Framework;
using SharedLibrary;
using System.Reflection;

namespace TestProjectWithoutInternals
{
    [TestFixture]
    public class TestClassWithoutAccess
    {
        [Test]
        public void CallingPublicMethodFromProjectWithoutAccess()
        {
            // Arrange
            var sut = new ClassWithMethods();

            // Act
            var greeting = sut.PublicMethod("human");

            // Assert
            Assert.AreEqual(greeting, "Hello human");
        }

        [Test]
        public void CallingInternalMethodFromProjectWithoutAccess()
        {
            // Arrange
            var sut = new ClassWithMethods();
            
            // var greeting = sut.InternalMethod("human");
            // Doesn't compile, because InternalMethod is not
            // accessible here. Instead, we could use reflection:

            BindingFlags bf = BindingFlags.NonPublic | BindingFlags.Instance;
            MethodInfo mi = sut.GetType().GetMethod("InternalMethod", bf);

            // Act
            var result = (string)mi.Invoke(sut, new object[] { "human" });

            // Assert
            Assert.AreEqual(result, "Howdy human");
        }
    }
}
