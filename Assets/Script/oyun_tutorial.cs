using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyun_tutorial : MonoBehaviour
{
    public GameObject[] bilgi_image;
    private int sayac;
    // Start is called before the first frame update
    void Start()
    {
        sayac = 0;
        for (int i = 0; i < bilgi_image.Length; i++)
        {
            bilgi_image[i].SetActive(false);
        }
        bilgi_image[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void tiklama()
    {
        sayac++;
        if(sayac<bilgi_image.Length)
        {
            for (int i = 0; i < bilgi_image.Length; i++)
            {
                bilgi_image[i].SetActive(false);
            }
            bilgi_image[sayac].SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("oyun_tutorial", 1);
            gameObject.SetActive(false);
        }
    }
}
