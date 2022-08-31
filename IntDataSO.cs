using UnityEngine;
[CreateAssetMenu]
public class IntDataSO : ScriptableObject {
    public int value;

    public void SetValue(int newValue) {
        value = newValue;
    }
    
    public void UpdateValueByAmount(int amount) {
        value += amount;
    }
}
