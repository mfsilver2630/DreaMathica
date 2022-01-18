using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Sprite ruler_img;
    public Sprite book_img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BattleSystem.whichturn == 1)
        {
            GetComponent<SpriteRenderer>().sprite = book_img;
        }
        if (BattleSystem.whichturn == 2)
        {
            GetComponent<SpriteRenderer>().sprite = ruler_img;
        }
    }

     void OnMouseDown()
    {
        BattleSystem.attBtnPressed = "y";
    }
}
