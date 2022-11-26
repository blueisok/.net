using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crt : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {

        gre();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject cube = GameObject.Find("Cubepre(Clone)");
            Destroy(cube);
        }
    }
    private void gre()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 pos = new Vector3(Mathf.Cos(i * (Mathf.PI * 2) / 3), 0, Mathf.Sin(i * (Mathf.PI * 2) / 3));
            pos *= 5;//Բ�뾶Ϊ5
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
}
