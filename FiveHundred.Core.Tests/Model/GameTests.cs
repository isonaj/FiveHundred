using FiveHundred.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FiveHundred.Core.Tests.Model
{
    public class GameTests
    {
        [Fact]
        public void CanCreateGame()
        {
            var game = new Game();
        }
    }
}
