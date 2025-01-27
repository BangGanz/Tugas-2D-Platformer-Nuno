using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform player;
    public Transform Bg1;
    public Transform Bg2;
    public Transform Bg3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x != transform.position.x && player.position.x > 0 && player.position.x<18f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, transform.position.y, transform.position.z), 0.1f);
        }
        Bg1.transform.position = new Vector2(transform.position.x*1f, transform.position.y);
        Bg2.transform.position = new Vector2(transform.position.x*0.8f, transform.position.y);
        Bg3.transform.position = new Vector2(transform.position.x * 0.6f, transform.position.y);
    }
}
