using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentControl : MonoBehaviour
{
    public static float studentHP = 100;
    public static float studentMaxHP = 100;
    public Transform damTextObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (studentHP <= 0)
        {
            BattleSystem.studentStatus = "dead";
            Destroy(gameObject);
        }
        if ((Input.GetKeyDown("1"))||(BattleSystem.attBtnPressed == "y") && (BattleSystem.whichturn==2))
        {
            BattleSystem.currentDamage = 40;
            BattleSystem.attBtnPressed = "n";
            GetComponent<Animator>().SetTrigger("student_atk");
            GetComponent<Transform>().position = new Vector2(2.74f,-2.54f);
            
        }
        
    }
    void returnStudent()
    {
        Instantiate(damTextObj, new Vector2(5.5f, .5f), damTextObj.rotation);
        BattleSystem.damageDisplay = "y";
        GetComponent<Transform>().position = new Vector2(-6.69f, -1.41f);
        BattleSystem.whichturn = 3;
        
    }
}
