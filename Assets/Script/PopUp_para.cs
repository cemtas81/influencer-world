using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
public class PopUp_para : MonoBehaviour
{
    private GameObject Yeni_takipci_prefab, Video_rec_prefab, Yorum_prefab, Sponsor_prefab;
    private GameObject dokunuan_obje, kanvas;
    private float waitTime = 10f;

    //kaydırma deneme
    RectTransform cerceve;
    RectTransform pupupObj;
    public float speed;
    float horizontalSpeedMultiplier = 1f; // +1 moves right, -1 moves left
    float verticalSpeedMultiplier = -1f; // +1 moves upward, -1 moves downward
    public Text para_text;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<Image>().fillAmount = 1f;
        pupupObj = gameObject.GetComponent<RectTransform>();
        cerceve = GameObject.Find("popup_cerceve").GetComponent<RectTransform>();
        para_text.text = "+" + (500 + (250 * PlayerPrefs.GetInt("ParaFloatButton")));
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).GetComponent<Image>().fillAmount -= 1.0f / waitTime * Time.deltaTime;
        if (transform.GetChild(0).GetComponent<Image>().fillAmount == 0)
        {
            Destroy(gameObject);
        }
        speed = 2f;
        transform.DOLocalMove(new Vector3(transform.localPosition.x + horizontalSpeedMultiplier * speed, transform.localPosition.y + verticalSpeedMultiplier * speed, 0f), 0f);

        if (pupupObj.localPosition.y > cerceve.rect.yMax)
        {
            verticalSpeedMultiplier = -1f;
        }

        if (pupupObj.localPosition.y < cerceve.rect.yMin)
        {
            verticalSpeedMultiplier = 1f;
        }

        if (pupupObj.localPosition.x < cerceve.rect.xMin)
        {
            horizontalSpeedMultiplier = 1f;
        }

        if (pupupObj.localPosition.x > cerceve.rect.xMax)
        {
            horizontalSpeedMultiplier = -1f;
        }
    }

    public void paraver()
    {
        Reklam.odul_bak = 9;
        //GameObject.Find("Game_Manager").GetComponent<Reklam>().reklam_izlet();
        Destroy(gameObject);
    }
}
