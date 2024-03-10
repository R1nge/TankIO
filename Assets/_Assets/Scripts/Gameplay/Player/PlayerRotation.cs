using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerRotation
    {
        private readonly Camera _camera;

        public PlayerRotation(Camera camera) => _camera = camera;

        public void Tick(float mouseX, float mouseY, Transform transform)
        {
            var mousePosition = _camera.ScreenToWorldPoint(new Vector3(mouseX, mouseY, 10f));
            Vector2 direction = mousePosition - transform.position;
            var angle = Vector2.SignedAngle(Vector2.right, direction);
            transform.eulerAngles = new Vector3(0, 0, angle);
        }
    }
}