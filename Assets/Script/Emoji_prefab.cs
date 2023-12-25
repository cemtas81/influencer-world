using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class Emoji_prefab : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject obje = GameObject.Find("Disko_Panel").gameObject;
       // transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = "+" + AllPP.ekenecek_para;
        if(Disko_Panel.durum==1)
        {
            //Debug.Log("basarili" + Disko_Panel.durum);
            int rnd = Random.Range(0, obje.GetComponent<Disko_Panel>().basarili_emoji.Length);

            gameObject.GetComponent<SpriteRenderer>().sprite = obje.GetComponent<Disko_Panel>().basarili_emoji[rnd];
        }
        else if (Disko_Panel.durum == 2)
        {
           // Debug.Log("basarisiz" + Disko_Panel.durum);
            int rnd = Random.Range(0, obje.GetComponent<Disko_Panel>().basarisiz_emoji.Length);

            gameObject.GetComponent<SpriteRenderer>().sprite = obje.GetComponent<Disko_Panel>().basarisiz_emoji[rnd];
        }
       else
        {
           // Debug.Log("------" + Disko_Panel.durum);
        }
        StartCoroutine(konum_ayar());

    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator konum_ayar()
    {
        int rnd2 = Random.Range(0, 4);
        if(rnd2==0)
        {
            gameObject.transform.DOScale(new Vector3(0.05f, 0.05f, 0.05f), 0);
        }
        else if(rnd2==1)
        {
            gameObject.transform.DOScale(new Vector3(0.055f, 0.055f, 0.055f), 0);
        }
        else if (rnd2 == 2)
        {
            gameObject.transform.DOScale(new Vector3(0.06f, 0.06f, 0.06f), 0);
        }
        else if (rnd2 == 3)
        {
            gameObject.transform.DOScale(new Vector3(0.065f, 0.065f, 0.065f), 0);
        }
       
        int rnd = Random.Range(-2, 2);
        // GetComponent<SpriteRenderer>().DOColor(new Vector4(1,1,1,0), 3f);
        // transform.GetChild(0).GetComponent<TextMesh>().DOKill = new Vector4(1, 1, 1, 1);
        transform.DOLocalMove(new Vector3(rnd, 7, 0), 15f);
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

}
