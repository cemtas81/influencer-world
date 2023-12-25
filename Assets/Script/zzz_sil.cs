using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzz_sil : MonoBehaviour
{
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void deneme()
    {
        i++;
        if (i == 6)
            i = 0;
        for(int t=0;t<transform.childCount;t++)
        {
            gameObject.transform.GetChild(t).gameObject.SetActive(false);
        }
        gameObject.transform.GetChild(i).gameObject.SetActive(true);
    }
}
