using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMains : MonoBehaviour
{
    public TestManager[] rooms;
    public TestManager main;
    public int Score = 0;
    public GameObject[] hERO;
    TestMainManager testMainManager = new TestMainManager();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Room();
       if(Score > 11 || Score < 21)
        {

        }
    }
    void Room()
    {
        if (Input.GetKey(KeyCode.Space))
        { 
            
            Score++;
            if(Score > 2)
            {
               // Score = 1;
            }
        }
   //     for (int x = 0; x < rooms.Length; x++)
   //     {
   //         Debug.Log("кИШ");
   //// rooms[x] = new TestManager();
   //   //      rooms[x].room = hERO;
   //     }
      //  testMainManager.MainTes();
        main.RoomSystem();
    }
}
