using System;

namespace Breads {    
    public class ClickableBread : BaseBread {
        public static ClickableBread Instance { get; private set; }
        public Action OnClicked { get; set; }

        private void Awake() {
            if (Instance != null && Instance != this) 
                Destroy(gameObject);
            else 
                Instance = this;
        }

        private void OnMouseDown() {
            User.Click();
        }
    }
}
