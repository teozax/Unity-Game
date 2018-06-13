using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Position : MonoBehaviour {

    public Transform opponent1;
    public Transform opponent2;
    public Transform myplayer;
    public Text Position1;
    int pos = 3;
    int k = 0;
    int j = 0;

    void Update()
    {
        if ((opponent1.position.z < myplayer.position.z) && k == 0)
        {
            pos--;
            k = 1;
        }

        if ((opponent1.position.z > myplayer.position.z) && k == 1)
        {
            pos++;
            k = 0;
        }

        if ((opponent2.position.z < myplayer.position.z) && j == 0)
        {
            pos--;
            j = 1;
        }

        if ((opponent2.position.z > myplayer.position.z) && j == 1)
        {
            pos++;
            j = 0;
        }

        Position1.text = pos.ToString("0");
    }
}
