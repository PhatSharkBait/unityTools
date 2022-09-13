using System;
using System.Collections;
using UnityEngine;

namespace unityTools {
    [RequireComponent(typeof(SphereCollider))]
    public abstract class InteractableBase : MonoBehaviour {
        private float interactionRange = 1f;
        private bool inRange;
        private GameObject player;
        private WaitForFixedUpdate _waitForFixedUpdate;
        
        protected SphereCollider rangeSphere;


        private void Awake() {
            //Physics
            gameObject.layer = 10;
            rangeSphere = GetComponent<SphereCollider>();

            //get avg scale of object, divide interaction range by new scale
            var lossyScale = transform.lossyScale;
            var newScale = (Mathf.Abs(lossyScale.x) + Mathf.Abs(lossyScale.y) + Mathf.Abs(lossyScale.z))/3;
            rangeSphere.radius = interactionRange/newScale;
            rangeSphere.isTrigger = true;
        
            //instance wait for fixed update
            _waitForFixedUpdate = new WaitForFixedUpdate();
        }

        private IEnumerator UpdateOnRangeEnter() {
            while (inRange) {
                InRangeUpdate();
                yield return _waitForFixedUpdate;
            }
        }

        private void OnTriggerEnter(Collider other) {
            player = other.gameObject;
            OnRangeEnter();
        }

        private void OnTriggerExit(Collider other) {
            OnRangeExit();
        }

        protected virtual void OnRangeEnter() {
            inRange = true;
            StartCoroutine(UpdateOnRangeEnter());
        }

        protected virtual void OnRangeExit() {
            inRange = false;
            player = null;
        }

        protected virtual void OnInteract() {
            throw new NotImplementedException();
        }

        protected virtual void InRangeUpdate() {
        }
    }
}
