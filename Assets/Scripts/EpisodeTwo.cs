using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeTwo : MonoBehaviour
{
    public GameObject episodeTwo;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PPlayer"))
        {
            episodeTwo.SetActive(true);
            Destroy(gameObject, 2f);
        }
    }
}
