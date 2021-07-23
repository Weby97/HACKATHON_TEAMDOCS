using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public float speed = 20f;
    public bool touchingObject;
    public Transform playerBody;
    public Transform zombie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float difX = playerBody.transform.position.x - zombie.transform.position.x;
        //float difZ = playerBody.transform.position.z - zombie.transform.position.z;
        var lookPos = playerBody.position - transform.position;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
        transform.Translate(zombie.right * speed * Time.deltaTime);
    }
}
