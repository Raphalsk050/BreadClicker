using UnityEngine;


namespace Click {
    public abstract class BaseClick : MonoBehaviour {
        [SerializeField] private int force = 1;

        protected void DoClick() {
            print("Clicking. Click count: " + ++User.ClickCount);
            // TODO: Click on bread
        }
    }
}