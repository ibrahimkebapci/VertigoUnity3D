using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementContorller : MonoBehaviour
    {
        [SerializeField] PlayerMovementSettings _playerMovementSettings;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private InputData _inputData;
        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.forward * _inputData.Vertical *
                _playerMovementSettings.VerticalSpeed));
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.right * _inputData.Horizontal * 
                _playerMovementSettings.HorizontalSpeed));

        }
    }
}
