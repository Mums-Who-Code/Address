// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Models.Address;

namespace AddressApp.ConsoleApp.Services.Foundations.Addresses
{
    public interface IAddressService
    {
        Address AddAddress(Address address);
    }
}
