using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public bool active;
    private bool isInTimer = false;

    void Update()
    {
        if (!isInTimer)
        {
            timedUpdate();
        }
    }
    IEnumerator wait(float time)
    {
        isInTimer = true;
        yield return new WaitForSeconds(time);
        isInTimer = false;
    } 
    void timedUpdate()
    {
        if (Input.GetKey("e"))
        {
            Debug.Log("E...");
            active = true;
        }else
        {
            active = !true;
        }
        StartCoroutine(wait(0.1232f));
    }
}
