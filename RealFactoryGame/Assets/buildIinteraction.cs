using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildIinteraction : MonoBehaviour
{
    public interaction interaction;
    public GameObject safePoint;
    public buildInvScrp buildscript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction.active && buildscript.idaho)
        {
            interaction.active = false;
            interaction.enabled = false;

            if (buildscript.crci)
            {
                buildscript.removeCurrentItem();
                Instantiate(buildscript.currentItem(), safepoint.transform.position, Quaternion.identity);
            }
        }    
    }
}
