using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform spawnPoint; // インスペクタで動物がスポーンする位置をセットします
    public float verticalOffset; // インスペクタでカメラがスポーンポイントの下に保つべき距離をセットします

    // フレームごとに更新します
    void Update()
    {
        // 新しいカメラの位置を計算します
        Vector3 newPos = new Vector3(transform.position.x, spawnPoint.position.y + verticalOffset, transform.position.z);

        // カメラを新しい位置に移動します
        transform.position = Vector3.Lerp(transform.position, newPos, 0.1f); // 0.1は補完速度で、カメラの移動が滑らかになるように調整します
    }
}

