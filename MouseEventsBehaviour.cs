using UnityEngine;
using UnityEngine.Events;

namespace unityTools {
    public class MouseEventsBehaviour : MonoBehaviour {
        public UnityEvent onMouseDownEvent,
            onMouseDragEvent,
            onMouseEnterEvent,
            onMouseExitEvent,
            onMouseUpEvent,
            onMouseUpAsButtonEvent;

        private void OnMouseDown() {
            onMouseDownEvent.Invoke();
        }

        private void OnMouseDrag() {
            onMouseDragEvent.Invoke();
        }

        private void OnMouseEnter() {
            onMouseEnterEvent.Invoke();
        }

        private void OnMouseExit() {
            onMouseExitEvent.Invoke();
        }
//don't use OnMouseOver, too expensive
        private void OnMouseUp() {
            onMouseUpEvent.Invoke();
        }

        private void OnMouseUpAsButton() {
            onMouseUpAsButtonEvent.Invoke();
        }
    }
}