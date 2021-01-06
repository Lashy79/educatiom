using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameRotation : MonoBehaviour
{   

    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector3 rotation = this.gameObject.transform.eulerAngles;
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x -= Input.GetAxis("Mouse Y");
        this.gameObject.transform.eulerAngles = rotation;
      

    }
}
