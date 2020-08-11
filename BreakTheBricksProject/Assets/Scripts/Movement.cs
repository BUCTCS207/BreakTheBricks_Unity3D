using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 3;//控制相机移动速度

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {//每帧Update60次
        //按下左（下）返回-1， 按下右（上）返回1
        float h = Input.GetAxis("Horizontal");//可以监测水平方向键（键盘的）的按下
        float v = Input.GetAxis("Vertical");//可以监测竖直方向键（键盘的）的按下
        transform.Translate(new Vector3(h, v, 0) * Time.deltaTime * 3);//Time.deltaTime 使得速度变为1
        //h在x轴上，v在y轴上
	}
}
