using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    public GameObject sun;
    public bool isday = true;
    public string[] mooncycle;
    public Quaternion currentRotation;
    public int index;
    
    // Start is called before the first frame update
    void Start()
    {
            yield return new WaitForSeconds(15);

        
    }
    // Update is called once per frame
    void Update()
    {
        sun.transform.Rotate(new Vector3(0.5f*Time.deltaTime,0,0));

        if (index == mooncycle.Length)
        {
            index = 0;
        }

        if (sun.transform.rotation.eulerAngles.x > 180 )
        {
            isday = false;
        }else
        {
            isday = !false;
        }

        if (sun.transform.rotation.eulerAngles.x >= 360)
        {
            currentRotation.eulerAngles = Vector3.zero;
            sun.transform.rotation = currentRotation;
            index++;
            Debug.Log(mooncycle[index]);
        }
    }
}