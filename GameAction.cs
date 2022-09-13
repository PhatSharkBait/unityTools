using UnityEngine;
using UnityEngine.Events;

namespace unityTools {
    [CreateAssetMenu]
    public class GameAction : ScriptableObject {
        public UnityAction raise;

        public void RaiseAction() {
            raise?.Invoke();
        }
    }
}
