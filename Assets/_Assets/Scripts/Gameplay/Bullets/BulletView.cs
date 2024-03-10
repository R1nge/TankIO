using UnityEngine;

namespace _Assets.Scripts.Gameplay.Bullets
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BulletView : MonoBehaviour
    {
        private Bullet _bullet;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _bullet = new Bullet(_rigidbody2D);
        }

        private void OnTriggerEnter2D(Collider2D other) => _bullet.Destroy();

        public void AddForce(Vector2 force) => _bullet.AddForce(force);
    }
}