// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Models.Address;
using System.Collections.Generic;

namespace AddressApp.ConsoleApp.Brokers.Storages
{
    public partial class StorageBroker : IStorageBroker
    {
        List<Address> Addresses = new List<Address>();

        public Address InsertAddress(Address Address)
        {
            Addresses.Add(Address);

            return Address;
        }
    }
}

