using System;
using UnityEngine;

namespace Utils {
    public static class Timer {
        private static float _millisecondsCooldown;

        public static void DoDelayed(Action action, int speed, float maxMillisecondsCooldown = 1000f, bool fixedDeltaTime = false) {
            _millisecondsCooldown += speed * (fixedDeltaTime ? Time.fixedDeltaTime : Time.deltaTime);
            if (_millisecondsCooldown >= maxMillisecondsCooldown) {
                _millisecondsCooldown = default;
                action();
            }
        }

        public static TResult DoDelayed<TResult> (Func<TResult> func, int speed, float maxMillisecondsCooldown = 1000f, bool fixedDeltaTime = false) {
            _millisecondsCooldown += speed * (fixedDeltaTime ? Time.fixedDeltaTime : Time.deltaTime);
            if (_millisecondsCooldown >= maxMillisecondsCooldown) {
                _millisecondsCooldown = default;
                return func();
            }
            return default;
        }
    }
}