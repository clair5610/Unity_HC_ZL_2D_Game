using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learaAPI : MonoBehaviour
{
    private void Start()
    {
        print("輸出");

        Debug.Log("輸出訊息");

        //靜態成員取得方式
        print(Random.value);

        //練習取得PI
        print(Mathf.PI);

        //靜態方法:類別.方法(對應的參數)
        print("隨機範圍:" + Random.Range(50.5f, 100.9f));

        //object 任何類型:int、float、string、bool
        Debug.Log(true);
        Debug.LogWarning("警告");
        Debug.LogError("錯誤");
    }

    private void Update()
    {
        //輸入.按鍵名稱
        print(Input.inputString);

        //偵測玩家是否按s
        print(Input.GetKeyDown("s"));
    }
}
