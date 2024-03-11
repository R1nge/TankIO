using Mirror;
using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerSpawnerView : NetworkBehaviour
    {
        [SerializeField] private GameObject playerPrefab;

        private void Start()
        {
            NetworkServer.OnConnectedEvent += ClientConnectedToServer;
            NetworkClient.OnConnectedEvent += ClientConnected;

            foreach (var client in NetworkServer.connections.Values)
            {
                SpawnServerRpc(client);
            }
        }

        private void ClientConnectedToServer(NetworkConnectionToClient connectionToClient)
        {
            Debug.Log("Client connected to server");
            Spawn(connectionToClient);
        }

        private void ClientConnected()
        {
            Debug.Log("Client connected");
            SpawnServerRpc(NetworkServer.localConnection);
        }

        private void Spawn(NetworkConnection networkConnection)
        {
            var player = Instantiate(playerPrefab);
            NetworkServer.Spawn(player, networkConnection);
        }

        [Command(requiresAuthority = false)]
        private void SpawnServerRpc(NetworkConnectionToClient connection = null)
        {
            var player = Instantiate(playerPrefab);
            NetworkServer.Spawn(player, connection);
        }
    }
}