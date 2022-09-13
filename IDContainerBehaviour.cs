using UnityEngine;
using UnityEngine.Events;

namespace unityTools {
   public class IDContainerBehaviour : MonoBehaviour {
      public ID idObj;
      public UnityEvent startEvent;
      private void Start() {
         startEvent.Invoke();
      }
   }
}
