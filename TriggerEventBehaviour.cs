using UnityEngine;
using UnityEngine.Events;
public class TriggerEventBehaviour : MonoBehaviour {
    public UnityEvent triggerEnterEvent, triggerExitEvent;

    private void OnTriggerEnter(Collider other) {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other) {
        triggerExitEvent.Invoke();
    }
}
