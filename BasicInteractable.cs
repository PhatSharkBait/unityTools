using UnityEngine;

namespace unityTools {
    public class BasicInteractable : InteractableBase {
        protected override void InRangeUpdate() {
            base.InRangeUpdate();
        }

        protected override void OnRangeEnter() {
            base.OnRangeEnter();
        }

        protected override void OnRangeExit() {
            base.OnRangeExit();
        }

        protected override void OnInteract() {
            Debug.Log("ya did that didn't you");
        }
    }
}
