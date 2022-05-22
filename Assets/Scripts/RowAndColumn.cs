using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowAndColumn : MonoBehaviour
{
    public int row,column;
    public GameObject RowParent;
    public GameObject RowAndColumnObj;
    private void Start()
    {
        for (int i = 0; i <= row; i++)
        {
            GameObject Row = Instantiate(RowAndColumnObj, new Vector3(transform.position.x+i, transform.position.y, transform.position.z), Quaternion.identity);
            Row.transform.SetParent(RowParent.transform);
        }
        for (int i = 2; i <= column; i+=2)
        {
           Instantiate(RowParent, new Vector3(transform.position.x , transform.position.y+ i, transform.position.z), Quaternion.identity);
        }
    }
}
