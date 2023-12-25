using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GymPlayer : MonoBehaviour
{
    public Button but;
    public Button but2;
    public Button but3;
    private bool squating;
    private Animator ani;
    private bool planking;
    public Scrollbar scrollbar;
    private float scrollvalue;
    public GameObject good;
    public GameObject fail;
    public Button tryagain;
    public Image appr;
    public GameObject settings;
    public Button setting;
    public Button closesetting;
    // Start is called before the first frame update
    void Start()
    {
        squating = false;
        but.onClick.AddListener(squat);
        ani = GetComponent<Animator>();
        but2.onClick.AddListener(plank);
        but3.onClick.AddListener(quit);
        tryagain.onClick.AddListener(again);
        setting.onClick.AddListener(set);
        closesetting.onClick.AddListener(close);
    }
    void close()
    {
        settings.SetActive(false);
    }
    void set()
    {
        settings.SetActive(!settings.activeInHierarchy);

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
        if (squating == false&&planking==false)
        {
            planking = true;
            StartCoroutine(Plank());
            ani.SetBool("plank", true);
        }
        if (scrollvalue >= 0.15 && scrollvalue <= 0.35)
        {
            good.SetActive(true);
            StartCoroutine(Good());
            
        }

        else
        {
            appr.fillAmount -= 0.01f;
            fail.SetActive(true);
        }
    }
    IEnumerator Good()
    {
        yield return new WaitForSeconds(1);
        good.SetActive(false);
        appr.fillAmount += 0.01f;
    }
    IEnumerator Plank()
    {
        yield return new WaitForSeconds(5f);
        planking = false;
        ani.SetBool("plank", false);
    }
    void squat()
    {
        if (squating==false&&planking==false)
        {
            squating = true;
            StartCoroutine(Squat());
            ani.SetBool("squat", true);
        }
        if (scrollvalue >= 0.15 && scrollvalue <= 0.35)
        {
            good.SetActive(true);
            StartCoroutine(Good());
        }

        else
        {
            appr.fillAmount -= 0.01f;
            fail.SetActive(true);
        }
        
    }
    private IEnumerator Squat()
    {
        yield return new WaitForSeconds(1.5f);
        squating = false;
        ani.SetBool("squat", false);
    }
    private void Update()
    {
        scrollvalue = Mathf.Lerp(0, 1, Mathf.PingPong(Time.time, 1));
        scrollbar.value = scrollvalue;
        if (fail.activeSelf == true)
        {
            squating = false;
            planking = false;
            ani.SetBool("squat", false);
            ani.SetBool("plank", false);
        }
    }

}
