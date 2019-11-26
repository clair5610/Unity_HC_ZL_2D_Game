using UnityEngine;

public class Ground : MonoBehaviour
{
    [Header("速度"), Range(0, 100)]
    public float speed = 10.5f;

    [Header("變形")]
    public Transform tran;

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void Move()
    {
        //Time.deltaTime 一幀的時間
        tran.Translate(-speed * Time.deltaTime, 0, 0);
    }

    private void Update()
    {
        Move();
    }
}
