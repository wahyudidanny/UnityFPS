using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMuncul : MonoBehaviour {

    [SerializeField]
    private GameObject zombie;
    private GameObject player;

    GameObject[] monster;
    float timer = 0;
    



	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 3f) //  Memunculkan monster dilakukan setiap 3 detik
        {
            Vector3 posRecomended;
            do
            {
                posRecomended = new Vector3(Random.Range(0, 500), 50, Random.Range(0, 500));
            } while (Vector3.Distance(posRecomended, player.transform.position) < 50f);
                     Instantiate(zombie, posRecomended, Quaternion.identity);
                     timer = 0;
        }

        //Variable posRecomended merupakan posisi yang digunakan untuk memunculkan Zombie. veriable tersebut juga merupakan Vector3(x,y,z) yang dimana posisi secara horizontal ditentukan nilai x dan z, sedangkan untuk posisi vertical ditentukan oleh nilai y. Pemberian nilai x dan z dengan nilai acak antara 0 sampai 500 dikarenakan luas terrain 500 x 500, sedangkan pemberian nilai y 50 karena menginginkan zombile muncul dari atas. Pada code while ( Vector3.Distance(posRecomended , player.transform.position) < 100f); digunakan untuk memastikan jarak minimal player dengan zombie adalah 100.

    }
}
