// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Models.Address;

namespace AddressApp.ConsoleApp.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        Address InsertAddress(Address Address);
    }
}
