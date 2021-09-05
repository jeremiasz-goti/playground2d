using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player0 : MonoBehaviour
{
    // Setting main variables

    private BoxCollider2D boxCollider2d;
    private Vector2 moveDelta;
    private RaycastHit2D hit;


    // Start is called before the first frame update
    void Start()
    {
        boxCollider2d = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Get input values from Keys
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        // Reset moveDelta on each update
        moveDelta = new Vector3(x, y, 0);

        // Switch player direction depending on movement direction
        if (moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;

        }
        else if (moveDelta.x < 0) {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // Movement        
        

        // Collisions and Movement
        hit = Physics2D.BoxCast(transform.position, boxCollider2d.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actors", "Blocking"));

        if (hit.collider == null)
        {
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider2d.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actors", "Blocking"));

        if (hit.collider == null)
        {
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        }

    }
}
