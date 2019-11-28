using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 2000)]
    public int jump = 100;
    [Header("是否死亡")]
    public bool dead;

    public GameObject goScore, goGM;
    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {
        // 如果 按下 左鍵
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("按下左鍵");

            // 分數 顯示
            goScore.SetActive(true);
            // GM 顯示
            goGM.SetActive(true);
        }      

    }

    /// <summary>
    /// 小雞死亡功能
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 小雞通過水管
    /// </summary>
    private void PassPipe()
    {

    }

    // 監聽玩家輸入 : 滑鼠、鍵盤、搖桿
    private void Update()
    {
        Jump();
    }
}
