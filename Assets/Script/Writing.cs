using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Writing : MonoBehaviour
{
    public TMP_Text text;
    private TMP_Text write;
    // Start is called before the first frame update
    void Start()
    {
        write = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = write.text; 
    }
}
