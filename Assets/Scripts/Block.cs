using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // ①隙間の高さを調整
    public float minHeight;
    public float maxHeight;
    // ②Pivotオブジェクト
    public GameObject pivot;

    // Start is called before the first frame update
    void Start()
    {
        // 開始時に隙間の高さを変更
        ChangeObject();  // ③隙間の初期化
    }

    void ChangeObject()
    {
        // ④高さの変更
        // ランダムな高さを生成して設定
        float height = Random.Range(minHeight, maxHeight);
        pivot.transform.localPosition = new Vector3(0.0f, height, 0.0f);
    }

    // ScrollObjectスクリプトからのメッセージを受け取って高さを変更
    void OnScrollEnd()
    {
        // ⑤スクロール完了時の隙間の再設定
        ChangeObject();
    }
}
