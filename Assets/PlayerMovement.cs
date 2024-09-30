using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    //kecepatan berlari
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    void Update()
    {
        //mendapatkan nilai horizontal move
        //saat menekan "A" atau "D" akan menambahkan kecepatan berlalri dengan nilai dari 
        //runSpeed
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //karakter dapat melakukan jump
        //apabila menekan space jump bernilai true
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        //menggunakan time.fexiddeltadime agar tidak mengupdate frame setiap ditekan atau bergerak
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        
        //matikan jump setelah menekan space
        jump = false;
    }
}
