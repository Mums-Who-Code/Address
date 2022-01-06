// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Collections.Generic;
using AddressApp.ConsoleApp.Models.Address;

namespace AddressApp.ConsoleApp.Brokers.Storages
{
    partial class StorageBroker : IStorageBroker
    {
       List<Address> Addresses = new List<Address>();

       public Address InsertAddress(Address Address)
        {
           Addresses.Add(Address);

            return Address;
        }
    }
}

