using FiveHundred.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FiveHundred.Core.Tests.Model
{
    public class ComputerPlayerTests
    {
        [Fact]
        public void CanCreateComputerPlayer()
        {
            var player = new ComputerPlayer("Player 1");

        }
    }
}
