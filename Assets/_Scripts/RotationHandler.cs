using UnityEngine;

namespace _Scripts
{
    public class RotationHandler : MonoBehaviour
    {
        [SerializeField] Vector3 rotationDirection;
        [SerializeField] int rotationSpeed;
        
        
        private void Update()
        {
            transform.Rotate(rotationDirection * (rotationSpeed * Time.deltaTime));
        }
    }
}
