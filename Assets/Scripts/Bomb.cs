using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject WinUI, GameManager, BoomParticle, BombFBX;
    Rigidbody RB;
    BoxCollider BC;
    public float BombForce,BobmMeter;

    private void OnMouseDown() {  Explosion(); }
    void Explosion()
    {
        Invoke("GameWin", 2f);
        BoomParticle.SetActive(true);
        RB = this.GetComponent<Rigidbody>();Destroy(RB);
        BC = this.GetComponent<BoxCollider>();Destroy(BC);
        Destroy(BombFBX);
        Collider[] colliders = Physics.OverlapSphere(transform.position, BobmMeter);
        foreach (Collider around in colliders)
        {
            Rigidbody rig = around.GetComponent<Rigidbody>();
            if (rig!=null)
            {
                rig.AddExplosionForce(BombForce,transform.position,BobmMeter);
            }
        }
    }
    void GameWin()
    {
        WinUI.SetActive(true);
        Destroy(this);
        GameManager.SetActive(false);
    }

}
