using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerInput
    {
        private PlayerInputCommand _inputCommand;

        public void Tick()
        {
            _inputCommand.Horizontal = Input.GetAxis("Horizontal");
            _inputCommand.Vertical = Input.GetAxis("Vertical");
            _inputCommand.Shoot = Input.GetMouseButtonDown(0);
            Debug.Log(_inputCommand.Shoot);
        }
        
        public PlayerInputCommand GetInput() => _inputCommand;
    }
}