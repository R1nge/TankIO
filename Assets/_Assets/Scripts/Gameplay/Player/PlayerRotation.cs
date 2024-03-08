using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerRotation
    {
        public void Tick(float mouseX, float mouseY, Transform transform)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, mouseY, 10f));
            Vector2 direction = mousePosition - transform.position;
            float angle = Vector2.SignedAngle(Vector2.right, direction);
            transform.eulerAngles = new Vector3 (0, 0, angle);
        }
    }
}