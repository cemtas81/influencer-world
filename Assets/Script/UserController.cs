using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UserController : MonoBehaviour
{
    public VariableJoystick joy;
    protected ThirdPersonUserControl control;
    public Button talk;
    public GameObject bubble;
    public GameObject writingfield;
    public Button fly;
    private Animator ani;
    public Transform gymExit;
    public Transform clubExit;
    public Transform evExit;
    public Transform mallExit;
    public GameObject settings;
    public Button setting;
    public Button closesetting;
    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<ThirdPersonUserControl>();
        talk.onClick.AddListener(talking);
        fly.onClick.AddListener(flying);
        ani = GetComponent<Animator>();
        setting.onClick.AddListener(set);
        closesetting.onClick.AddListener(close);
        if (PlayerPrefs.GetInt("gym")==1)
        {
            PlayerPrefs.SetInt("gym", 0);
            transform.position = gymExit.position;
            transform.rotation = gymExit.rotation;
        }
        if (PlayerPrefs.GetInt("club") == 1)
        {
            PlayerPrefs.SetInt("club", 0);
            transform.position = clubExit.position;
            transform.rotation = clubExit.rotation;
        }
        if (PlayerPrefs.GetInt("ev") == 1)
        {
            PlayerPrefs.SetInt("ev", 0);
            transform.position = evExit.position;
            transform.rotation = evExit.rotation;
        }
        if (PlayerPrefs.GetInt("mall")==1)
        {
            if (SceneManager.GetActiveScene()==SceneManager.GetSceneByBuildIndex(0))
            {
                PlayerPrefs.SetInt("mall", 0);
                transform.position = mallExit.position;
                transform.rotation = mallExit.rotation;
            }

        }
       
     
    }
    void close()
    {
        settings.SetActive(false);
    }
    void set()
    {
        settings.SetActive(!settings.activeInHierarchy);

    }
    void flying()
    {
      
        if (ani.GetBool("flying") == false)
        {
            ani.SetBool("flying", true);
        }
        else
        
            ani.SetBool("flying", false);
    }
    void talking()
    {
        bubble.SetActive(!bubble.activeInHierarchy);
        writingfield.SetActive(!writingfield.activeInHierarchy);
    }
    // Update is called once per frame
    void Update()
    {
        //control.Hinput = joy.Horizontal;
        //control.Vinput = joy.Vertical;
        control.Hinput = Input.GetAxis("Horizontal");
        control.Vinput = Input.GetAxis("Vertical");

    }
}
