using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_color : MonoBehaviour
{
    public Color myColor;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = myColor;
        

        
    
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
