// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Models.Address;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AddressApp.Tests.Unit.Services.Foundations.Addresses
{
    public partial class AddressServiceTests
    {
        private readonly Address persistedAddress;

        [Fact]
        public void ShouldAddAddress ()
        {
            //given
            Address randomAddress = CreateRandomAddress();
            Address inputAddress = randomAddress;
            Address expectAddress = inputAddress;
            Address expectedAddress = persistedAddress;

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
