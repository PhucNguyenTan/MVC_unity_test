using System.Collections;
using UnityEngine;

namespace Assets
{
    public class InputReader : MonoBehaviour
    {
        private PlayerInputAction inputAction;

        private void OnEnable()
        {
            inputAction.P1_Action.Enable();
        }
        private Vector2 Movement(Vector2 moveV2)
        {

            var move = inputAction.P1_Action.Move.ReadValue<Vector2>();
            MessageManager.Instance.
        }
    }
}