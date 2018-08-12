using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {


    public Text txtScore;

    private void FixedUpdate()
    {
        GetComponent<Text>().text = Data.score.ToString(); // menampilkan data skor ke skor
    }



}
