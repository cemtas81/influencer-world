using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Para_prefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = "+" + System.Convert.ToString(AllPP.ekpara.ToString("N0"));
        StartCoroutine(konum_ayar());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator konum_ayar()
    {
        int rnd = Random.Range(-3, 4);
       // GetComponent<SpriteRenderer>().DOColor(new Vector4(1,1,1,0), 3f);
       // transform.GetChild(0).GetComponent<TextMesh>().DOKill = new Vector4(1, 1, 1, 1);
        transform.DOLocalMove(new Vector3(rnd, 7,0), 5f);
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }



}
