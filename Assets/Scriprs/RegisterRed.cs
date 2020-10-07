using UnityEngine;

public class RegisterRed : MonoBehaviour
{
    public bool r0 = false;
    public bool r1 = false;
    public bool r2 = false;
    public bool r3 = false;
    public bool r4 = false;
    public bool R = false;

    void Update()
    {
        if(r0 && r1 && r2 && r3 && r4)
        {
            R = true;
        }
        else
        {
            R = false;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Red0")
        {
            r0 = true;
        }
        if (collider.gameObject.tag == "Red1")
        {
            r1 = true;
        }
        if (collider.gameObject.tag == "Red2")
        {
            r2 = true;
        }
        if (collider.gameObject.tag == "Red3")
        {
            r3 = true;
        }
        if (collider.gameObject.tag == "Red4")
        {
            r4 = true;
        }
    }
    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Red0")
        {
            r0 = true;
        }
        if (collider.gameObject.tag == "Red1")
        {
            r1 = true;
        }
        if (collider.gameObject.tag == "Red2")
        {
            r2 = true;
        }
        if (collider.gameObject.tag == "Red3")
        {
            r3 = true;
        }
        if (collider.gameObject.tag == "Red4")
        {
            r4 = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Red0")
        {
            r0 = false;
        }
        if (collider.gameObject.tag == "Red1")
        {
            r1 = false;
        }
        if (collider.gameObject.tag == "Red2")
        {
            r2 = false;
        }
        if (collider.gameObject.tag == "Red3")
        {
            r3 = false;
        }
        if (collider.gameObject.tag == "Red4")
        {
            r4 = false;
        }
    }
}
