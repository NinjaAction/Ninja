using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float countTime = 0;
    private float SetTimer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // countTimeに、ゲームが開始してからの秒数を格納
        countTime += Time.deltaTime;

        SetTimer = 180.0f - countTime;

        // 小数2桁にして表示
        GetComponent<Text>().text = SetTimer.ToString("F2");
    }

}
