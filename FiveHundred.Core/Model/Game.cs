using System;
using System.Collections.Generic;
using System.Text;

namespace FiveHundred.Core.Model
{
    public class Game
    {
        private List<Player> _players = new List<Player>();
        public IEnumerable<Player> Players => _players;


        public void JoinGame(Player player)
        {
            if (_players.Count > 4)
                throw new Exception("Game is full");
        }
    }
}
