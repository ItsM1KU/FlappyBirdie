using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    [SerializeField] float width = 6f;
    [SerializeField] float speed = 1f;

    private SpriteRenderer SpriteRenderer;
    private Vector2 startsize;

    private void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        startsize = new Vector2(SpriteRenderer.size.x, SpriteRenderer.size.y);
    }

    private void Update()
    {
        SpriteRenderer.size = new Vector2(SpriteRenderer.size.x + speed * Time.deltaTime, SpriteRenderer.size.y);

        if (SpriteRenderer.size.x > width) {
            SpriteRenderer.size = startsize;    
        }
    }
}
