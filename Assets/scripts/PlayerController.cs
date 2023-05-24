using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//控制角色移动、生命、动画

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;    //定义一个移动速度，public方便在游戏界面改动
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //测试，定义一个向右移动的
        //transform.Translate(transform.right * speed * Time.deltaTime);

        //获得输入的键控制x方向的移动
        float moveX = Input.GetAxisRaw("Horizontal");   //GetAxisRaw会在按下向左右的键是返回0，1，-1以此来控制运动方向
        //y轴的移动
        float moveY = Input.GetAxisRaw("Vertical");

        //获取当前角色位置的结构体
        Vector2 position = transform.position;  //定义一个变量position 获取一个2d的坐标值
        //给x，y赋值
        //得到水平方向上的位置变化
        position.x += moveX * speed * Time.deltaTime;    //等价于position.x = position.x + movex * Speed * Time.deltaTime,实际上就是a += b等价于a = b+a
        position.y += moveY * speed * Time.deltaTime;
        //将上面的信息赋值给玩家
        transform.position = position;
    }
}
