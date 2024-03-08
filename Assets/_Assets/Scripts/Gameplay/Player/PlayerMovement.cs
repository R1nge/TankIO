using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerMovement
    {
        private float _speed = 5f;
        private readonly Transform _transform;

        public PlayerMovement(Transform transform)
        {
            _transform = transform;
        }
        
        public void SetSpeed(float speed) => _speed = speed;

        public void Tick(float horizontal, float vertical)
        {
            _transform.Translate(Vector3.right * (horizontal * Time.deltaTime * _speed));
            _transform.Translate(Vector3.up * (vertical * Time.deltaTime * _speed));
        }
    }
}