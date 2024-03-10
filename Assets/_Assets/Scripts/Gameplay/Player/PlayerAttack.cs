using _Assets.Scripts.Gameplay.Bullets;
using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerAttack
    {
        public void Shoot(Transform shootPoint, BulletView bulletPrefab, float force)
        {
            var bullet = Object.Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
            bullet.transform.forward = shootPoint.forward;
            bullet.AddForce(shootPoint.right * force);
        }
    }
}