using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[RequireComponent(typeof(TextMeshProUGUI))]
public class TextLabelBehaviour : MonoBehaviour {
    public UnityEvent startEvent;

    private TextMeshProUGUI _label;
    private void Awake() {
        _label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    public void UpdateLabel(IntDataSO obj) {
        _label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
    
    public void UpdateLabel(FloatDataSO obj) {
        _label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(StringSO obj) {
        _label.text = obj.value;
    }
}
