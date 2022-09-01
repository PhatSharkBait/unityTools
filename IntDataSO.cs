using UnityEngine;
[CreateAssetMenu]
public class IntDataSO : ScriptableObject {
    public int value;

    public void SetValue(int newValue) {
        value = newValue;
    }
    
    public void SetValue(IntDataSO obj) {
        value = obj.value;
    }

    public void CompareValue(IntDataSO obj) {
        if (value >= obj.value) return;
        value = obj.value;
    }
    
    public void UpdateValueByAmount(int amount) {
        value += amount;
    }
}
