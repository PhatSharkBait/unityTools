using System;
using UnityEngine;

namespace unityTools {
    [CreateAssetMenu]
    public class StringSO : ScriptableObject {
        public string value;

        public void SetValue(String newValue) {
            value = newValue;
        }

        public void SetTextToString(TextMesh textMeshObj) {
            textMeshObj.text = value;
        }
    }
}
