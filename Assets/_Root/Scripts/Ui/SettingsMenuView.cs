using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class SettingsMenuView : MonoBehaviour
    {

        [SerializeField] private Button _buttonBack;
        public void Init(UnityAction MainMenu) =>
            _buttonBack.onClick.AddListener(MainMenu);

        public void OnDestroy() =>
            _buttonBack.onClick.RemoveAllListeners();
    }
}