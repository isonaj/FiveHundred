using System;
using System.Collections.Generic;
using System.Text;

namespace FiveHundred.Core.Model
{
    public delegate void GameEventHandler();
    public enum GameStatus { Open, Bidding, Playing };
    public class Game
    {
        public event GameEventHandler OnGameStarted;

        private List<Player> _players = new List<Player>();
        public IEnumerable<Player> Players => _players;
        public GameStatus Status { get; private set; }
        public Game()
        {
            Status = GameStatus.Open;
        }

        public void JoinGame(Player player)
        {
            if (Status != GameStatus.Open)
                throw new Exception("Game must be open to join");

            if (_players.Count > 4)
                throw new Exception("Game is full");
        }
    }
}
