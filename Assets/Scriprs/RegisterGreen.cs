using UnityEngine;

public class RegisterGreen : MonoBehaviour
{
    public bool g0 = false;
    public bool g1 = false;
    public bool g2 = false;
    public bool g3 = false;
    public bool g4 = false;
    public bool G = false;

    void Update()
    {
        if (g0 && g1 && g2 && g3 && g4)
        {
            G = true;
        }
        else
        {
            G = false;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Green0")
        {
            g0 = true;
        }
        if (collider.gameObject.tag == "Green1")
        {
            g1 = true;
        }
        if (collider.gameObject.tag == "Green2")
        {
            g2 = true;
        }
        if (collider.gameObject.tag == "Green3")
        {
            g3 = true;
        }
        if (collider.gameObject.tag == "Green4")
        {
            g4 = true;
        }
    }
    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Green0")
        {
            g0 = true;
        }
        if (collider.gameObject.tag == "Green1")
        {
            g1 = true;
        }
        if (collider.gameObject.tag == "Green2")
        {
            g2 = true;
        }
        if (collider.gameObject.tag == "Green3")
        {
            g3 = true;
        }
        if (collider.gameObject.tag == "Green4")
        {
            g4 = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Green0")
        {
            g0 = false;
        }
        if (collider.gameObject.tag == "Green1")
        {
            g1 = false;
        }
        if (collider.gameObject.tag == "Green2")
        {
            g2 = false;
        }
        if (collider.gameObject.tag == "Green3")
        {
            g3 = false;
        }
        if (collider.gameObject.tag == "Green4")
        {
            g4 = false;
        }
    }
}