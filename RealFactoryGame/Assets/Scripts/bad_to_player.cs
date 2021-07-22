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
        body.transform.position = new Vector3(agent.nextPosition.x,agent.transform.position.y,agent.nextPosition.z);
        agent.SetDestination(target.transform.position);
        Quaternion rotation;
        Vector3 targetPos = computeRotation(90, 0.05f, target.transform.position, target.transform.forward);

        rotation = Quaternion.LookRotation(targetPos - transform.position);

        
        agent.speed = speed;
    }
    Vector3 computeRotation(float degrees, float distance, Vector3 origin, Vector3 forward)
    {
        Quaternion rotation;
        Vector3 direction;
        Vector3 result;

        rotation = Quaternion.AngleAxis(degrees, Vector3.up);
        direction = rotation * forward * distance;
        result = origin + direction;

        return result;
    }
}

