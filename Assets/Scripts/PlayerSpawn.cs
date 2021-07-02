using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject serverText;
    public GameObject player;
    private void Update()
    {
        if (serverText == null)
        {
            player.SetActive(true);
        } 
    }
}
