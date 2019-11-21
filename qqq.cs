using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qqq : MonoBehaviour
{
    public bool TF;
    public string answer;
    public string question;
    public bool[,] ArrayRoomPlace = new bool[4, 4] { { false, false, false, false }, { false, false, false, false }, { false, false, false, false }, { false, false, false, false } };
    // Start is called before the first frame update
    void Start()
    {
        Qq();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Qq()
    {
        for (int i = 0; i < ArrayRoomPlace.GetLength(0); i++)
        {
            for(int j = 0;j < ArrayRoomPlace.GetLength(1); j++)
            {               
            //  ArrayRoomPlace[i, j] = false;
                Debug.Log(ArrayRoomPlace[i, j] + " " + i + " " + j);
                
            }
        }

    }
}
