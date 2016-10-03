using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    float rot = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //MoveManager();
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.0f;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }

    void MoveManager()
    {
        if(Input.GetMouseButton(0))
        {
            rot += 3;
        }
        if (Input.GetMouseButton(1))
        {
            rot -= 3;
        }
        Quaternion r = Quaternion.Euler(0, 0, rot);
        transform.rotation = r;
    }
}
