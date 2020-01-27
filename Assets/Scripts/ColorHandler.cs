using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorHandler : MonoBehaviour
{
    
    private Color goalColor;
    private int colorIdx = 0;



    public void SetGoalColor(Color newColor)
    {
        goalColor = newColor;
    }

    public int GetAndIncrementColIdx()
    {
        if (colorIdx < 2) colorIdx++;
        else colorIdx = 0;

        return colorIdx;
    }

    public void ResetBox()
    {
        colorIdx = 0;
        ChangeColor(Color.white);
    }

    private void ChangeColor(Color newColor)
    {
        gameObject.GetComponent<SpriteRenderer>().color = newColor;
    }

    public void PlayerChangeColor(Color newColor)
    {
        ChangeColor(newColor);
    }

    
    

}
