using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.MVC
{
    public class PlayerController
    {
        private Vector3 move = Vector3.zero;
        private PlayerView _view;
        private PlayerModel _model;

        public PlayerController(PlayerView view, PlayerModel model)
        {
            Assert.IsNotNull(view);
            _view = view;
            _model = model;
        }

        public void MovePlayer(float forward, float side)
        {
            if (forward != 0 || side != 0)
            {
                move.z = forward;
                move.x = side;
                _view.MovePlayer(move * Time.deltaTime * _model.Speed);
            }
        }
    }
}
