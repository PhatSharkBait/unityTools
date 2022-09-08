using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehaviour : MonoBehaviour {
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    
    private Camera _camera;
    private void Start() {
        _camera = Camera.main;
    }

    public IEnumerator OnMouseDown() {
        offset = transform.position - _camera.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();

        while (draggable) {
            yield return new WaitForFixedUpdate();
            position = _camera.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp() {
        draggable = false;
        endDragEvent.Invoke();
    }
}
