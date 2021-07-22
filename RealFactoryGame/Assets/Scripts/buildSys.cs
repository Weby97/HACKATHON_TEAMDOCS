using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildSys : MonoBehaviour
{ 
    public GameObject anchor;
    public Camera playerCamera;
    public buildInvScrp buildScript;//build script

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "anchor" && Input.GetMouseButtonDown(0) && buildScript.currentItem().holdingObj && buildScript.idaho && buildScript.currentItem().ammount > 0)//check if player is holding an obj
            {
                Instantiate(buildScript.currentItem().main, hit.point, Quaternion.identity);
                buildScript.removeCurrentItem();//remove item
            }
        }        
    }
}
