using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    public float speed = 1.0f;
    public float startPosition;
    public float endPosition;

    // Update is called once per frame
    void Update()
    {
        // 毎フレームxポジションを少しずつ移動する
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0); // ①スクロールの処理

        // スクロールが目標ポイントまで到達したかをチェック
        if (transform.position.x <= endPosition) {
            ScrollEnd(); // ②スクロール終了の判定
        }
    }

    void ScrollEnd()
    {
        // スクロールする距離を戻す
        transform.Translate(-1 * (endPosition - startPosition), 0, 0); // ③ローテーションの処理

        // 同じゲームオブジェクトにアタッチされているコンポーネントにメッセージを送る
        SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver); // ④ScrollEndのメッセージング
    }
}
