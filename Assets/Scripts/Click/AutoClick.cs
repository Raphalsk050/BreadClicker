using UnityEngine;
using Utils;

namespace Click {
    public class AutoClick : BaseClick {
        [SerializeField] private int speed = 1;

        private void Update() {
            Timer.DoDelayed(DoClick, speed);
        }
    }
}