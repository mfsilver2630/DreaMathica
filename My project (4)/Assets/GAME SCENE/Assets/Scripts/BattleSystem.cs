using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    public static int whichturn = 1;
    public static float currentDamage = 0;

    public static string damageDisplay = "n";

    public static string archerStatus = "OK";
    public static string studentStatus = "OK";

    public static string enemyStatus1 = "OK";
    public static string enemyStatus2 = "OK";
    // Hero XP storage
    public static int archerTotalXP = 0;
    public static int studentTotalXP = 0;

    // selected monster
    public static string selectedEnemy = "";

    public static string attBtnPressed = "n";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((whichturn == 1) && (archerStatus =="dead"))
        {
            whichturn = 2;
        }
        if ((whichturn == 2) && (studentStatus == "dead"))
        {
            whichturn = 1;
        }
        
        if((whichturn == 3) && (enemyStatus1 == "dead"))
        {
            whichturn = 4;
        }
        if ((whichturn == 5) && (enemyStatus1 == "dead"))
        {
            whichturn = 1;
        }

    }
}
