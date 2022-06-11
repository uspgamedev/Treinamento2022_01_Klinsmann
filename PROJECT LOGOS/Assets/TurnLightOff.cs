using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOff : MonoBehaviour
{
    public GameObject barrier;
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Player")
        {
            player.gameObject.GetComponent<PlayerAtributes>().pointLight2D.SetActive(false);
            barrier.SetActive(true); 
        }   

    }     

}
