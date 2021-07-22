using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    public bool isInTimer = true;
    public int Moon_Phase = 0;
    public int T_ime = 0;
    public bool IsDay = true;
    public GameObject Light;
    // Start is called before the first frame update
    IEnumerator start()
    {
        for (int i = 0; i == i; i++)
        {
            //code block
            yield return new WaitForSeconds(15);

        }
    }
    IEnumerator wait()
    {
        isInTimer = true;
        yield return new WaitForSeconds(60);
        Debug.Log(T_ime);
        if (T_ime == 24)
        {
            T_ime = 0;
        }
        if (T_ime == 0)
        {
            IsDay = true;
        }
        if (T_ime == 17)
        {
            IsDay = false;
        }
        T_ime++;
        isInTimer = false;
    }

    // Update is called once per frame

}
