using UnityEngine;
using UnityEngine.Events;

namespace unityTools {
    public class GameActionHandler : MonoBehaviour {
        public GameAction gameActionObject;
        public UnityEvent respondEvent;
        private void Start() {
            gameActionObject.raise += Respond;
        }

        private void Respond() {
            respondEvent.Invoke();
        }
    }
}