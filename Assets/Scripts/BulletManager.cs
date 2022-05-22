using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public Material hitMaterial;
    public GameObject Bullet;
    public GameObject MainParentCube;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit RH;
            if (Physics.Raycast(ray, out RH))
            {
                var rig = RH.collider.GetComponent<Rigidbody>();
                if (rig != null)
                {
                    rig.transform.SetParent(MainParentCube.transform);
                    rig.AddForceAtPosition(ray.direction * 50f, RH.point, ForceMode.VelocityChange);
                }
            }
        }
    }
}
