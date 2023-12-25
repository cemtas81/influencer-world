using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HouseEit : MonoBehaviour
{
    void Start()
    {
        var but = GetComponent<Button>();
        but.onClick.AddListener(Exit);
    }

    void Exit()
    {
        //PlayerPrefs.SetInt("ev", 1);
        //PlayerPrefs.Save();
        SceneManager.LoadScene(0);
    }
}
