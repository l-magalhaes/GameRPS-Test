using System;
using System.Collections.Generic;
using System.Text;

namespace RPSTest.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError() : base("No Such Strategy Error") { }
        public NoSuchStrategyError(string message) : base(message) { }
        public NoSuchStrategyError(string message, System.Exception inner) : base(message, inner) { }
    }
}
