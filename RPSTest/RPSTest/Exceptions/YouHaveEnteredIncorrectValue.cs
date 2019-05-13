using System;
using System.Collections.Generic;
using System.Text;

namespace RPSTest.Exceptions
{
    public class YouHaveEnteredIncorrectValue : Exception
    {
        public YouHaveEnteredIncorrectValue() : base("No Such Strategy Error") { }
        public YouHaveEnteredIncorrectValue(string message) : base(message) { }
        public YouHaveEnteredIncorrectValue(string message, System.Exception inner) : base(message, inner) { }
    }
}
