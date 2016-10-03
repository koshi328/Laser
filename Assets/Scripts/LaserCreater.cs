using UnityEngine;
using System.Collections;

public class LaserCreater : MonoBehaviour {
    public GameObject laser;

    public int createTime;
    private float nowTime;
	// Use this for initialization
	void Start () {
        nowTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        nowTime += Time.deltaTime;
        if(nowTime >= createTime)
        {
            nowTime = 0;
            int num = Random.Range(3, 8);
            for (int i = 0; i < num; i++) 
                InstanceLaser();
        }
	}


    void InstanceLaser()
    {
        int r = Random.Range(0, 3);
        int y = Random.Range(-3, 7);
        switch(r)
        {
            case 0:
                Instantiate(laser, this.transform.position + new Vector3(0, y, 0), Quaternion.Euler(0, 0, 0));
                break;
            case 1:
                Instantiate(laser, this.transform.position + new Vector3(0, y, 0), Quaternion.Euler(0, 0, 20));
                break;
            case 2:
                Instantiate(laser, this.transform.position + new Vector3(0, y, 0), Quaternion.Euler(0, 0, -20));
                break;
        }
    }
}
