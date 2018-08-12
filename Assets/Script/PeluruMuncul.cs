using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PeluruMuncul : MonoBehaviour {


    public Rigidbody peluru;
    [Range (0,100)]
    
    public float speed = 30;


    void Start()
    {

    }

    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1")) //Merespon setiap melakukan klik kiri pada mouse
        {
            Rigidbody peluruBaru = (Rigidbody)GameObject.Instantiate(peluru, transform.position, transform.rotation); //Menciptakan peluru/bullet dengan posisi tepat didepan posisi pistol
            peluruBaru.velocity = transform.TransformDirection(Vector3.up * speed); //Melontarkan peluru kearah sumbu Y (Vector3.Up) dengan kecepatan yang telah ditentukan oleh variable speed.
            Destroy(peluruBaru.gameObject, 3); //Peluru akan menghilang selama 3 detik

        }


    }

}
