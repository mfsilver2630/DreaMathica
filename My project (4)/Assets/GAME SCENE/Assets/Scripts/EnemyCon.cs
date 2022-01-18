using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    public float enemyHP = 100;
    public float enemyAttk = 20;
    public int heroattk = 0;
    public Transform hitEffectObj;


    // Enemy XP drop
    public int enemyXP = 100;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if ((BattleSystem.whichturn==3) && (gameObject.name == "slime"))
        {

            GetComponent<Rigidbody>().velocity = new Vector2(-6, 0);
            StartCoroutine(enemyReturn());
            BattleSystem.whichturn = 4;
        }
        if ((BattleSystem.whichturn == 5) && (gameObject.name == "slime2"))
        {

            GetComponent<Rigidbody>().velocity = new Vector2(-6, 0);
            StartCoroutine(enemyReturn());
            BattleSystem.whichturn = 1;
        }
        if ((BattleSystem.damageDisplay == "y") &&  (gameObject.name == BattleSystem.selectedEnemy))
        {
            enemyHP -= BattleSystem.currentDamage;
            Instantiate(hitEffectObj, transform.position, hitEffectObj.rotation);
            Debug.Log(gameObject.name + " " + enemyHP);
            BattleSystem.damageDisplay = "n";
        }
         if (enemyHP <=0)
        {
            BattleSystem.archerTotalXP += enemyXP;
            BattleSystem.studentTotalXP += enemyXP;
            Debug.Log("Archer XP " + BattleSystem.archerTotalXP + " Student XP " + BattleSystem.studentTotalXP);
            Destroy(gameObject);
           
        }
       
    }
    IEnumerator enemyReturn()
    {
        yield return new WaitForSeconds(1.5f);

        // modify if you to add enemy
        if(BattleSystem.whichturn == 4)
        {
            BattleSystem.whichturn = 5;
        }
       


        heroattk = Random.Range(1, 3);
        
       
        if (BattleSystem.enemyStatus1 == "dead")
        {
            enemyAttk = 5;
        }

        if (BattleSystem.enemyStatus2 == "dead")
        {
            enemyAttk = 3;
        }
        // check kung patay na ung hero
        if (BattleSystem.archerStatus == "dead")
        {
            heroattk = 2;
        }
        if (BattleSystem.studentStatus == "dead")
        {
            heroattk = 1;
        }

        // random attk ng hero
        if (heroattk == 1)
        {
            ArcherCon.archerHP -= enemyAttk;
            Instantiate(hitEffectObj, new Vector2(-6.74f,-3.77f), hitEffectObj.rotation);
        }
        else
        {
            StudentControl.studentHP -= enemyAttk;
            Instantiate(hitEffectObj, new Vector2(-6.69f,-1.41f), hitEffectObj.rotation);
        }

        Debug.Log("archer HP" + ArcherCon.archerHP);
        Debug.Log("student HP" + StudentControl.studentHP);
        GetComponent<Rigidbody>().velocity = new Vector2(0, 0);

        if(gameObject.name == "slime")
        {
            GetComponent<Transform>().position = new Vector2(4.95f, -1.36f);
        }
        if (gameObject.name == "slime2")
        {
            GetComponent<Transform>().position = new Vector2(4.95f, -3.82f);
        }


    }
     void OnMouseDown()
    {
       // Debug.Log(gameObject.name);
        BattleSystem.selectedEnemy = gameObject.name;
    }
}
