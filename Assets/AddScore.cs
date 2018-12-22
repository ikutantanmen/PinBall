using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{

    //スコアを表示するテキスト
    private GameObject scoreText;
    //スコア計算用変数
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");

        //初期スコアを代入して表示
        score = 0;
        SetScore();
    }

    //タグごとに得点を変える
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallStarTag")
        {
            score += 10;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 30;
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 20;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 40;
        }

        SetScore();
    }

    void SetScore()
    {
        //ScoreTextにスコアを表示
        this.scoreText.GetComponent<Text>().text = string.Format("Score:{0}", score);
    }
}
