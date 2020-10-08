using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active : MonoBehaviour
{
    public Material lightMaterials;
    public Material[] Materials;
    private MeshRenderer color;
    public Var1 var1;
    private Rigidbody rd;
    public GameObject[] player;
    private MeshRenderer c0;
    private MeshRenderer c1;
    private MeshRenderer c2;
    private MeshRenderer c3;
    private MeshRenderer c4;
    private MeshRenderer c5;
    private MeshRenderer c6;
    private MeshRenderer c7;
    private MeshRenderer c8;
    private MeshRenderer c9;
    private MeshRenderer c10;
    private MeshRenderer c11;
    private MeshRenderer c12;
    private MeshRenderer c13;
    private MeshRenderer c14;
    private Var1 i0;
    private Var1 i1;
    private Var1 i2;
    private Var1 i3;
    private Var1 i4;
    private Var1 i5;
    private Var1 i6;
    private Var1 i7;
    private Var1 i8;
    private Var1 i9;
    private Var1 i10;
    private Var1 i11;
    private Var1 i12;
    private Var1 i13;
    private Var1 i14;
    private Rigidbody r0;
    private Rigidbody r1;
    private Rigidbody r2;
    private Rigidbody r3;
    private Rigidbody r4;
    private Rigidbody r5;
    private Rigidbody r6;
    private Rigidbody r7;
    private Rigidbody r8;
    private Rigidbody r9;
    private Rigidbody r10;
    private Rigidbody r11;
    private Rigidbody r12;
    private Rigidbody r13;
    private Rigidbody r14;
 

    void Start()
    {
        var1 = GetComponent<Var1>();
        rd = GetComponent<Rigidbody>();
        color = GetComponent<MeshRenderer>();

        i0 = player[0].GetComponent<Var1>();
        i1 = player[1].GetComponent<Var1>();
        i2 = player[2].GetComponent<Var1>();
        i3 = player[3].GetComponent<Var1>();
        i4 = player[4].GetComponent<Var1>();
        i5 = player[5].GetComponent<Var1>();
        i6 = player[6].GetComponent<Var1>();
        i7 = player[7].GetComponent<Var1>();
        i8 = player[8].GetComponent<Var1>();
        i9 = player[9].GetComponent<Var1>();
        i10 = player[10].GetComponent<Var1>();
        i11 = player[11].GetComponent<Var1>();
        i12 = player[12].GetComponent<Var1>();
        i13 = player[13].GetComponent<Var1>();
        i14 = player[14].GetComponent<Var1>();

        r0 = player[0].GetComponent<Rigidbody>();
        r1 = player[1].GetComponent<Rigidbody>();
        r2 = player[2].GetComponent<Rigidbody>();
        r3 = player[3].GetComponent<Rigidbody>();
        r4 = player[4].GetComponent<Rigidbody>();
        r5 = player[5].GetComponent<Rigidbody>();
        r6 = player[6].GetComponent<Rigidbody>();
        r7 = player[7].GetComponent<Rigidbody>();
        r8 = player[8].GetComponent<Rigidbody>();
        r9 = player[9].GetComponent<Rigidbody>();
        r10 = player[10].GetComponent<Rigidbody>();
        r11 = player[11].GetComponent<Rigidbody>();
        r12 = player[12].GetComponent<Rigidbody>();
        r13 = player[13].GetComponent<Rigidbody>();
        r14 = player[14].GetComponent<Rigidbody>();

        c0 = player[0].GetComponent<MeshRenderer>();
        c1 = player[1].GetComponent<MeshRenderer>();
        c2 = player[2].GetComponent<MeshRenderer>();
        c3 = player[3].GetComponent<MeshRenderer>();
        c4 = player[4].GetComponent<MeshRenderer>();
        c5 = player[5].GetComponent<MeshRenderer>();
        c6 = player[6].GetComponent<MeshRenderer>();
        c7 = player[7].GetComponent<MeshRenderer>();
        c8 = player[8].GetComponent<MeshRenderer>();
        c9 = player[9].GetComponent<MeshRenderer>();
        c10 = player[10].GetComponent<MeshRenderer>();
        c11 = player[11].GetComponent<MeshRenderer>();
        c12 = player[12].GetComponent<MeshRenderer>();
        c13 = player[13].GetComponent<MeshRenderer>();
        c14 = player[14].GetComponent<MeshRenderer>();


    }

    private void OnMouseDown()
    {
        i0.enabled = false;
        i1.enabled = false;
        i2.enabled = false;
        i3.enabled = false;
        i4.enabled = false;
        i5.enabled = false;
        i6.enabled = false;
        i7.enabled = false;
        i8.enabled = false;
        i9.enabled = false;
        i10.enabled = false;
        i11.enabled = false;
        i12.enabled = false;
        i13.enabled = false;
        i14.enabled = false;

        r0.isKinematic = true;
        r1.isKinematic = true;
        r2.isKinematic = true;
        r3.isKinematic = true;
        r4.isKinematic = true;
        r5.isKinematic = true;
        r6.isKinematic = true;
        r7.isKinematic = true;
        r8.isKinematic = true;
        r9.isKinematic = true;
        r10.isKinematic = true;
        r11.isKinematic = true;
        r12.isKinematic = true;
        r13.isKinematic = true;
        r14.isKinematic = true;

        c0.material = Materials[2];
        c1.material = Materials[2];
        c2.material = Materials[2];
        c3.material = Materials[2];
        c4.material = Materials[2];
        c5.material = Materials[1];
        c6.material = Materials[1];
        c7.material = Materials[1];
        c8.material = Materials[1];
        c9.material = Materials[0];
        c10.material = Materials[0];
        c11.material = Materials[0];
        c12.material = Materials[0];
        c13.material = Materials[0];
        c14.material = Materials[1];


        var1.enabled = true;
        rd.isKinematic = false;
        color.material = lightMaterials;
    }
}
