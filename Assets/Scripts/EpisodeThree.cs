using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeThree : MonoBehaviour
{
    public GameObject episodeThree;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PPlayer"))
        {
            episodeThree.SetActive(true);
            Destroy(gameObject, 2f);
        }
    }
}
