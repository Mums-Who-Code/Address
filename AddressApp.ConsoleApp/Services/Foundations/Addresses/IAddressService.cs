// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using AddressApp.ConsoleApp.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp.ConsoleApp.Services.Foundations.Addresses
{
    public interface IAddressService
    {
       Address AddAddress(Address address);    
    }
}
