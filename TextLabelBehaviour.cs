using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour {
    public Text label;
    public IntDataSO intDataSo;

    private void Start() {
        label = GetComponent<Text>();
    }

    public void UpdateLabel() {
        label.text = intDataSo.value.ToString(CultureInfo.InvariantCulture);
    }
}
