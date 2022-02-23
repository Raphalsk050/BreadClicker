using UnityEngine;
using Breads;

namespace Cursors {
    public abstract class BaseCursor : MonoBehaviour {
        [SerializeField] private int force = 1;

        protected void ClickOnBread() {
            ClickableBread.Instance.OnClicked();
        }

        private void OnEnable() {
            
            ClickableBread.Instance.OnClicked += IncrementClickCountWithForce;
        }

        private void OnDisable() =>
            ClickableBread.Instance.OnClicked -= IncrementClickCountWithForce;

        private void IncrementClickCountWithForce() =>
            User.IncrementClickCount(force);
    }
}