using UnityEngine;

namespace unityTools {
    public class TransformBehaviour : MonoBehaviour {
        public void ResetToZero() {
            transform.position = Vector3.zero;
        }
    }
}
