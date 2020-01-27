using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    public GameObject paintBoxPrefab;
    public int lvlSize = 4;
    public float boxSize = 1f;
    public UnityEngine.Color color1 = UnityEngine.Color.red;
    public UnityEngine.Color color2 = UnityEngine.Color.green;

    private List<GameObject> boxes;

    // Start is called before the first frame update
    void Start()
    {
        boxes = new List<GameObject>();
        float startPosX = - (lvlSize / 2f) * boxSize;
        float startPosY = - (lvlSize / 2f) * boxSize;

        for (int x = 0; x < lvlSize; x++)
        {
            for (int y = 0; y < lvlSize; y++)
            {
                GameObject newBox = Instantiate(paintBoxPrefab, new Vector2(startPosX + (x * boxSize), startPosY + (y * boxSize)), Quaternion.identity);
                float rand = Random.Range(0f, 1f);
                
                if (rand < 0.5f)
                {
                    newBox.GetComponent<SpriteRenderer>().color = color1;
                }
                else
                {
                    newBox.GetComponent<SpriteRenderer>().color = color2;
                }
                boxes.Add(newBox);
            }
        }
    }
}
