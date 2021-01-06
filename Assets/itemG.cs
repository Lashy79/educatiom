using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemG : MonoBehaviour
{
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        test = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        test.transform.position += new Vector3(-0.009f, 0, 0);

      
    }
}
