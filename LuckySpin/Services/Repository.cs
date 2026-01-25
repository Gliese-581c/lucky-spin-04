using System;
using System.Collections.Generic;
using System.Security;
using LuckySpin.Models;

namespace LuckySpin.Services
{
    public class Repository
    {
        private List<Spin> _spins = new List<Spin>(); //NOTE: This is an in-memory list of spins
        //TODO: Complete the Dependency Injection for the Player object
        private Player _player;
        public Repository(Player player)
        {
            _player = player;
        }

       //Property
       public Player Player {
            get { return _player; }
            set { _player = value; }
       }
       public IEnumerable<Spin> PlayerSpins {

            get { return _spins; }
       }

        //Access method to add a spin to the repository, called from the SpinnerController
        public void AddSpin(Spin s)
        {
            _spins.Add(s);
        }

        public void AddPlayer(Player p)
        {
            _player = p;
        }
    }
}
