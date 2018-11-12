using System;
using System.Collections.Generic;
using System.Text;

namespace FiveHundred.Core.Model
{
    public class ComputerPlayer: Player
    {
        public string Name { get; private set; }
        public ComputerPlayer(string name)
        {
            Name = name;
        }
    }
}
