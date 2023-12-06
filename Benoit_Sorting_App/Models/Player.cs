using System;

namespace benoit_Sorting_App.Models
{
    public class Player
    {
        private int _id;
        private string _playerAlias;
        private int _playerScore;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string PlayerAlias
        {
            get { return _playerAlias; }
            set { _playerAlias = value; }
        }

        public int PlayerScore
        {
            get { return _playerScore; }
            set { _playerScore = value; }
        }
    }
}