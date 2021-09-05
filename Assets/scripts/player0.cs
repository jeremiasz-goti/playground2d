using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player0 : MonoBehaviour
{
    // Setting main variables

    private BoxCollider2D boxCollider2d;
    private Vector2 moveDelta;


    // Start is called before the first frame update
    void Start()
    {

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

        transform.Translate(moveDelta * Time.deltaTime);
        
    }
}
