using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerCamera
    {
        private readonly Camera _camera;
        private readonly AudioListener _audioListener;

        public PlayerCamera(Camera camera, AudioListener audioListener)
        {
            _camera = camera;
            _audioListener = audioListener;
        }

        public void Enable()
        {
            _camera.enabled = true;
            _audioListener.enabled = true;
        }

        public void Disable()
        {
            _camera.enabled = false;
            _audioListener.enabled = false;
        }
    }
}