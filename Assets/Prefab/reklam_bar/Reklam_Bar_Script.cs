using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Reklam_Bar_Script : MonoBehaviour
{
    public GameObject imlec;
    private float imlec_sayac;
    private bool imlec_sayac_bool,controlbool;
    public float imlec_sure;
    public static int bar_deger;
    public Text bar_deger_text;
    // Start is called before the first frame update
   public void Start()
    {
        imlec.transform.DORotate(new Vector3(0, 0, 40), 0);
        imlec_sure = 1;
        controlbool = true;
        imlec_sayac_bool = true;
        imlec_sayac = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(controlbool)
        {
            if (imlec_sayac > imlec_sure)
            {
                imlec_sayac = 0;
                if (imlec_sayac_bool)
                {
                    imlec_sayac_bool = false;
                    imlec.transform.DORotate(new Vector3(0, 0, -40), imlec_sure).SetEase(Ease.Linear);
                }
                else
                {
                    imlec_sayac_bool = true;
                    imlec.transform.DORotate(new Vector3(0, 0, 40), imlec_sure).SetEase(Ease.Linear);
                }
            }

            imlec_sayac += Time.deltaTime;
        }
        bar_deger_text.text = "+" + bar_deger+"%";
    }

    public void button_click()
    {
        controlbool = false;
        imlec.transform.DOKill();
        StartCoroutine(reklam_izlet());
    }

    public IEnumerator reklam_izlet()
    {
        yield return new WaitForSeconds(1f);
        GameObject.Find("Disko_Panel").GetComponent<Disko_Panel>().x2_odul_reklam_izlet();
    }
}
