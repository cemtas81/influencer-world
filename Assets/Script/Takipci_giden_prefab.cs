using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class Takipci_giden_prefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = "-" + AllPP.ektakipci_giden;
        StartCoroutine(konum_ayar());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator konum_ayar()
    {
        int rnd = Random.Range(-3, 4);
        //  GetComponent<SpriteRenderer>().DOColor(new Vector4(1, 1, 1, 0), 3f);
        transform.DOLocalMove(new Vector3(rnd, 7, 0), 5f);
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

}
