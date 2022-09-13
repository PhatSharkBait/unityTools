using System.Collections;
using UnityEngine;

namespace unityTools {
    public class DestroyBehaviour : MonoBehaviour {
        public float seconds = 1;
        private IEnumerator Start() {
            yield return new WaitForSeconds(seconds);
            Destroy(gameObject);
        }
    }
}
