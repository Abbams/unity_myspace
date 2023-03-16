using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()//初始化函数
    {

    }

    // Update is called once per frame
    void Update()//按帧频率进行更新
    {

    }
    private void FixedUpdate()
    {
        float horizontalmovement = Input.GetAxis("Horizontal");//获取水平方向输入量
        float verticalmovement = Input.GetAxis("Vertical");//获取垂直方向输入量
        //使用水平、垂直方向输入量构建一个向量；
        Vector3 movement = new Vector3(horizontalmovement, 0, verticalmovement);
        //首先获取飞船的刚体组件
        //设置飞船刚体组件的速度属性
        GetComponent<Rigidbody>().velocity = movement * speed;
        //运动速率太慢
        //会飞出边界
        //不能旋转
    }
}