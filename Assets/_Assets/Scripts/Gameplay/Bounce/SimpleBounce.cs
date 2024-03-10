using UnityEngine;

namespace _Assets.Scripts.Gameplay.Bounce
{
    public class SimpleBounce : IBounceable
    {
        public void Bounce(Rigidbody2D rigidbody2D, Vector2 direction, float force)
        {
            rigidbody2D.AddForce(direction.normalized * force, ForceMode2D.Impulse);
        }
    }
}