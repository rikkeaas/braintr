using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorHandler : MonoBehaviour
{
    
    private Color boxColor = Color.white;
    private Color goalColor;

    // void Start()
    // {
    //     colors.Add(Color.white);
    //     colors.Add(Color.red);
    //     colors.Add(Color.green);
    // }

    public void SetGoalColor(Color newColor)
    {
        goalColor = newColor;
    }

    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
 
        if(Physics.Raycast (ray, out hit))
        {
            // if (hit.gameObjec != null)
            // {

            // }
        }
    }

}
