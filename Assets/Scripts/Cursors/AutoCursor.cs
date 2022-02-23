using UnityEngine;
using Utils;

namespace Cursors {
    public class AutoCursor : BaseCursor {
        [SerializeField] private int speed = 1;

        private void Update() {
            Timer.DoDelayed(ClickOnBread, speed);
        }
       
    }
}