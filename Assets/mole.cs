using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mole : MonoBehaviour

{


    Vector3 nextpos;
    public float top = 4.8f;
    public float bottom = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {        
        nextpos = new Vector3(transform.localPosition.x, top, transform.localPosition.z);
    }



    // Update is called once per frame
    void Update()
    {    
        if (transform.position.y == top)
            nextpos.y = bottom;

        if (transform.position.y == bottom)
            nextpos.y = top;

        transform.position = Vector3.MoveTowards(transform.position, nextpos, Time.deltaTime * 4);

    }

    public void Disp()
    {
        Debug.Log(transform.name);
    }
}


