using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Text winText;
    private List<GameObject> boxes;
    // Start is called before the first frame update
    void Start()
    {
        boxes = gameObject.GetComponent<BoxGenerator>().GetBoxList();
    }

    // Update is called once per frame
    void Update()
    {
        bool win = true;
        foreach (var box in boxes)
        {
            if (!box.GetComponent<ColorHandler>().HasGoalColor())
            {
                win = false;
                break;
            }
        }

        if (win)
        {
            winText.text = "Congratz, you're smart";
        }
        else
        {
            winText.text = "";   
        }
        
    }
}
