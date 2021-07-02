using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeFive : MonoBehaviour
{
    public GameObject episodeFive;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PPlayer"))
        {
            episodeFive.SetActive(true);
            Destroy(gameObject, 2f);
        }
    }
}
