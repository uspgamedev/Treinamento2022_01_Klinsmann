using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXplaying : MonoBehaviour
{
    public AudioSource player_taking_damage;

    public void Playplayer_taking_damage()
    {
        player_taking_damage.Play();
    }
}
