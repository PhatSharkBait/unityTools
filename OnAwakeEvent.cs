using UnityEngine;
using UnityEngine.Events;

namespace unityTools {
    public class OnAwakeEvent : MonoBehaviour {
        public UnityEvent awakeEvent;

        private void Awake() {
            awakeEvent.Invoke();
        }
    }
}
