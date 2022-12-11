using UnityEngine;
using UnityEngine.Events;

namespace unityTools {
    public class OnEnableEvent : MonoBehaviour {
        public UnityEvent enableEvent;

        private void OnEnable() {
            enableEvent.Invoke();
        }
    }
}