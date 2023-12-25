using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pozlar : MonoBehaviour
{
    private Animator anim;
    public Slider timeline;
    public Scrollbar scrollbar;
    public float[] poz_konum = { 0f,0.115f,0.32f,0.415f,0.54f,0.8f,1f};
    public int getir1, getir2,getir3;
    public int sayac;
    // Start is called before the first frame update
    void Awake()
    {
        var outline = gameObject.GetComponent<Outline2>();

        outline.OutlineMode = Outline2.Mode.OutlineAll;
        outline.OutlineColor = Color.yellow;
        outline.OutlineWidth = 5f;
        
    }
    private void Start()
    {
        sayac = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void poz_sec()
    {
        if(sayac==0)
        {
            anim = GetComponent<Animator>();
            // scrollbar.value = 1 - timeline.value;
            int random = Random.Range(0, poz_konum.Length);
            animasyon.pozlar_konum_nokta = random;
            anim.Play("Base Layer.mixamo_com", 0, poz_konum[random]);
            getir1 = random;
            pozgetir();
            sayac++;
        }
        else if(sayac == 1)
        {

            animasyon.pozlar_konum_nokta = getir2;
            anim.Play("Base Layer.mixamo_com", 0, poz_konum[getir2]);
            sayac++;
        }
        else if (sayac == 2)
        {

            animasyon.pozlar_konum_nokta = getir3;
            anim.Play("Base Layer.mixamo_com", 0, poz_konum[getir3]);
            sayac++;
        }
        else
        {
            sayac = 0;
            poz_sec();
        }
    }
    public void pozgetir()
    {
        if(getir1==0)
        {
            getir2 = 1;
            getir3 = 2;
        }
        else if(getir1 == 6)
        {
            getir2 = 5;
            getir3 = 4;
        }
        else
        {
            getir2 = getir1+1;
            getir3 = getir1-1;
        }

    }
}
