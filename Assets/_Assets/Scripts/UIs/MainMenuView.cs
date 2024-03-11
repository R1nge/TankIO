using System.Collections;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

namespace _Assets.Scripts.UIs
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button host;
        [SerializeField] private Button join;

        private void Start()
        {
            host.onClick.AddListener(Host);
            join.onClick.AddListener(Join);
        }

        private void Host()
        {
            NetworkManager.singleton.StartHost();
            StartCoroutine(ChangeScene_C());
        }

        private IEnumerator ChangeScene_C()
        {
            yield return new WaitForSeconds(10f);
            NetworkManager.singleton.ServerChangeScene("Main");
        }

        private void Join()
        {
            NetworkManager.singleton.StartClient();
        }
    }
}