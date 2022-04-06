using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Features.Back
{
    internal class BackToMainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _backToMainMenuButton;

        public void Init(UnityAction backToMainMenu)
        {
            _backToMainMenuButton.onClick.AddListener(backToMainMenu);
        }

        private void OnDestroy()
        {
            _backToMainMenuButton.onClick.RemoveAllListeners();
        }

    }
}
