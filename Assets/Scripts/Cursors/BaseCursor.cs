using UnityEngine;
using Breads;


namespace Cursors {
    public abstract class BaseCursor : MonoBehaviour {
        [SerializeField] private int force = 1;

        protected void ClickOnBread() {
            print("Clicking. Click count: " + ++User.ClickCount);
            // TODO: Click on bread
        }
    }
}