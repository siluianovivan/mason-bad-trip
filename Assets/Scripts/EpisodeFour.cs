using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeFour : MonoBehaviour
{
    public GameObject episodeFour;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PPlayer"))
        {
            episodeFour.SetActive(true);
            Destroy(gameObject, 2f);
        }
    }
}
