using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
    
    public float speed;
    private GameController gameController;
	// Use this for initialization
	void Start () {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

    }
	
	// Update is called once per frame
	void Update () {
        if (speed <= 1.5f)
        {
            speed = -0.1f + gameController.time * -0.001f;
        }
        transform.position += new Vector3(0, 0, speed);

        if(transform.position.z <= -8)
        {
            gameController.AddScore(100);
            Destroy(gameObject);
        }

        if(!gameController.isPlay)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag != "Player") return;
        col.gameObject.SetActive(false);
        gameController.isPlay = false;
    }
}
