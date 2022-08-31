using UnityEngine;
using UnityEngine.Events;

namespace unityTools {
    public class MonoEventsBehaviour : MonoBehaviour {
        public UnityEvent startEvent, awakeEvent, disableEvent;

        private void Awake() {
            awakeEvent.Invoke();
        }

        private void Start() {
            startEvent.Invoke();
        }

        private void OnDisable() {
            disableEvent.Invoke();
        }
    }
}