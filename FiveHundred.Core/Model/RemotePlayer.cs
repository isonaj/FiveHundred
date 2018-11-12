using System;
using System.Collections.Generic;
using System.Text;

namespace FiveHundred.Core.Model
{
    public class RemotePlayer: Player
    {
        public string Name { get; private set; }
        public RemotePlayer(string name)
        {
            Name = name;
        }
    }
}
