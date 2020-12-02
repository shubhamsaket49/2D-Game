using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackGround : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D groundCollider;
    private float groundHorizentalLength;
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizentalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundHorizentalLength)
        {
        	Rep();
        }
    }

    private void Rep()
    {
    	Vector2 groundOffset = new Vector2 (groundHorizentalLength * 2f,0);
    	transform.position = (Vector2)transform.position + groundOffset;
    }
}
