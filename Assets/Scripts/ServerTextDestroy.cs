using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerTextDestroy : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.activeSelf)
        {
            Destroy(gameObject, 6f);
        }
    }
}
