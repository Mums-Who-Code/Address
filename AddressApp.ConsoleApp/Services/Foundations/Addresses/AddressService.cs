// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Brokers.Storages;
using AddressApp.ConsoleApp.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp.ConsoleApp.Services.Foundations.Addresses
{
    public class AddressService : IAddressService
    {
        private readonly IStorageBroker storageBroker;

        public AddressService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public Address AddAddress(Address address) =>
         throw new NotImplementedException();  
    }
}
