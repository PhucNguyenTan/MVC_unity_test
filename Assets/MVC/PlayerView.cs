using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.MVC
{
    public class PlayerView : MonoBehaviour
    {
        private void Awake()
        {
            //_controller = new PlayerController();
            transform.position = Vector3.up; // Test Start
        }

        private void Update()
        {

        }

        public void MovePlayer(Vector3 newPosition)
        {
            transform.position += newPosition;
        }
    }
}
