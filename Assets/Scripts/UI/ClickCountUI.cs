using Breads;
using TMPro;
using UnityEngine;

namespace UI {
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ClickCountUI : MonoBehaviour {
        private TextMeshProUGUI _clickCountText;

        private void Awake() =>
            _clickCountText = GetComponent<TextMeshProUGUI>();

        private void OnEnable() =>
            ClickableBread.Instance.OnClicked += UpdateClickCountText;

        private void OnDisable() =>
            ClickableBread.Instance.OnClicked -= UpdateClickCountText;

        private void UpdateClickCountText() =>
            _clickCountText.SetText($"{User.ClickCount} clicks");
    }
}
