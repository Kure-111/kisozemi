using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;  //移動速度
    public float rotationSpeed = 200.0f;  //回転速度
    private bool isControlEnabled = true;  //プレイヤーが制御可能かどうかを判定
    private Rigidbody2D rb;  //Rigidbody2D

    void Start()
    {
        // Rigidbody2Dを取得
        rb = GetComponent<Rigidbody2D>();
        // 初めは重力を無効に
        rb.gravityScale = 0;
    }

    void Update()
    {
        if (isControlEnabled)
        {
            // Aキーを押した
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-0.01f, 0f, 0f, Space.World);
            }
            // Dキーを押した
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(0.01f, 0f, 0f, Space.World);
            }


            // スペースキーを押している間回転
            if (Input.GetKey(KeyCode.Space))
            {
                transform.Rotate(new Vector3(0, 0, -rotationSpeed * Time.deltaTime));
            }



            // エンターキーを押したときに重力を適用して操作を不可に
            if (Input.GetKeyDown(KeyCode.Return))
            {
                rb.gravityScale = 1;
                isControlEnabled = false;
            }
        }
    }
}
