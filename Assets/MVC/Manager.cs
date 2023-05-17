using System.Collections;
using UnityEngine;

namespace Assets.MVC
{
    public class Manager : MonoBehaviour
    {
        private PlayerFactory _playerFactory;
        [SerializeField]
        private PlayerView _playerPrefab;

        private void Start()
        {
            _playerFactory = new PlayerFactory(); 
            _playerFactory.CreatePlayer(_playerPrefab);
        }

        private void Update()
        {
            var (forwardMove, strafeMove) = GetMovement();
            _playerFactory.Controller.MovePlayer(forwardMove, strafeMove);
        }

        private (float, float) GetMovement()
        {
            var forwardMove = 0f;
            var strafeMove = 0f;
            if (Input.GetKey("w") && !Input.GetKey("s"))
            {
                forwardMove = 1f;
            }
            else if (Input.GetKey("s") && !Input.GetKey("w"))
            {
                forwardMove = -1f;
            }
            else
            {
                forwardMove = 0f;
            }

            if (Input.GetKey("d") && !Input.GetKey("a"))
            {
                strafeMove = 1f;
            }
            else if (Input.GetKey("a") && !Input.GetKey("d"))
            {
                strafeMove = -1f;
            }
            else
            {
                strafeMove = 0f;
            }
            return (forwardMove, strafeMove);
        }
    }
}