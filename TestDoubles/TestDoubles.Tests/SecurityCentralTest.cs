using Moq;
using TestDoubles.Tests.Models;
using TestDoubles.Tests.Services;
using Xunit;

namespace TestDoubles.Tests
{
    public class SecurityCentralTest
    {
        [Fact]
        public void EnablingSecurityShouldCloseWindowAndDoor()
        {
            var windowMock = new Mock<Window>();
            var doorMock = new Mock<Door>();
            SecurityCentral securityCentral = new SecurityCentral(windowMock.Object, doorMock.Object);

            securityCentral.SecurityOn();

            windowMock.Verify(x => x.Close());
            doorMock.Verify(x => x.Close());
        }
    }
}
