using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilk_bilgisayar : MonoBehaviour
{
    public GameObject obje;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < obje.transform.childCount; i++)
        {
            if(obje.transform.GetChild(i).gameObject.activeSelf)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < obje.transform.childCount; i++)
        {
            if (obje.transform.GetChild(i).gameObject.activeSelf)
            {
                Destroy(gameObject);
            }
        }
    }
}
