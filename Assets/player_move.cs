using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    //publicなRigidbody型のrbを宣言する
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //ｚ軸方向に,Impulseモードで力を加える
            rb.AddForce(0, 0, -500, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //ｚ軸方向に,Impulseモードで力を加える
            rb.AddForce(0, 0, 500, ForceMode.Impulse);
        }
    }
}
