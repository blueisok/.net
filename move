using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 10;
    void Start()
    {
        Debug.Log("组件开始运行函数！");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0, 0.1f);
        //transform.position += new Vector3(0, 0, 5*Time.deltaTime);
        float v = Input.GetAxis("Vertical");//getaxis 获得输入设备信息 axis：轴，对称轴 vertical 垂直的，纵向的
        float h = Input.GetAxis("Horizontal");//horizontal: 水平的，横向
        Debug.Log("当前输入的纵向坐标：" + v + " " + "横向：" + h);//取值范围-1~1，上正下负，右正左负
        transform.Translate(h * 10 * Time.deltaTime, 0, v * 10 * Time.deltaTime);//控制xz轴方向运动
        //transform.Translate(h * speed * Time.deltaTime, v * speed * Time.deltaTime, 0);//控制xy轴方向运动
    }
}

