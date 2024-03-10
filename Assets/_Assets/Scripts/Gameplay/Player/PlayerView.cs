using System.Collections.Generic;
using _Assets.Scripts.Gameplay.Bullets;
using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform shootPoint;
        [SerializeField] private BulletView bulletPrefab;
        [SerializeField] private float shootForce = 50f;
        private PlayerInput _playerInput;
        private PlayerMovement _playerMovement;
        private PlayerRotation _playerRotation;
        private PlayerAttack _playerAttack;
        private readonly Queue<PlayerInputCommand> _playerInputCommands = new();

        private void Awake()
        {
            _playerInput = new PlayerInput();
            _playerMovement = new PlayerMovement(transform);
            _playerRotation = new PlayerRotation(Camera.main);
            _playerAttack = new PlayerAttack();
        }

        private void Update()
        {
            GetInput();
            ExecuteInput();
        }

        private void ExecuteInput()
        {
            if (_playerInputCommands.Count > 0)
            {
                var input = _playerInputCommands.Dequeue();

                _playerMovement.Tick(input.Horizontal, input.Vertical);
                _playerRotation.Tick(input.MouseX, input.MouseY, shootPoint);

                if (input.Shoot)
                {
                    _playerAttack.Shoot(shootPoint, bulletPrefab, shootForce);
                }
            }
        }

        private void GetInput() => _playerInputCommands.Enqueue(_playerInput.GetInput());
    }
}