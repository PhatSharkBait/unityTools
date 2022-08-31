using UnityEngine;

[CreateAssetMenu]
public class FloatDataSO : ScriptableObject {
    public float value;
    public void SetValue(int newValue) {
        value = newValue;
    }
    public void UpdateValueByAmount(float amount) {
        value += amount;
    }
}
