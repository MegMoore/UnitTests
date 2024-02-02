using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Tests.PingTest
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        public NetworkServiceTests()
        {
            //SUT
            _pingService = new NetworkService();
        }
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange - varibales, classes, mocks            
         

            //Act
            var result = _pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent!");
            result.Should().Contain("Success", Exactly.Once());
            
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            

            //Act
            var result = _pingService.PingTimeout(a, b);

            //Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(a - 1000, 0);
        }
    
}
