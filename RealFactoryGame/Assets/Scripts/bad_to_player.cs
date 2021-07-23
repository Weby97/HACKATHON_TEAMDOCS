using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bad_to_player : MonoBehaviour
{ 
    public GameObject body;
    public GameObject target;
    public UnityEngine.AI.NavMeshAgent agent;
    public aas7 scrp;
    public float speed = 3f;
    public GameObject head;
    // Start is called before the first frame update
    void Start()
    {

    }
 
    // Update is called once per frame
    void Update()
    {
        //body.transform.position = new Vector3(agent.nextPosition.x,agent.transform.position.y,agent.nextPosition.z);
        //agent.SetDestination(target.transform.position);
        //agent.speed = speed;

        Vector3 headRot = new Vector3(head.transform.eulerAngles.x, head.transform.eulerAngles.y, head.transform.eulerAngles.z);
        Vector3 bodyRot = new Vector3(body.transform.eulerAngles.x, body.transform.eulerAngles.y, body.transform.eulerAngles.z);
        Vector3 dif = new Vector3(bodyRot.x, bodyRot.y + (headRot.y - bodyRot.y), bodyRot.z);
        body.transform.LookAt(target.transform.position, Vector3.up);
        //body.transform.rotation = Quaternion.Euler(dif);
        if (body.transform.position.x > (target.transform.position.x + 3) || body.transform.position.z > (target.transform.position.z + 3) ||
            body.transform.position.x < (target.transform.position.x -3) || body.transform.position.z < (target.transform.position.z - 3))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }

}

