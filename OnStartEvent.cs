using UnityEngine;
using UnityEngine.Events;

namespace unityTools {
    public class OnStartEvent : MonoBehaviour {
        public UnityEvent startEvent;

        private void Start() {
            startEvent.Invoke();
        }
    }
}