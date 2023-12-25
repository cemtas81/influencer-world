using UnityEngine;
using System.Collections;

public class example : MonoBehaviour {

    public GameObject ColorPickedPrefab;
    private ColorPickerTriangle CP;
    private bool isPaint = false;
    private GameObject go;
    private Material mat;
    public Material duvar_mat;
    public GameObject konum;
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        if(gameObject.name== "YatakOdasi")
        {
            if (gameObject.tag == "1")//duvar
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("drenk_h"), PlayerPrefs.GetFloat("drenk_v"), PlayerPrefs.GetFloat("drenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("drenk_h"), PlayerPrefs.GetFloat("drenk_v"), PlayerPrefs.GetFloat("drenk_s"));
                // Debug.Log("duvar h="+ PlayerPrefs.GetFloat("drenk_h")+"duvar s=" + PlayerPrefs.GetFloat("drenk_s")+"duvar v="+ PlayerPrefs.GetFloat("drenk_v"));

            }
            else if (gameObject.tag == "2")//zemin
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("zrenk_h"), PlayerPrefs.GetFloat("zrenk_v"), PlayerPrefs.GetFloat("zrenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("zrenk_h"), PlayerPrefs.GetFloat("zrenk_v"), PlayerPrefs.GetFloat("zrenk_s"));

                // Debug.Log("zemin h="+ PlayerPrefs.GetFloat("zrenk_h")+ "zemin s=" + PlayerPrefs.GetFloat("zrenk_s")+ "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));

            }
            else if (gameObject.tag == "3")//tavan
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("trenk_h"), PlayerPrefs.GetFloat("trenk_v"), PlayerPrefs.GetFloat("trenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("trenk_h"), PlayerPrefs.GetFloat("trenk_v"), PlayerPrefs.GetFloat("trenk_s"));

                //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));

            }
        }
        else if (gameObject.name == "Gym")
        {
            if (gameObject.tag == "1")//duvar
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("gym_drenk_h"), PlayerPrefs.GetFloat("gym_drenk_v"), PlayerPrefs.GetFloat("gym_drenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("gym_drenk_h"), PlayerPrefs.GetFloat("gym_drenk_v"), PlayerPrefs.GetFloat("gym_drenk_s"));
                // Debug.Log("duvar h="+ PlayerPrefs.GetFloat("drenk_h")+"duvar s=" + PlayerPrefs.GetFloat("drenk_s")+"duvar v="+ PlayerPrefs.GetFloat("drenk_v"));

            }
            else if (gameObject.tag == "2")//zemin
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("gym_zrenk_h"), PlayerPrefs.GetFloat("gym_zrenk_v"), PlayerPrefs.GetFloat("gym_zrenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("gym_zrenk_h"), PlayerPrefs.GetFloat("gym_zrenk_v"), PlayerPrefs.GetFloat("gym_zrenk_s"));

                // Debug.Log("zemin h="+ PlayerPrefs.GetFloat("zrenk_h")+ "zemin s=" + PlayerPrefs.GetFloat("zrenk_s")+ "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));

            }
            else if (gameObject.tag == "3")//tavan
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("gym_trenk_h"), PlayerPrefs.GetFloat("gym_trenk_v"), PlayerPrefs.GetFloat("gym_trenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("gym_trenk_h"), PlayerPrefs.GetFloat("gym_trenk_v"), PlayerPrefs.GetFloat("gym_trenk_s"));

                //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));

            }
        }
        else if (gameObject.name == "MuzikOdasi")
        {
            if (gameObject.tag == "1")//duvar
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("muzik_drenk_h"), PlayerPrefs.GetFloat("muzik_drenk_v"), PlayerPrefs.GetFloat("muzik_drenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("muzik_drenk_h"), PlayerPrefs.GetFloat("muzik_drenk_v"), PlayerPrefs.GetFloat("muzik_drenk_s"));
                // Debug.Log("duvar h="+ PlayerPrefs.GetFloat("drenk_h")+"duvar s=" + PlayerPrefs.GetFloat("drenk_s")+"duvar v="+ PlayerPrefs.GetFloat("drenk_v"));

            }
            else if (gameObject.tag == "2")//zemin
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("muzik_zrenk_h"), PlayerPrefs.GetFloat("muzik_zrenk_v"), PlayerPrefs.GetFloat("muzik_zrenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("muzik_zrenk_h"), PlayerPrefs.GetFloat("muzik_zrenk_v"), PlayerPrefs.GetFloat("muzik_zrenk_s"));

                // Debug.Log("zemin h="+ PlayerPrefs.GetFloat("zrenk_h")+ "zemin s=" + PlayerPrefs.GetFloat("zrenk_s")+ "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));

            }
            else if (gameObject.tag == "3")//tavan
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("muzik_trenk_h"), PlayerPrefs.GetFloat("muzik_trenk_v"), PlayerPrefs.GetFloat("muzik_trenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("muzik_trenk_h"), PlayerPrefs.GetFloat("muzik_trenk_v"), PlayerPrefs.GetFloat("muzik_trenk_s"));

                //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));

            }
        }
        else if (gameObject.name == "Mutfak")
        {
            if (gameObject.tag == "1")//duvar
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("mutfak_drenk_h"), PlayerPrefs.GetFloat("mutfak_drenk_v"), PlayerPrefs.GetFloat("mutfak_drenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("mutfak_drenk_h"), PlayerPrefs.GetFloat("mutfak_drenk_v"), PlayerPrefs.GetFloat("mutfak_drenk_s"));
                // Debug.Log("duvar h="+ PlayerPrefs.GetFloat("drenk_h")+"duvar s=" + PlayerPrefs.GetFloat("drenk_s")+"duvar v="+ PlayerPrefs.GetFloat("drenk_v"));

            }
            else if (gameObject.tag == "2")//zemin
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("mutfak_zrenk_h"), PlayerPrefs.GetFloat("mutfak_zrenk_v"), PlayerPrefs.GetFloat("mutfak_zrenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("mutfak_zrenk_h"), PlayerPrefs.GetFloat("mutfak_zrenk_v"), PlayerPrefs.GetFloat("mutfak_zrenk_s"));

                // Debug.Log("zemin h="+ PlayerPrefs.GetFloat("zrenk_h")+ "zemin s=" + PlayerPrefs.GetFloat("zrenk_s")+ "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));

            }
            else if (gameObject.tag == "3")//tavan
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("mutfak_trenk_h"), PlayerPrefs.GetFloat("mutfak_trenk_v"), PlayerPrefs.GetFloat("mutfak_trenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("mutfak_trenk_h"), PlayerPrefs.GetFloat("mutfak_trenk_v"), PlayerPrefs.GetFloat("mutfak_trenk_s"));

                //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));

            }
        }
        else if (gameObject.name == "GiyinmeOdasi")
        {
            if (gameObject.tag == "1")//duvar
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("giyinme_drenk_h"), PlayerPrefs.GetFloat("giyinme_drenk_v"), PlayerPrefs.GetFloat("giyinme_drenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("giyinme_drenk_h"), PlayerPrefs.GetFloat("giyinme_drenk_v"), PlayerPrefs.GetFloat("giyinme_drenk_s"));
                // Debug.Log("duvar h="+ PlayerPrefs.GetFloat("drenk_h")+"duvar s=" + PlayerPrefs.GetFloat("drenk_s")+"duvar v="+ PlayerPrefs.GetFloat("drenk_v"));

            }
            else if (gameObject.tag == "2")//zemin
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("giyinme_zrenk_h"), PlayerPrefs.GetFloat("giyinme_zrenk_v"), PlayerPrefs.GetFloat("giyinme_zrenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("giyinme_zrenk_h"), PlayerPrefs.GetFloat("giyinme_zrenk_v"), PlayerPrefs.GetFloat("giyinme_zrenk_s"));

                // Debug.Log("zemin h="+ PlayerPrefs.GetFloat("zrenk_h")+ "zemin s=" + PlayerPrefs.GetFloat("zrenk_s")+ "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));

            }
            else if (gameObject.tag == "3")//tavan
            {
                mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("giyinme_trenk_h"), PlayerPrefs.GetFloat("giyinme_trenk_v"), PlayerPrefs.GetFloat("giyinme_trenk_s"));
                duvar_mat.color = Color.HSVToRGB(PlayerPrefs.GetFloat("giyinme_trenk_h"), PlayerPrefs.GetFloat("giyinme_trenk_v"), PlayerPrefs.GetFloat("giyinme_trenk_s"));

                //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));

            }
        }
    }

    void Update()
    {
        if (isPaint)
        {
            mat.color = CP.TheColor;
            duvar_mat.color = CP.TheColor;
        }
    }

   /* void OnMouseDown()
    {
        if (isPaint)
        {
            StopPaint();
        }
        else
        {
            StartPaint();
        }
    }*/

    public void StartPaint()
    {
       
        if (AlllGame.oda_durumu == 1)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.5f;
        }
        else if (AlllGame.oda_durumu == 2)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.65f;
        }
        else if (AlllGame.oda_durumu == 3)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.52f;
        }
        else if (AlllGame.oda_durumu == 4)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.33f;
        }
        else if (AlllGame.oda_durumu == 5)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.66f;
        }






        // go = (GameObject)Instantiate(ColorPickedPrefab, transform.position + Vector3.up * 1.4f, Quaternion.identity);

        if (gameObject.name == "Gym")
        {
            go = (GameObject)Instantiate(ColorPickedPrefab, Camera.main.gameObject.GetComponent<AlllGame>().gym_boya_konum.transform.position, Quaternion.identity);
            go.transform.localScale = Vector3.one * 1.0f;
            go.transform.LookAt(Camera.main.gameObject.GetComponent<AlllGame>().gym_kamera.transform);
        }
        else if (gameObject.name == "MuzikOdasi")
        {
            go = (GameObject)Instantiate(ColorPickedPrefab, Camera.main.gameObject.GetComponent<AlllGame>().muzik_boya_konum.transform.position, Quaternion.identity);
            go.transform.localScale = Vector3.one * 1.0f;
            go.transform.LookAt(Camera.main.gameObject.GetComponent<AlllGame>().muzik_kamera.transform);
        }
        else if (gameObject.name == "Mutfak")
        {
            go = (GameObject)Instantiate(ColorPickedPrefab, Camera.main.gameObject.GetComponent<AlllGame>().mutfak_boya_konum.transform.position, Quaternion.identity);
            go.transform.localScale = Vector3.one * 1.0f;
            go.transform.LookAt(Camera.main.gameObject.GetComponent<AlllGame>().mutfak_kamera.transform);
        }
        else if (gameObject.name == "GiyinmeOdasi")
        {
            go = (GameObject)Instantiate(ColorPickedPrefab, Camera.main.gameObject.GetComponent<AlllGame>().giyinme_boya_konum.transform.position, Quaternion.identity);
            go.transform.localScale = Vector3.one * 1.0f;
            go.transform.LookAt(Camera.main.gameObject.GetComponent<AlllGame>().giyinme_odasi.transform);
        }
        else
        {
            go = (GameObject)Instantiate(ColorPickedPrefab, new Vector3(0.15f, 2.5f, 7.5f), Quaternion.identity);
            go.transform.localScale = Vector3.one * 1.0f;
            go.transform.LookAt(Camera.main.transform);
        }
        /*go.transform.localScale = Vector3.one * 1.0f;
        go.transform.LookAt(Camera.main.transform);*/
        CP = go.GetComponent<ColorPickerTriangle>();

        if (gameObject.tag == "1"&& gameObject.name == "YatakOdasi")//duvar
        {
            CP.durum = 1;
        }
        else if (gameObject.tag == "2" && gameObject.name == "YatakOdasi")//zemin
        {
            CP.durum = 2;
        }
        else if (gameObject.tag == "3" && gameObject.name == "YatakOdasi")//tavan
        {
            CP.durum = 3;
        }


        else if (gameObject.tag == "1" && gameObject.name == "Gym")//duvar
        {
            CP.durum = 4;
        }
        else if (gameObject.tag == "2" && gameObject.name == "Gym")//zemin
        {
            CP.durum = 5;
        }
        else if (gameObject.tag == "3" && gameObject.name == "Gym")//tavan
        {
            CP.durum = 6;
        }



        else if (gameObject.tag == "1" && gameObject.name == "MuzikOdasi")//duvar
        {
            CP.durum = 7;
        }
        else if (gameObject.tag == "2" && gameObject.name == "MuzikOdasi")//zemin
        {
            CP.durum = 8;
        }
        else if (gameObject.tag == "3" && gameObject.name == "MuzikOdasi")//tavan
        {
            CP.durum = 9;
        }



        else if (gameObject.tag == "1" && gameObject.name == "Mutfak")//duvar
        {
            CP.durum = 10;
        }
        else if (gameObject.tag == "2" && gameObject.name == "Mutfak")//zemin
        {
            CP.durum = 11;
        }
        else if (gameObject.tag == "3" && gameObject.name == "Mutfak")//tavan
        {
            CP.durum = 12;
        }


        else if (gameObject.tag == "1" && gameObject.name == "GiyinmeOdasi")//duvar
        {
            CP.durum = 13;
        }
        else if (gameObject.tag == "2" && gameObject.name == "GiyinmeOdasi")//zemin
        {
            CP.durum = 14;
        }
        else if (gameObject.tag == "3" && gameObject.name == "GiyinmeOdasi")//tavan
        {
            CP.durum = 15;
        }
        CP.SetNewColor(mat.color);
        isPaint = true;
    }

    public void StopPaint()
    {
        
            Destroy(go);
        
        isPaint = false;
    }
}
