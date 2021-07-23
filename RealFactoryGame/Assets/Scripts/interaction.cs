using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public bool active;
    public bool enabled = true;
    private bool isInTimer = false;

    void Update()
    {
        if (!isInTimer && active && enabled)
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
        }
        active = false;
        StartCoroutine(wait(0.1232f));
    }
}
