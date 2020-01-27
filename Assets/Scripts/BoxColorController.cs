using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColorController : MonoBehaviour
{

    private List<Color> colors = new List<Color>();

    void Start()
    {
        colors.Add(Color.white);
        colors.Add(Color.red);
        colors.Add(Color.green);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
    
            if(hit)
            {
                Debug.Log("Hit something");
                
                ColorHandler currBox = hit.collider.GetComponent<ColorHandler>();
                int colIdx = currBox.GetAndIncrementColIdx();
                currBox.PlayerChangeColor(colors[colIdx]);
                
            }
            else
            {
                Debug.Log("Didnt hit??");
            }
        }
    }
}
