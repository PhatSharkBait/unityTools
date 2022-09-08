using System.Collections;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour {
    public float seconds = 1;
    private IEnumerator Start() {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }
}
