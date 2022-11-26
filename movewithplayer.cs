using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewithplayer : MonoBehaviour
{
    public GameObject withobject;
    Vector3 pos;
    void Start()
    {
        pos = transform.position - withobject.transform.position;//º∆À„œ‡≤Óµƒæ‡¿Î
    }
    private void LateUpdate()
    {
        transform.position = withobject.transform.position + pos;
    }

}
