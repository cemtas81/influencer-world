using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClubMove : MonoBehaviour
{
    public Button but;
    public Button but2;
    public Button but3;
    public bool house;
    private Animator ani;
    public bool breakdance;
    public Scrollbar scrollbar;
    private float scrollvalue;
    public GameObject good;
    public GameObject scroll;
    public GameObject fail;
    public Button tryagain;
    public Image popi;
    public float pop ;
    public GameObject settings;
    public Button setting;
    public Button closesetting;
    // Start is called before the first frame update
    void Start()
    {
        house = false;
        breakdance = false;
        setting.onClick.AddListener(set);
        closesetting.onClick.AddListener(close);
        ani = GetComponent<Animator>();
        but3.onClick.AddListener(quit);
        StartCoroutine(start());
        tryagain.onClick.AddListener(again);
        pop = popi.fillAmount;
     
    }
    void close()
    {
        settings.SetActive(false);
    }
    void set()
    {
        settings.SetActive(!settings.activeInHierarchy);

    }
    IEnumerator start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            but2.onClick.AddListener(plank);
            but.onClick.AddListener(squat);
            scroll.SetActive(true);
            scrollvalue = scrollbar.value;
        }
    }
    private void Update()
    {
        scrollvalue = Mathf.Lerp(0, 1, Mathf.PingPong(Time.time , 1));
        scrollbar.value = scrollvalue;
        if (fail.activeSelf == true)
        {
            breakdance = false;
            house = false;
            ani.SetBool("dance2", false);
            ani.SetBool("dance", false);
        }

    }
    void again()
    {
        fail.SetActive(false);
    }

    void quit()
    {
        
        SceneManager.LoadScene(0);
    }
    void plank()
    {
        if (house == false && breakdance == false)
        {
            breakdance = true;
            StartCoroutine(Plank());
            ani.SetBool("dance2", true);
            
        }
        if (scrollvalue >= 0.15 && scrollvalue <= 0.35)
        {
            good.SetActive(true);
            StartCoroutine(Good());
            
        }

        else 
        {
            pop =popi.fillAmount- 0.01f;
            popi.fillAmount = pop;
            fail.SetActive(true);
        }




        //ani.SetBool("dance2", false);

    }
    IEnumerator Good()
    {
        yield return new WaitForSeconds(1);
        good.SetActive(false);
        pop =popi.fillAmount+ 0.01f;
        popi.fillAmount = pop;
    }
    IEnumerator Plank()
    {
        yield return new WaitForSeconds(13.18f);
        breakdance = false;
        ani.SetBool("dance2", false);
    }
    void squat()
    {
        if (house == false && breakdance == false)
        {
            house = true;
            StartCoroutine(Squat());
            ani.SetBool("dance", true);
           
        }
        if (scrollvalue >= 0.15 && scrollvalue <= 0.35)
        {
            good.SetActive(true);
            StartCoroutine(Good());
        }

        else
        {
            pop =popi.fillAmount- 0.01f;
            popi.fillAmount = pop;
            fail.SetActive(true);
        }


        //ani.SetBool("dance", false);


    }
        private IEnumerator Squat()
    {
        yield return new WaitForSeconds(19.23f);
        house = false;
        ani.SetBool("dance", false);
    }
}
