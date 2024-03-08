using System;

namespace _Assets.Scripts.Gameplay.Player
{
    [Serializable]
    public struct PlayerInputCommand
    {
        public float Horizontal;
        public float Vertical;
        public bool Shoot;
        public float MouseX, MouseY;
    }
}