using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard2 : MonoBehaviour
{
    void OnEnable()
    {
        if (!GetComponent<SpriteRenderer>().isVisible)
        {
            enabled = false;
        }
    }

    void LateUpdate()
    {
        transform.forward = Camera.main.transform.forward;
    }

    void OnBecameVisible()
    {
        enabled = true;
    }

    void OnBecameInvisible()
    {
        enabled = false;
    }
}
