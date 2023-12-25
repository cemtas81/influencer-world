using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(test);
    }

   void test()
    {
        
        if (SceneManager.GetActiveScene()==SceneManager.GetSceneByBuildIndex(0))
        {
            SceneManager.LoadScene(5);
        }
        if (SceneManager.GetActiveScene()==SceneManager.GetSceneByBuildIndex(5))
        {
            SceneManager.LoadScene(0);
        }
    }
}
