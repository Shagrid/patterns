using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerController : MonoBehaviour
    {
        private MoveCharacter2D _character2D;
        private readonly float _moveRight = 1.0f;
        private readonly float _moveLeft = -1.0f;
        private void Start()
        {
            _character2D = GetComponent<MoveCharacter2D>();
        }

        private void Update()
        {
            
            if (Input.GetKey(KeyCode.D))
            {
                _character2D.Moving(_moveRight);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                _character2D.Moving(_moveLeft);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _character2D.Jump();
            } 
            
        }

    }
}