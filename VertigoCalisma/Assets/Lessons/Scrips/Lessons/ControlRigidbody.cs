using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lessons
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private ControlRigidbodySettings _settings;
        [SerializeField] private Rigidbody _rigidbody;
        private void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
            if(spaceKeyDown)
            {
                _rigidbody.AddForce(_settings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}