using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class deneme : MonoBehaviour
{
    public GameObject obje;
    
    // Start is called before the first frame update
    void Start()
    {
        //obje.transform.DOLocalMove(new Vector3(0, 700, 0), 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }






    public void kill()
    {
        //Debug.Log("girdim");
        obje.transform.DOKill();
    }
}
