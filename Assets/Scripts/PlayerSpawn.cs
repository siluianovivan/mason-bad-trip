using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject serverText;
    public GameObject player;
    public PlayableDirector director;
    private void Update()
    {
        
        if (serverText == null)
        {
            player.SetActive (true);
           director.gameObject.SetActive (true);

           director.Play();
        } 
        
    }
}
