using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehaviour : MonoBehaviour
{
    public Collider2D HookCollision;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPosition.x, cursorPosition.y); 
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EmailFish")
        {
            if (Input.GetMouseButtonDown(0))
            {

            }
        }
    }
}
