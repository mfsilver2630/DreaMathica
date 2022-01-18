using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherCon : MonoBehaviour
{
    public static float archerHP = 75;
    public static float archerMaxHP = 75;
    public Transform arrowObj;
    public Transform damTextObj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (archerHP <= 0)
        {
            BattleSystem.archerStatus = "dead";
            Destroy(gameObject);
        }
        if ((Input.GetKeyDown("1")) || (BattleSystem.attBtnPressed == "y") && (BattleSystem.whichturn ==1))
        {
            
     
            BattleSystem.currentDamage = 80;
            BattleSystem.attBtnPressed = "n";
            GetComponent<Transform>().position = new Vector2(-1.52f, -2.57f);
            Instantiate(arrowObj, new Vector2(-1.22f, -2.2f), arrowObj.rotation);
            StartCoroutine(returnWitch());

        }
    }
    IEnumerator returnWitch()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Transform>().position = new Vector2(-6.74f, -3.77f);
        BattleSystem.whichturn = 2;
        Instantiate(damTextObj, new Vector2(5.5f, .5f), damTextObj.rotation);
        BattleSystem.damageDisplay = "y"; 
    }
}
