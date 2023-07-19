using UnityEngine;

namespace _Scripts
{
    public class RotationHandler : MonoBehaviour
    {
        [SerializeField] Vector3 rotationDirection;
        [SerializeField] int rotationSpeed;

        private Rigidbody m_Rigidbody;

        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
        }

        
        private void Update()
        {
            transform.Rotate(rotationDirection * (rotationSpeed * Time.deltaTime));
        }
    }
}
