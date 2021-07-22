using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildInvScrp : MonoBehaviour
{
    public GameObject[] mains = new GameObject[2];
    public string[] names = new string[2];
    public item[] items;
    
    public int index = 0;
    public bool idaho;

    // Start is called before the first frame update
    void Start()
    {
        items = new item[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            items[i].main = mains[i];
            items[i].name = names[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (index == -1)
        {
            idaho = false;
        }else
        {
            idaho = true;

            for (int i = 0; i < items.Length; i++)
            {
                items[i].update();
            }
        }
    }

    public item currentItem()
    {
        return(items[index]);
    }

    public void removeCurrentItem()
    {
        if (items[index].ammount>0)
        {
            items[index].ammount--;
        }else
        {
            Debug.Log("you did a bad : ammount in less than 1");
        }
    }

    public class  item {
        public GameObject main;
        public string name;
        public int ammount;  
        public bool holdingObj; 

        public void update()
        {
            if (ammount < 1)
            {
                holdingObj = true;
            }
        }     
    }
}
