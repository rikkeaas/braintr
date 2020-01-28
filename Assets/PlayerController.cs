using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Color playerColor = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = playerColor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        
        Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
    
        if(hit)
        {
            Debug.Log("Hit something");
            transform.position = hit.collider.gameObject.transform.position;

            if (Input.GetMouseButtonDown(0)) 
            {
                ColorHandler currBox = hit.collider.GetComponent<ColorHandler>();
                // int colIdx = currBox.GetAndIncrementColIdx();
                currBox.PlayerChangeColor(playerColor);
            }
                
        }
        else
        {
            Debug.Log("Didnt hit??");
        }
        
    }
}
