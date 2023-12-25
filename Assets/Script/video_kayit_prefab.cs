using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class video_kayit_prefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(yoket());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator yoket()
    {
        transform.DOLocalMove(new Vector3(0,0,0), 0.5f);
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
      
    }
}
