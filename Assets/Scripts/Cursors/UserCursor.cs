using Breads;

namespace Cursors {
    public class UserCursor : BaseCursor {
        public static UserCursor Instance { get; private set; }

        private void Awake() {
            if (Instance != null && Instance != this) Destroy(gameObject);
            else Instance = this;
        }

        public void ClickAsUser() => ClickOnBread();
    }
}
