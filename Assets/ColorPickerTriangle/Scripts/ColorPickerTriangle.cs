using UnityEngine;
using System.Collections;

public class ColorPickerTriangle : MonoBehaviour {

    public Color TheColor = Color.cyan;

    const float MainRadius = .8f;
    const float CRadius = .5f;
    const float CWidth = .1f;
    const float TRadius = .4f;

    public GameObject Triangle;
    public GameObject PointerColor;
    public GameObject PointerMain;

    private Mesh TMesh;
    private Plane MyPlane;
    private Vector3[] RPoints;
    private Vector3 CurLocalPos;
    private Vector3 CurBary = Vector3.up;
    private Color CircleColor = Color.red;
    private bool DragCircle = false;
    private bool DragTriangle = false;

    private bool MousePressed = false;
    public  int durum; 
	// Use this for initialization
	void Awake () {
        float h, s, v;
        Color.RGBToHSV(TheColor, out h, out s, out v);
        //Debug.Log("HSV = " + v.ToString() + "," + h.ToString() + "," + v.ToString() + ", color = " + TheColor.ToString());
        MyPlane = new Plane(transform.TransformDirection(Vector3.forward), transform.position);
        RPoints = new Vector3[3];
        SetTrianglePoints();
        TMesh = Triangle.GetComponent<MeshFilter>().mesh;
        SetNewColor(TheColor);
    }
	
	// Update is called once per frame
	void Update () {
        

        if (!MousePressed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (HasIntersection())
                {
                    MousePressed = true;
                    CheckTrianglePosition();
                    CheckCirclePosition();
                    return;
                }
            }
        }
        else
        {
            if (Input.GetMouseButtonUp(0) || !Input.GetMouseButton(0) || !HasIntersection())
            {
                MousePressed = false;
                StopDrag();
                return;
            }

            if (!DragCircle)
                    CheckTrianglePosition();
            if (!DragTriangle)
                    CheckCirclePosition();
            return;
        }
    }



    private void StopDrag()
    {
        DragCircle = false;
        DragTriangle = false;
    }

    private bool HasIntersection()
    {
        MyPlane = new Plane(transform.TransformDirection(Vector3.forward), transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (durum>=1&&durum<=3)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }
        else if (durum >= 4 && durum <= 6)
        {
            ray = GameObject.Find("Camera_Gym").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        }
        else if (durum >= 7 && durum <= 9)
        {
            ray = GameObject.Find("Camera_Muzik").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        }
        else if (durum >= 10 && durum <= 12)
        {
            ray = GameObject.Find("Camera_Mutfak").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        }
        else if (durum >= 13 && durum <= 15)
        {
            ray = GameObject.Find("Giyinme_odasi_main_Camera").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        }
        float rayDistance;
        if (MyPlane.Raycast(ray, out rayDistance))
        {
            Vector3 p = ray.GetPoint(rayDistance);
            if (Vector3.Distance(p, transform.position) > MainRadius)
                return false;
            CurLocalPos = transform.worldToLocalMatrix.MultiplyPoint(p);
            return true;
        }

        return false;
    }

    public void SetNewColor(Color NewColor)
    {
        TheColor = NewColor;
        float h, s, v;
        Color.RGBToHSV(TheColor, out h, out s, out v);

       /* if(durum==1)//duvar
        {
            PlayerPrefs.SetFloat("drenk_h", h);
            PlayerPrefs.SetFloat("drenk_s", s);
            PlayerPrefs.SetFloat("drenk_v", v);
        }
        else if(durum==2)//zemin
        {
            PlayerPrefs.SetFloat("zrenk_h", h);
            PlayerPrefs.SetFloat("zrenk_s", s);
            PlayerPrefs.SetFloat("zrenk_v", v);
        }*/

        CircleColor = Color.HSVToRGB(h, 1, 1);
        ChangeTriangleColor(CircleColor);
        PointerMain.transform.localEulerAngles = Vector3.back * (h * 360f);
        CurBary.y = 1f - v;
        CurBary.x = v * s;
        CurBary.z = 1f - CurBary.y - CurBary.x;
        CurLocalPos = RPoints[0] * CurBary.x + RPoints[1] * CurBary.y + RPoints[2] * CurBary.z;
        PointerColor.transform.localPosition = CurLocalPos;
    }

    private void CheckCirclePosition()
    {
        if (Mathf.Abs(CurLocalPos.magnitude - CRadius) > CWidth / 2f && !DragCircle)
            return;

        float a = Vector3.Angle(Vector3.left, CurLocalPos);
        if (CurLocalPos.y < 0)
            a = 360f - a;

        CircleColor = Color.HSVToRGB(a / 360, 1, 1); 
        ChangeTriangleColor(CircleColor);
        PointerMain.transform.localEulerAngles = Vector3.back * a;
        DragCircle = !DragTriangle;
        SetColor();
    }

    private void CheckTrianglePosition()
    {
        Vector3 b = Barycentric(CurLocalPos, RPoints[0], RPoints[1], RPoints[2]);
        if (b.x >= 0f && b.y >= 0f && b.z >= 0f)
        {
            CurBary = b;
            PointerColor.transform.localPosition = CurLocalPos;
            DragTriangle = !DragCircle;
            SetColor();
        }
    }

    private void SetColor()
    {
        float h, v, s;
        Color.RGBToHSV(CircleColor, out h, out v, out s);
        Color c = (CurBary.y > .9999) ? Color.black : Color.HSVToRGB(h, CurBary.x / (1f - CurBary.y), 1f - CurBary.y);
        TheColor = c;
        TheColor.a = 1f;
        
        float h1, v1, s1;
        Color.RGBToHSV(TheColor, out h1, out v1, out s1);
        if (durum == 1)//duvar
        {
           // Debug.Log("duvar girdim");
            PlayerPrefs.SetFloat("drenk_h", h1);
             PlayerPrefs.SetFloat("drenk_s", s1);
             PlayerPrefs.SetFloat("drenk_v", v1);
             
            //Debug.Log("duvar h=" + PlayerPrefs.GetFloat("drenk_h") + "duvar s=" + PlayerPrefs.GetFloat("drenk_s") + "duvar v=" + PlayerPrefs.GetFloat("drenk_v"));
        }
        else if (durum == 2)//zemin
        {
            //Debug.Log("zemin girdim");
            PlayerPrefs.SetFloat("zrenk_h", h1);
            PlayerPrefs.SetFloat("zrenk_s", s1);
            PlayerPrefs.SetFloat("zrenk_v", v1);
           
            //Debug.Log("zemin h=" + PlayerPrefs.GetFloat("zrenk_h") + "zemin s=" + PlayerPrefs.GetFloat("zrenk_s") + "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));
        }
        else if (durum == 3)//tavan
        {
            //Debug.Log("zemin girdim");
            PlayerPrefs.SetFloat("trenk_h", h1);
            PlayerPrefs.SetFloat("trenk_s", s1);
            PlayerPrefs.SetFloat("trenk_v", v1);

           // Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));
        }


        else if (durum == 4)//duvar
        {
            //Debug.Log("duvar girdim");
            PlayerPrefs.SetFloat("gym_drenk_h", h1);
            PlayerPrefs.SetFloat("gym_drenk_s", s1);
            PlayerPrefs.SetFloat("gym_drenk_v", v1);

          //  Debug.Log("duvar h=" + PlayerPrefs.GetFloat("drenk_h") + "duvar s=" + PlayerPrefs.GetFloat("drenk_s") + "duvar v=" + PlayerPrefs.GetFloat("drenk_v"));
        }
        else if (durum == 5)//zemin
        {
           // Debug.Log("gym_zemin girdim");
            PlayerPrefs.SetFloat("gym_zrenk_h", h1);
            PlayerPrefs.SetFloat("gym_zrenk_s", s1);
            PlayerPrefs.SetFloat("gym_zrenk_v", v1);

            //Debug.Log("zemin h=" + PlayerPrefs.GetFloat("zrenk_h") + "zemin s=" + PlayerPrefs.GetFloat("zrenk_s") + "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));
        }
        else if (durum == 6)//tavan
        {
            //Debug.Log("gym_zemin girdim");
            PlayerPrefs.SetFloat("gym_trenk_h", h1);
            PlayerPrefs.SetFloat("gym_trenk_s", s1);
            PlayerPrefs.SetFloat("gym_trenk_v", v1);

            //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));
        }


        else if(durum == 7)//duvar
        {
            //Debug.Log("duvar girdim");
            PlayerPrefs.SetFloat("muzik_drenk_h", h1);
            PlayerPrefs.SetFloat("muzik_drenk_s", s1);
            PlayerPrefs.SetFloat("muzik_drenk_v", v1);

            //  Debug.Log("duvar h=" + PlayerPrefs.GetFloat("drenk_h") + "duvar s=" + PlayerPrefs.GetFloat("drenk_s") + "duvar v=" + PlayerPrefs.GetFloat("drenk_v"));
        }
        else if (durum == 8)//zemin
        {
            // Debug.Log("gym_zemin girdim");
            PlayerPrefs.SetFloat("muzik_zrenk_h", h1);
            PlayerPrefs.SetFloat("muzik_zrenk_s", s1);
            PlayerPrefs.SetFloat("muzik_zrenk_v", v1);

            //Debug.Log("zemin h=" + PlayerPrefs.GetFloat("zrenk_h") + "zemin s=" + PlayerPrefs.GetFloat("zrenk_s") + "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));
        }
        else if (durum == 9)//tavan
        {
            //Debug.Log("gym_zemin girdim");
            PlayerPrefs.SetFloat("muzik_trenk_h", h1);
            PlayerPrefs.SetFloat("muzik_trenk_s", s1);
            PlayerPrefs.SetFloat("muzik_trenk_v", v1);

            //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));
        }


        else if (durum == 10)//duvar
        {
            //Debug.Log("duvar girdim");
            PlayerPrefs.SetFloat("mutfak_drenk_h", h1);
            PlayerPrefs.SetFloat("mutfak_drenk_s", s1);
            PlayerPrefs.SetFloat("mutfak_drenk_v", v1);

            //  Debug.Log("duvar h=" + PlayerPrefs.GetFloat("drenk_h") + "duvar s=" + PlayerPrefs.GetFloat("drenk_s") + "duvar v=" + PlayerPrefs.GetFloat("drenk_v"));
        }
        else if (durum == 11)//zemin
        {
            // Debug.Log("gym_zemin girdim");
            PlayerPrefs.SetFloat("mutfak_zrenk_h", h1);
            PlayerPrefs.SetFloat("mutfak_zrenk_s", s1);
            PlayerPrefs.SetFloat("mutfak_zrenk_v", v1);

            //Debug.Log("zemin h=" + PlayerPrefs.GetFloat("zrenk_h") + "zemin s=" + PlayerPrefs.GetFloat("zrenk_s") + "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));
        }
        else if (durum == 12)//tavan
        {
            //Debug.Log("gym_zemin girdim");
            PlayerPrefs.SetFloat("mutfak_trenk_h", h1);
            PlayerPrefs.SetFloat("mutfak_trenk_s", s1);
            PlayerPrefs.SetFloat("mutfak_trenk_v", v1);

            //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));
        }
        else if (durum == 13)//duvar
        {
            //Debug.Log("duvar girdim");
            PlayerPrefs.SetFloat("giyinme_drenk_h", h1);
            PlayerPrefs.SetFloat("giyinme_drenk_s", s1);
            PlayerPrefs.SetFloat("giyinme_drenk_v", v1);

            //  Debug.Log("duvar h=" + PlayerPrefs.GetFloat("drenk_h") + "duvar s=" + PlayerPrefs.GetFloat("drenk_s") + "duvar v=" + PlayerPrefs.GetFloat("drenk_v"));
        }
        else if (durum == 14)//zemin
        {
            // Debug.Log("gym_zemin girdim");
            PlayerPrefs.SetFloat("giyinme_zrenk_h", h1);
            PlayerPrefs.SetFloat("giyinme_zrenk_s", s1);
            PlayerPrefs.SetFloat("giyinme_zrenk_v", v1);

            //Debug.Log("zemin h=" + PlayerPrefs.GetFloat("zrenk_h") + "zemin s=" + PlayerPrefs.GetFloat("zrenk_s") + "zemin v=" + PlayerPrefs.GetFloat("zrenk_v"));
        }
        else if (durum == 15)//tavan
        {
            //Debug.Log("gym_zemin girdim");
            PlayerPrefs.SetFloat("giyinme_trenk_h", h1);
            PlayerPrefs.SetFloat("giyinme_trenk_s", s1);
            PlayerPrefs.SetFloat("giyinme_trenk_v", v1);

            //Debug.Log("tavan h=" + PlayerPrefs.GetFloat("trenk_h") + "tavan s=" + PlayerPrefs.GetFloat("trenk_s") + "tavan v=" + PlayerPrefs.GetFloat("trenk_v"));
        }

    }

    private void ChangeTriangleColor(Color c)
    {
        Color[] colors = new Color[TMesh.colors.Length];
        colors[0] = Color.black;
        colors[1] = c;
        colors[2] = Color.white;
        TMesh.colors = colors;
    }

    private Vector3 Barycentric(Vector3 p, Vector3 a, Vector3 b, Vector3 c)
    {
        Vector3 bary = Vector3.zero;
        Vector3 v0 = b - a;
        Vector3 v1 = c - a;
        Vector3 v2 = p - a;
        float d00 = Vector3.Dot(v0, v0);
        float d01 = Vector3.Dot(v0, v1);
        float d11 = Vector3.Dot(v1, v1);
        float d20 = Vector3.Dot(v2, v0);
        float d21 = Vector3.Dot(v2, v1);
        float denom = d00 * d11 - d01 * d01;
        bary.y = (d11 * d20 - d01 * d21) / denom;
        bary.z = (d00 * d21 - d01 * d20) / denom;
        bary.x = 1.0f - bary.y - bary.z;
        return bary;
    }


    private void SetTrianglePoints()
    {
        RPoints[0] = Vector3.up * TRadius;
        float c = Mathf.Sin(Mathf.Deg2Rad * 30);
        float s = Mathf.Cos(Mathf.Deg2Rad * 30);
        RPoints[1] = new Vector3 (s, -c, 0) * TRadius;
        RPoints[2] = new Vector3(-s, -c, 0) * TRadius;
    }
}
