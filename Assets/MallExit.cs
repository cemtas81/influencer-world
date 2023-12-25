using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MallExit : MonoBehaviour
{
    void Start()
    {
        var but = GetComponent<Button>();
        but.onClick.AddListener(Exit);
    }

    void Exit()
    {
        
        SceneManager.LoadScene(0);
    }
}
