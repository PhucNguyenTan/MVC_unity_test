using UnityEditor;
using UnityEngine;

namespace Assets.MVC
{
    public class PlayerFactory
    {
        private PlayerModel _model;
        private PlayerController _controller;
        private PlayerView _view;

        public PlayerController Controller { get { return _controller; } }

        public void CreatePlayer(PlayerView playerView)
        {
            _view = GameObject.Instantiate(playerView);
            _model = new PlayerModel();
            _controller = new PlayerController(_view, _model);
        }
    }
}