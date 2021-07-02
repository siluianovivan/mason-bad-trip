using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeOne : MonoBehaviour
{
    public GameObject episodeOne;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PPlayer"))
        {
            episodeOne.SetActive(true);
            Destroy(gameObject, 2f);
        }
    }
}
