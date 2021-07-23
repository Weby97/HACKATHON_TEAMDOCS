using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildinteraction : MonoBehaviour
{
    public bool active;
    private bool isInTimer = false;
    public GameObject ui;
    public Vector3 hitpoint;

    void Update()
    {
        if (!isInTimer && active)
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
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click...");
        }
        active = false;
        StartCoroutine(wait(0.1232f));
    }
}
