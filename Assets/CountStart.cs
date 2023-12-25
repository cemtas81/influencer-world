using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountStart : MonoBehaviour
{
    float crtime = 0f;
    float sttime = 3f;
    private Text cttext;
    // Start is called before the first frame update
    void Start()
    {
        crtime = sttime;
        cttext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (crtime >= 0)
        {
            crtime -= 1 * Time.deltaTime;
            cttext.text = crtime.ToString("0");
        }

        else
            cttext.enabled = false;
        
    }
}
