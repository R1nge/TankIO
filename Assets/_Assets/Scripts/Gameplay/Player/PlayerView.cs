using System.Collections.Generic;
using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerView : MonoBehaviour
    {
        private PlayerInput _playerInput;
        private PlayerMovement _playerMovement;
        private readonly Queue<PlayerInputCommand> _playerInputCommands = new();

        private void Awake()
        {
            _playerInput = new PlayerInput();
            _playerMovement = new PlayerMovement(transform);
        }

        private void Update()
        {
            _playerInput.Tick();
            var input = _playerInput.GetInput();
            _playerInputCommands.Enqueue(input);
            
            ExecuteInput();
        }
        
        private void ExecuteInput()
        {
            if (_playerInputCommands.Count > 0)
            {
                var input = _playerInputCommands.Dequeue();
                
                _playerMovement.Tick(input.Horizontal, input.Vertical);
            }
        }
    }
}