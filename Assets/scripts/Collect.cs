using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Collect : MonoBehaviour
{
    //声明一个变量存储物体数量
    int collectCount = 0;


    //当玩家检测到触发器时
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //如果标签是collect
        if (collision.CompareTag("collect"))
        {
            Destroy(collision.gameObject);  //销毁物品
           collectCount += 1;   //使数字加一
        }
    }

    //在左上角显示GUI
    private void OnGUI()
    {
        GUI.skin.label.fontSize = 10;   //展示内容的尺寸
        GUI.Label(new Rect(20, 20, 10, 500), "草莓数量:" + collectCount);  //展示的位置以及内容，
                                                                           //（离左侧底边的距离，离顶部距离，xmax，ymax）设置 x 或 y 会改变矩形的位置
                                                                           //设置yMin 和 yMax 中的任何值会调整矩形大小，但是相对边缘的位置保持不变
    }
}
