using System;
using System.Text.Json.Serialization;

namespace benoit_Sorting_App.Models
{
    public class Player
    {
        private int _id;
        private String _playerAlias;
        private int _playerScore;
        private int _tournamentPlace;

        /* TODO : check if setter are mandatory
            if yes, check to make them private
            
        */
        public String PlayerAlias
        {
            get { return _playerAlias; }
            set { _playerAlias = value; }
        }

        public int PlayerScore
        {
            get { return _playerScore; }
            set { _playerScore = value; }
        }

        public int TournamentPlace
        {
            get { return _tournamentPlace; }
            set { _tournamentPlace = value; }
        }

        [JsonIgnore]
        //TODO : remove this
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}