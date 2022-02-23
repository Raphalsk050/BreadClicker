using UnityEngine;

namespace Breads {
    [RequireComponent(typeof(Animator))]
    public class BreadAnimation : MonoBehaviour {
        private Animator _animator;
        private static readonly int _breadClicked = Animator.StringToHash("BreadClicked");

        private void Awake() =>
            _animator = GetComponent<Animator>();

        public void TriggerBreadClickedAnimation() =>
            _animator.SetTrigger(_breadClicked);
    }
}
