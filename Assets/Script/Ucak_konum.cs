using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Ucak_konum : MonoBehaviour
{
    public GameObject[] konumlar;
    int sayac=0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void konum_degistir(GameObject konum)
    {
        //int rnd = Random.Range(0, konumlar.Length);
       // rnd = sayac;
        transform.right = konum.transform.position - transform.position;
        if(transform.localPosition.x> konum.transform.localPosition.x)
        {
            transform.Rotate(-180, 0, 0);
        }
        transform.DOLocalMove(konum.transform.localPosition,3f);
        StartCoroutine(scale_ayara());
       // sayac++;
    }
    public IEnumerator scale_ayara()
    {
        transform.DOScale(new Vector3(1.5f,1.5f,1.5f),0.25f);
        yield return new WaitForSeconds(2.25f);
        transform.DOScale(new Vector3(1, 1, 1), 0.25f);
    }
 

}
