using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterScript : MonoBehaviour
{
    public GameObject bullet;
    public bool canShoot;
    public float timeUntilNextShot;
    public float timeBetweenShots = 0.2f;
    public float shotsFired = 0;
    public bool needReload = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeUntilNextShot && needReload == false)
        {
            canShoot = true;
        }
        if(Input.GetMouseButtonDown(0) && canShoot)
        {
            canShoot = false;
            shotsFired++;
            timeUntilNextShot = Time.time + timeBetweenShots;
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            if (shotsFired >= 10)
            {
                needReload = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            shotsFired = 0;
            needReload = false;
        }
    }
}
