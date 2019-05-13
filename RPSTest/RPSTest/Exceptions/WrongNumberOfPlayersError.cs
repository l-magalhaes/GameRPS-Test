using System;
using System.Collections.Generic;
using System.Text;

namespace RPSTest.Exceptions
{
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError() : base("Wrong NumberOf Players Error") { }
        public WrongNumberOfPlayersError(string message) : base(message) { }
        public WrongNumberOfPlayersError(string message, System.Exception inner) : base(message, inner) { }
    }
}
