using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bad_to_player : MonoBehaviour
{ 
    public GameObject body;
    public GameObject target;
    public UnityEngine.AI.NavMeshAgent agent;
    public aas7 scrp;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }
 
    // Update is called once per frame
    void Update()
    {
        body.transform.position = new Vector3(agent.nextPosition.x,agent.transform.position.y+1,agent.nextPosition.z);
        agent.SetDestination(target.transform.position);
        agent.speed = speed;
    }
}

