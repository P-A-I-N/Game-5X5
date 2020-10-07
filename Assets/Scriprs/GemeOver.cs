using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private RegisterBlue rb;
    private RegisterGreen rg;
    private RegisterRed rr;
    public GameObject text;
    public bool R;
    public bool G;
    public bool B;
    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Register B").GetComponent<RegisterBlue>();
        rg = GameObject.Find("Register G").GetComponent<RegisterGreen>();
        rr = GameObject.Find("Register R").GetComponent<RegisterRed>();
        text.SetActive(false);
    }
    void Update()
    {
        R = rr.R;
        G = rg.G;
        B = rb.B;
        if (R && G && B)
        {
            invoke();
        }
    }
    void invoke()
    {
        Invoke("active", 3);
        Invoke("exit", 10);
    }
    void active()
    {
        text.SetActive(true);
    }
    void exit()
    {
        Application.Quit();
    }
}
