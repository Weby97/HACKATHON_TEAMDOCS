using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret_behaveyor : MonoBehaviour
{
    public bool active = true;
    public bool sleeping = true;

    public int health = 200;

    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(self);
        }
    }
}
