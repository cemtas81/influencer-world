using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBump : MonoBehaviour
{
    public SpriteRenderer sprite;
    
    public Shader shader2;
    public SpriteRenderer shade;
    public Shader shader1;
    private void Start()
    {

        shader1 = Shader.Find("Toon/Lit Outline");
        shader2 = shade.GetComponent<SpriteRenderer>().material.shader;

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Renderer>())
        {

            if (other.tag == ("Untagged"))
            {

                other.GetComponent<Renderer>().material.shader = shader2;
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Untagged") && other.GetComponent<Renderer>())
        {
            other.GetComponent<Renderer>().material.shader = shader1;

        }
    }
}
