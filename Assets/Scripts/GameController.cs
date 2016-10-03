using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public bool isPlay;
    public GameObject result;
    public GameObject player;
    public Text TimerText;
    public Text ScoreText;

    public LaserCreater laserCreater;

    public float time;
    private int score;
	// Use this for initialization
	void Start () {
        isPlay = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (!isPlay)
        {
            result.SetActive(true);
        }
        else
        {
            UI();
            result.SetActive(false);

            if((int)time == 10)
            {
                laserCreater.createTime = 2;
            }
            if ((int)time == 20)
            {
                laserCreater.createTime = 1;
            }
        }
	}

    public void Retry()
    {
        isPlay = true;
        player.SetActive(true);

        time = 0;
        score = 0;
        laserCreater.createTime = 3;
    }

    void UI()
    {
        time += Time.deltaTime;
        TimerText.text = ((int)time).ToString();

        ScoreText.text = "Score:" + score.ToString("000000");
    }

    public void AddScore(int score)
    {
        this.score += score;
    }
}
