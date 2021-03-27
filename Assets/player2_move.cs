using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_move : MonoBehaviour
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
        if (Input.GetKey(KeyCode.D))
        {
            //ｚ軸方向に,Impulseモードで力を加える
            rb.AddForce(0, 0, -500, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //ｚ軸方向に,Impulseモードで力を加える
            rb.AddForce(0, 0, 500, ForceMode.Impulse);
        }
    }
}
