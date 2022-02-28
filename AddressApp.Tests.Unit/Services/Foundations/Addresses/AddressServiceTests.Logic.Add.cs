// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Models.Address;
using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Xunit;

namespace AddressApp.Tests.Unit.Services.Foundations.Addresses
{
    public partial class AddressServiceTests
    {


        [Fact]
        public void ShouldAddAddress()
        {
            //given
            Address randomAddress = CreateRandomAddress();
            Address inputAddress = randomAddress;
            Address persistedAddress = inputAddress;
            Address expectedAddress = persistedAddress.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                  broker.InsertAddress(inputAddress))
                       .Returns(persistedAddress);

            //when
            Address actualAddress = this.addressservice.AddAddress(inputAddress);

            //then
            actualAddress.Should().BeEquivalentTo(inputAddress);

            this.storageBrokerMock.Verify(broker =>
                 broker.InsertAddress(inputAddress),
                      Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
