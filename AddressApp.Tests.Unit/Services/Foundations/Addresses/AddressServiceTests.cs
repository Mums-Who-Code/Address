    // ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Brokers.Storages;
using AddressApp.ConsoleApp.Models.Address;
using AddressApp.ConsoleApp.Services.Foundations.Addresses;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tynamix.ObjectFiller;

namespace AddressApp.Tests.Unit.Services.Foundations.Addresses
{
    public partial class AddressServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IAddressService addressservice;

        public AddressServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.addressservice = new AddressService(
               storageBroker: this.storageBrokerMock.Object);
        }

        private static Address CreateRandomAddress() =>
                CreateAddressFiller().Create();
        
        private static Filler<Address> CreateAddressFiller() =>
          new Filler<Address>();
    }
}
