using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeSix : MonoBehaviour
{
    public GameObject episodeSix;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PPlayer"))
        {
            episodeSix.SetActive(true);
            Destroy(gameObject, 2f);
        }
    }
}
