using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ledakan : MonoBehaviour {


    public GameObject particleledakan; //Berfungsi untuk menempatkan partikel yang akan dimasukkan dari inspector

    private void OnCollisionEnter(Collision collision) //Berfungsi ketika object bersentuhan dengan object yang lain
    {
        ContactPoint cp = collision.contacts[0];//ContactPoint adalah catatan setiap object menyentuh object lain. Pengambilan index 0 dimaksudkan untuk nilai pertama kali didapatkan.
        Quaternion rotasi = Quaternion.FromToRotation(Vector3.up, cp.normal); //Mencari nilai yang dimana sumbu Y berada diatas
        GameObject.Instantiate(particleledakan, cp.point, rotasi);//Menciptakan partikel dengan posisi dan rotasi yang telah ditentukan sebelumnya
        Destroy(gameObject);//Menghapus gameObject
    }


}
