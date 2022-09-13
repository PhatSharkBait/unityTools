namespace unityTools {
    public class BasicPickup: InteractableBase {
        private void Start() {
            rangeSphere.isTrigger = true;
        }

        protected override void OnRangeEnter() {
            base.OnRangeEnter();
        }

        protected override void OnRangeExit() {
            base.OnRangeExit();
        }

        protected override void InRangeUpdate() {
            base.InRangeUpdate();
        }
    }
}