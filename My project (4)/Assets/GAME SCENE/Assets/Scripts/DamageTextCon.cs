using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTextCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 10;
        GetComponent<TextMesh>().text = BattleSystem.currentDamage.ToString();
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
