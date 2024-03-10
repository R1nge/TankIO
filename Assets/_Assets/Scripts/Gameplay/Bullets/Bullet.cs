using UnityEngine;

namespace _Assets.Scripts.Gameplay.Bullets
{
    public class Bullet
    {
        private readonly Rigidbody2D _rigidbody2D;

        public Bullet(Rigidbody2D rigidbody2D) => _rigidbody2D = rigidbody2D;

        public void AddForce(Vector2 force) => _rigidbody2D.AddForce(force, ForceMode2D.Impulse);

        public void Destroy() => Object.Destroy(_rigidbody2D.gameObject);
    }
}