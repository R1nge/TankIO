using System.Collections.Generic;
using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform shootPoint;
        [SerializeField] private BulletView bulletPrefab;
        [SerializeField] private float shootForce;
        private PlayerInput _playerInput;
        private PlayerMovement _playerMovement;
        private PlayerAttack _playerAttack;
        private readonly Queue<PlayerInputCommand> _playerInputCommands = new();

        private void Awake()
        {
            _playerInput = new PlayerInput();
            _playerMovement = new PlayerMovement(transform);
            _playerAttack = new PlayerAttack();
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

                if (input.Shoot)
                {
                    _playerAttack.Shoot(shootPoint, bulletPrefab, shootForce);
                }
            }
        }
    }
}