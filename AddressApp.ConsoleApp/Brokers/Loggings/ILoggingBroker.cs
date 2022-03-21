// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;

namespace AddressApp.ConsoleApp.Brokers.Loggings
{
    internal interface ILoggingBroker
    {
        void LogError(Exception exception);
    }
}
