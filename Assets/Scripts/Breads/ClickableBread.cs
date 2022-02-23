using System;

namespace Breads {    
    public class ClickableBread : BaseBread {
        public static ClickableBread Instance { get; private set; }
        public Action OnClicked { get; set; }
        private BreadAnimation _breadAnimation;

        private void Awake() {
            if (Instance != null && Instance != this) 
                Destroy(gameObject);
            else 
                Instance = this;
            _breadAnimation = GetComponent<BreadAnimation>();
        }

        private void OnEnable() =>
            OnClicked += _breadAnimation.TriggerBreadClickedAnimation;

        private void OnDisable() =>
            OnClicked -= _breadAnimation.TriggerBreadClickedAnimation;
        

        private void OnMouseDown() {
            User.Click();
        }
    }
}
