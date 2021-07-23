using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject spawn;
    public bool isInTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator wait(float time)
    {
        isInTimer = true;
        yield return new WaitForSeconds(time);
        isInTimer = false;
    } 

    // Update is called once per frame
    void Update()
    {
        wait(4f);
        Instantiate(spawn, transform.position, Quaternion.identity);
    }
}
