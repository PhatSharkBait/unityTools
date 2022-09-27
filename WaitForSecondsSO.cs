using UnityEngine;
namespace unityTools {
    [CreateAssetMenu]
    public class WaitForSecondsSO : ScriptableObject {
        public float seconds = 1f;
        public WaitForSeconds waitForSeconds;

        private void Awake() {
            waitForSeconds = new WaitForSeconds(seconds);
        }
    }
}
