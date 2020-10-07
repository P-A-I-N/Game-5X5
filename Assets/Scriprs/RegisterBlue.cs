using UnityEngine;

public class RegisterBlue : MonoBehaviour
{
    public bool b0 = false;
    public bool b1 = false;
    public bool b2 = false;
    public bool b3 = false;
    public bool b4 = false;
    public bool B = false;

    void Update()
    {
        if (b0 && b1 && b2 && b3 && b4)
        {
            B = true;
        }
        else
        {
            B = false;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Blue0")
        {
            b0 = true;
        }
        if (collider.gameObject.tag == "Blue1")
        {
            b1 = true;
        }
        if (collider.gameObject.tag == "Blue2")
        {
            b2 = true;
        }
        if (collider.gameObject.tag == "Blue3")
        {
            b3 = true;
        }
        if (collider.gameObject.tag == "Blue4")
        {
            b4 = true;
        }
    }
    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Blue0")
        {
            b0 = true;
        }
        if (collider.gameObject.tag == "Blue1")
        {
            b1 = true;
        }
        if (collider.gameObject.tag == "Blue2")
        {
            b2 = true;
        }
        if (collider.gameObject.tag == "Blue3")
        {
            b3 = true;
        }
        if (collider.gameObject.tag == "Blue4")
        {
            b4 = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Blue0")
        {
            b0 = false;
        }
        if (collider.gameObject.tag == "Blue1")
        {
            b1 = false;
        }
        if (collider.gameObject.tag == "Blue2")
        {
            b2 = false;
        }
        if (collider.gameObject.tag == "Blue3")
        {
            b3 = false;
        }
        if (collider.gameObject.tag == "Blue4")
        {
            b4 = false;
        }
    }
}
