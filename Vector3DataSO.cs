using UnityEngine;

namespace unityTools {
    [CreateAssetMenu(fileName = "New Vector3 Data", menuName = "Vector3 Data", order = 0)]
    public class Vector3DataSO : ScriptableObject {
        public Vector3 value;

        public void SetValue(Vector3 newValue) {
            value = newValue;
        }
    }
}