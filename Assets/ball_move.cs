using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{
    //publicなRigidbody型の「rb」を宣言する
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rbのAddForce関数でx軸方向に10、Impulseモードで力を加える
        rb.AddForce(-10, 0, 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
