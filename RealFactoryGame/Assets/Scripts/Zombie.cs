using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject player;
    public GameObject zombert;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zombert.transform.position = Vector3.MoveTowards(zombert.transform.position, player.transform.position, 10);
    }
}