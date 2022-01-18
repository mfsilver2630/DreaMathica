using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector2(4, 0);
        Destroy(gameObject, 1.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
