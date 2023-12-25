using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EntHome : MonoBehaviour
{
    public Slider sly;
    public GameObject slider;
    public Text progressText;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.FindWithTag("Player"))
        {
            //SceneManager.LoadScene(1);
            PlayerPrefs.SetInt("ev", 1);
            
            StartCoroutine(LoadLevelAsync());
          
        }
    }
     IEnumerator LoadLevelAsync()
    {
        yield return null;
        slider.SetActive(true);
        AsyncOperation asyncload = SceneManager.LoadSceneAsync(1);
        asyncload.allowSceneActivation = false;
        while (!asyncload.isDone)
        {
            if (asyncload.progress>=0.9f)
            {
                asyncload.allowSceneActivation = true;
            }
            float progress = Mathf.Clamp01(asyncload.progress/.9f);
            sly.value = progress;
            progressText.text = Mathf.Round (progress*100)+"%";
            yield return null;
        }
       
    }
    

}
