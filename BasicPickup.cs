using UnityEngine.Events;

namespace unityTools {
    public class BasicPickup: InteractableBase {
        public UnityEvent pickupEvent;
        private void Start() {
            rangeSphere.isTrigger = true;
        }

        protected override void OnRangeEnter() {
            base.OnRangeEnter();
            pickupEvent.Invoke();
        }
    }
}