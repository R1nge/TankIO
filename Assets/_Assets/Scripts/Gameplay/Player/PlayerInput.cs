using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerInput
    {
        private PlayerInputCommand _inputCommand = new();

        public void Tick()
        {
            _inputCommand.Horizontal = Input.GetAxis("Horizontal");
            _inputCommand.Vertical = Input.GetAxis("Vertical");
            _inputCommand.Shoot = Input.GetButton("Fire1");
        }
        
        public PlayerInputCommand GetInput() => _inputCommand;
    }
}