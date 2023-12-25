
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;
using UnityEngine.SceneManagement;
using DG.Tweening;
using MoreMountains.NiceVibrations;


    public class Kiyafetodasi : MonoBehaviour
    {
        private GameObject dolap_sol_kapi, dolap_sag_kapi;
        public Animator anim;
        public Slider anim_slider;
        public Scrollbar scrollbar;
        public Camera kamera;
        public GameObject dolap1_kamera, dolap2_kamera, dolap3_kamera, ayakkabilik_kamera, makyajmasasi_kamera;
        public GameObject geri_button;
        public GameObject kamera_anim_plan;
        public const float MAX_SWIPE_TIME = 0.3f;
        float startTime;
        bool kontrol_bool;
        
        public float line_deger;
        public bool bak,bak2;
        public GameObject dolap1_collider, dolap2_collider,dolap3_collider,ayakkabilar_collider,makyaj_masasi_collider;  
        public GameObject dolap1_line, dolap2_line, dolap3_line, raf1_line, raf2_line, raf3_line, raf4_line, masa_line;
        public GameObject dolap1, dolap2, dolap3, makyaj_masasi, ayakkabilar;
        private bool dokunma;
        
        // Start is called before the first frame update
        void Start()
        {
            dokunma = false;

            dolap1_collider.SetActive(false);
            dolap2_collider.SetActive(false);
            dolap3_collider.SetActive(false);
            ayakkabilar_collider.SetActive(false);
            makyaj_masasi_collider.SetActive(false);

            bak = true;
            bak2 = true;
            line_deger = 0f;
            kamera_anim_plan.SetActive(true);
            kontrol_bool = false;
            anim = anim.GetComponent<Animator>();
            geri_button.SetActive(false);
           // oda_button.SetActive(true);
            scrollbar.value = 0.66f;

    }
        private void Awake()
        {
            scrollbar.value = 0.66f;

        }
        // Update is called once per frame
        void Update()
        {
        if(kamera.gameObject.activeSelf)
        {
            if (bak)
            {
                line_deger += Time.deltaTime * 2;
            }
            else
            {
                line_deger -= Time.deltaTime * 2;
            }
            if (line_deger > 1)
            {
                bak = false;
            }
            if (line_deger < 0)
            {
                bak = true;
            }
        }
        if (kontrol_bool&&kamera.gameObject.activeSelf)
            {
                anim_slider.value = (1 - scrollbar.value);
                anim.Play("Base Layer.giyinme_odasi_anim", 0, anim_slider.value);
                if (Input.touches.Length > 0)
                {
                    Touch parmak = Input.GetTouch(0);
                    if (parmak.phase == TouchPhase.Began)
                    {
                        startTime = Time.time;
                    }
                    if (parmak.phase == TouchPhase.Ended)
                    {
                        if (Time.time - startTime < MAX_SWIPE_TIME) // dokunma işlemiyse
                        {
                            RaycastHit dokunulanNesne;
                            if (Physics.Raycast(kamera.ScreenPointToRay(parmak.position), out dokunulanNesne))
                            {
                                //Debug.Log("" + dolap1_kamera.name);
                                if (dokunulanNesne.collider.gameObject.name == dolap1_kamera.tag)
                                {
                                    collider_ackapa(dolap1_collider);
                                    dolap1.GetComponent<BoxCollider>().enabled = false;
                                    //oda_button.SetActive(false);
                                    kamera_anim_plan.SetActive(false);
                                    kontrol_bool = false;
                                    StartCoroutine(kamera_ac());
                                    dolap1_kamera.SetActive(true);
                                    dolap2_kamera.SetActive(false);
                                    dolap3_kamera.SetActive(false);
                                    makyajmasasi_kamera.SetActive(false);
                                    ayakkabilik_kamera.SetActive(false);
                                    bak2 = false;
                                   
                                }
                                else if (dokunulanNesne.collider.gameObject.name == dolap2_kamera.tag)
                                {
                                    collider_ackapa(dolap2_collider);
                                    dolap2.GetComponent<BoxCollider>().enabled = false;
                                    //oda_button.SetActive(false);
                                    kamera_anim_plan.SetActive(false);
                                    kontrol_bool = false;
                                StartCoroutine(kamera_ac());
                                dolap1_kamera.SetActive(false);
                                    dolap2_kamera.SetActive(true);
                                    dolap3_kamera.SetActive(false);
                                    makyajmasasi_kamera.SetActive(false);
                                    ayakkabilik_kamera.SetActive(false);
                                    bak2 = false;
                                    

                            }
                                else if (dokunulanNesne.collider.gameObject.name == dolap3_kamera.tag)
                                {
                                    collider_ackapa(dolap3_collider);
                                    dolap3.GetComponent<BoxCollider>().enabled = false;
                                    //oda_button.SetActive(false);
                                    kamera_anim_plan.SetActive(false);
                                    kontrol_bool = false;
                                StartCoroutine(kamera_ac());
                                dolap1_kamera.SetActive(false);
                                    dolap2_kamera.SetActive(false);
                                    dolap3_kamera.SetActive(true);
                                    ayakkabilik_kamera.SetActive(false);
                                    makyajmasasi_kamera.SetActive(false);
                                     bak2 = false;
                               
                            }
                                else if (dokunulanNesne.collider.gameObject.name == ayakkabilik_kamera.tag)
                                {
                                    collider_ackapa(ayakkabilar_collider);
                                    ayakkabilar.GetComponent<BoxCollider>().enabled = false;
                                    //oda_button.SetActive(false);
                                    kamera_anim_plan.SetActive(false);
                                    kontrol_bool = false;
                                StartCoroutine(kamera_ac());
                                dolap1_kamera.SetActive(false);
                                    dolap2_kamera.SetActive(false);
                                    dolap3_kamera.SetActive(false);
                                    ayakkabilik_kamera.SetActive(true);
                                    makyajmasasi_kamera.SetActive(false);
                                    bak2 = false;
                                
                            }
                                else if (dokunulanNesne.collider.gameObject.name == makyajmasasi_kamera.tag)
                                {
                                    collider_ackapa(makyaj_masasi_collider);
                                    makyaj_masasi.GetComponent<BoxCollider>().enabled = false;
                                    //oda_button.SetActive(false);
                                    kamera_anim_plan.SetActive(false);
                                    kontrol_bool = false;
                                    StartCoroutine(kamera_ac());
                                    dolap1_kamera.SetActive(false);
                                    dolap2_kamera.SetActive(false);
                                    dolap3_kamera.SetActive(false);
                                    ayakkabilik_kamera.SetActive(false);
                                    makyajmasasi_kamera.SetActive(true);
                                    bak2 = false;
                                    
                            }
                            }
                        }
                    }
                }
            }
        if(dokunma && kamera.gameObject.activeSelf)
        {
            if (Input.touches.Length > 0)
            {
                Touch parmak = Input.GetTouch(0);
                RaycastHit dokunulanNesne;
                if (Physics.Raycast(kamera.ScreenPointToRay(parmak.position), out dokunulanNesne))
                {
                   
                    foreach (Kiyafet_alma obje in Resources.FindObjectsOfTypeAll<Kiyafet_alma>())
                    {
                        if(obje.name==dokunulanNesne.collider.gameObject.name&&PlayerPrefs.GetInt(""+obje.name) == 1)
                        {
                            //Debug.Log("**dokunulan nesene=" + obje.gameObject.name);
                            obje.gameObject.GetComponent<Kiyafet_alma>().kiyafet_al();//kiyafet_al();
                            geri_don();
                        }
                        //
                    }
                }
            }
        }
       
        if(bak2)//parlama aç
        {
            if (kamera.gameObject.transform.eulerAngles.y < 40 && kamera.gameObject.transform.eulerAngles.y > 11)
            {
                dolap1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, line_deger);
                dolap1_line.GetComponent<Outline2>().needsUpdate = true;
                dolap2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap2_line.GetComponent<Outline2>().needsUpdate = true;
                dolap3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap3_line.GetComponent<Outline2>().needsUpdate = true;
                raf1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf1_line.GetComponent<Outline2>().needsUpdate = true;
                raf2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf2_line.GetComponent<Outline2>().needsUpdate = true;
                raf3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf3_line.GetComponent<Outline2>().needsUpdate = true;
                raf4_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf4_line.GetComponent<Outline2>().needsUpdate = true;
                masa_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                masa_line.GetComponent<Outline2>().needsUpdate = true;
            }
            else if (kamera.transform.eulerAngles.y < 52 && kamera.transform.eulerAngles.y > 40)
            {
                dolap1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap1_line.GetComponent<Outline2>().needsUpdate = true;
                dolap2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, line_deger);
                dolap2_line.GetComponent<Outline2>().needsUpdate = true;
                dolap3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap3_line.GetComponent<Outline2>().needsUpdate = true;
                raf1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf1_line.GetComponent<Outline2>().needsUpdate = true;
                raf2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf2_line.GetComponent<Outline2>().needsUpdate = true;
                raf3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf3_line.GetComponent<Outline2>().needsUpdate = true;
                raf4_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf4_line.GetComponent<Outline2>().needsUpdate = true;
                masa_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                masa_line.GetComponent<Outline2>().needsUpdate = true;
            }
            else if (kamera.transform.eulerAngles.y < 69 && kamera.transform.eulerAngles.y > 52)
            {
                dolap1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap1_line.GetComponent<Outline2>().needsUpdate = true;
                dolap2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap2_line.GetComponent<Outline2>().needsUpdate = true;
                dolap3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, line_deger);
                dolap3_line.GetComponent<Outline2>().needsUpdate = true;
                raf1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf1_line.GetComponent<Outline2>().needsUpdate = true;
                raf2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf2_line.GetComponent<Outline2>().needsUpdate = true;
                raf3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf3_line.GetComponent<Outline2>().needsUpdate = true;
                raf4_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf4_line.GetComponent<Outline2>().needsUpdate = true;
                masa_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                masa_line.GetComponent<Outline2>().needsUpdate = true;
            }
            else if (kamera.transform.eulerAngles.y < 98 && kamera.transform.eulerAngles.y > 69)
            {
                dolap1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap1_line.GetComponent<Outline2>().needsUpdate = true;
                dolap2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap2_line.GetComponent<Outline2>().needsUpdate = true;
                dolap3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap3_line.GetComponent<Outline2>().needsUpdate = true;
                raf1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, line_deger);
                raf1_line.GetComponent<Outline2>().needsUpdate = true;
                raf2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, line_deger);
                raf2_line.GetComponent<Outline2>().needsUpdate = true;
                raf3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, line_deger);
                raf3_line.GetComponent<Outline2>().needsUpdate = true;
                raf4_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, line_deger);
                raf4_line.GetComponent<Outline2>().needsUpdate = true;
                masa_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                masa_line.GetComponent<Outline2>().needsUpdate = true;
            }
            else if (kamera.transform.eulerAngles.y < 126 && kamera.transform.eulerAngles.y > 98)
            {
                dolap1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap1_line.GetComponent<Outline2>().needsUpdate = true;
                dolap2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap2_line.GetComponent<Outline2>().needsUpdate = true;
                dolap3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                dolap3_line.GetComponent<Outline2>().needsUpdate = true;
                raf1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf1_line.GetComponent<Outline2>().needsUpdate = true;
                raf2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf2_line.GetComponent<Outline2>().needsUpdate = true;
                raf3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf3_line.GetComponent<Outline2>().needsUpdate = true;
                raf4_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
                raf4_line.GetComponent<Outline2>().needsUpdate = true;
                masa_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, line_deger);
                masa_line.GetComponent<Outline2>().needsUpdate = true;
            }
        }
        else//parlama kapa
        {
            dolap1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
            dolap1_line.GetComponent<Outline2>().needsUpdate = true;
            dolap2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
            dolap2_line.GetComponent<Outline2>().needsUpdate = true;
            dolap3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
            dolap3_line.GetComponent<Outline2>().needsUpdate = true;
            raf1_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
            raf1_line.GetComponent<Outline2>().needsUpdate = true;
            raf2_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
            raf2_line.GetComponent<Outline2>().needsUpdate = true;
            raf3_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
            raf3_line.GetComponent<Outline2>().needsUpdate = true;
            raf4_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
            raf4_line.GetComponent<Outline2>().needsUpdate = true;
            masa_line.GetComponent<Outline2>().outlineColor = new Vector4(0, 1, 0, 0);
            masa_line.GetComponent<Outline2>().needsUpdate = true;


           /* dolap1_collider.SetActive(false);
            dolap2_collider.SetActive(false);
            dolap3_collider.SetActive(false);
            ayakkabilar_collider.SetActive(false);
            makyaj_masasi_collider.SetActive(false);

            ayakkabilar.GetComponent<BoxCollider>().enabled = true;
            dolap1.GetComponent<BoxCollider>().enabled = true;
            dolap2.GetComponent<BoxCollider>().enabled = true;
            dolap3.GetComponent<BoxCollider>().enabled = true;
            makyaj_masasi.GetComponent<BoxCollider>().enabled = true;*/
        }
 
    }



    public IEnumerator kamera_ac()
    {
       
        yield return new WaitForSeconds(2);
        dokunma = true;
        geri_button.SetActive(true);
    }

    public void geri_don()
        {
        GameObject.Find("Main Camera").GetComponent<AlllGame>().button_ses_fok();
        //oda_button.SetActive(true);
            kontrol_bool = true;
            kamera_anim_plan.SetActive(true);
            geri_button.SetActive(false);
            dolap1_kamera.SetActive(false);
            dolap2_kamera.SetActive(false);
            dolap3_kamera.SetActive(false);
            makyajmasasi_kamera.SetActive(false);
            ayakkabilik_kamera.SetActive(false);
            scrollbar.value = 0.66f;
            bak2 = true;
            ayakkabilar.GetComponent<BoxCollider>().enabled = true;
            dolap1.GetComponent<BoxCollider>().enabled = true;
            dolap2.GetComponent<BoxCollider>().enabled = true;
           dolap3.GetComponent<BoxCollider>().enabled = true;
        makyaj_masasi.GetComponent<BoxCollider>().enabled = true;
        dolap1_collider.SetActive(false);
        dolap2_collider.SetActive(false);
        dolap3_collider.SetActive(false);
        ayakkabilar_collider.SetActive(false);
        makyaj_masasi_collider.SetActive(false);
        dokunma = false;
    }
        public void dolap_ac()
        {
            dolap_sag_kapi.GetComponent<Animator>().SetTrigger("ac");
            dolap_sol_kapi.GetComponent<Animator>().SetTrigger("ac");

        }
        public void dolap_kapa()
        {
            dolap_sag_kapi.GetComponent<Animator>().SetTrigger("kapa");
            dolap_sol_kapi.GetComponent<Animator>().SetTrigger("kapa");
        }
        public void collider_ackapa(GameObject obje)
        {
        dolap1_collider.SetActive(false);
        dolap2_collider.SetActive(false);
        dolap3_collider.SetActive(false);
        ayakkabilar_collider.SetActive(false);
        makyaj_masasi_collider.SetActive(false);
        obje.SetActive(true);
    }
        
    }
