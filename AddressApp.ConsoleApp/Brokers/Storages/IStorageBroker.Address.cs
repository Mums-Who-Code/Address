// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Models.Address;

namespace AddressApp.ConsoleApp.Brokers.Storages
{
    partial interface IStorageBroker
    {
        Address InsertAddress(Address Address);
    }
}
