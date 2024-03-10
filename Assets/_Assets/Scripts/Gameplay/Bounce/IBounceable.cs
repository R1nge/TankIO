using UnityEngine;

namespace _Assets.Scripts.Gameplay.Bounce
{
    public interface IBounceable
    {
        void Bounce(Rigidbody2D rigidbody2D, Vector2 direction, float force);
    }
}