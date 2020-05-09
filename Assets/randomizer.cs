using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour

{
    public GameObject container;
    mole [] m;
    private int index;
    private bool x;
    float x1;
    // Start is called before the first frame update
    void Start()
    {
        m = container.GetComponentsInChildren<mole>();      
       
    }

    // Update is called once per frame
    void Update()
    {
        x1 += Time.deltaTime;
        
        if(x1 >= 0.9f)
        {
            x = false;
            if ( m[index].transform.position.y <= (m[index].bottom+0.1f))
            {
                m[index].enabled = false;                
                x = true;
            }

            if (x)
            {
                index = Random.Range(0, m.Length);
                m[index].enabled = true;
                x1 = 0;
            }
            

       }
        
        
            
           







    }
    public void next()
    {
       

        
        

    }
    
}
