using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAndomColor : MonoBehaviour
{
    public MeshRenderer mR;
    public Material DefaultMat;

    void Start()
    {
        mR = this.gameObject.GetComponent<MeshRenderer>();
        int RandomNumber = Random.Range(0, 11);

        if (RandomNumber%2==0)
        {
            this.gameObject.AddComponent<Rigidbody>();
            mR.material.color = Random.ColorHSV();
        }
        else  { mR.material = DefaultMat; }
    }
}
