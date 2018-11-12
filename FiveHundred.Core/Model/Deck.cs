using System;
using System.Collections.Generic;
using System.Text;

namespace FiveHundred.Core.Model
{
    public interface Deck
    {
        int Cards { get; }

        void Shuffle();
    }
}
