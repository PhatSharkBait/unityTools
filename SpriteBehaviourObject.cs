using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviourObject : MonoBehaviour {
    private SpriteRenderer _renderer;

    private void Awake() {
        _renderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj) {
        _renderer.color = obj.value;
    }
}
