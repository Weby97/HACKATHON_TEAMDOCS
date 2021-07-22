using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    public GameObject sun;
    public bool isday = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        sun.transform.Rotate(new Vector3(0.5f*Time.deltaTime,0,0));

        if (sun.transform.rotation.eulerAngles.x < 0)
        {
            isday = false;
        }else
        {
            isday = !false;
        }
    }
}