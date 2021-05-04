using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private float speed = 1;
    private Vector2 screenbound;
    public GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Score");
        //screenbound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //Debug.Log("screenbound_x: " + screenbound.x+" screenbound_y: " + screenbound.y);
    }

    // Update is called once per frame
    void Update()
    {

        speed = 1 + ((float)(Score.GetComponent<score>().scorepoint)) / 100.0f;

        GetComponent<Rigidbody>().velocity = new Vector3(-speed, 0, 0);
        if (transform.position.x < -20)//screenbound.x*4)
        {
            Destroy(this.gameObject);
        }
    }
}
