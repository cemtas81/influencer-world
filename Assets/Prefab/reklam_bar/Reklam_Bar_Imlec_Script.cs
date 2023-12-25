using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reklam_Bar_Imlec_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Reklam_Bar_Script.bar_deger = 5 * System.Int32.Parse(collision.gameObject.GetComponent<Text>().text.Substring(1, collision.gameObject.GetComponent<Text>().text.Length - 1));
        collision.gameObject.GetComponent<Animator>().SetTrigger("enter");
    }
}
