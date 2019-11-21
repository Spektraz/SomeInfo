using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class I : MonoBehaviour

{
    public GameObject hER;
    public Vector3 her;
    private float a = 0.2f;
    UnityEvent unityEvent2 = new UnityEvent();
    UnityEvent unityEvent1 = new UnityEvent();
    private float i = 8;


    private float e = 1f;
    public Vector3 First = new Vector3(0, 0, 0);
    public Vector3 Second = new Vector3(1, 1, 0);
    // Start is called before the first frame update

    void Start()

    {


    }


    // Update is called once per frame

    void Update()
    {
        //e -= Time.deltaTime;
      
        //    if (e >= 0.0f)
        //    {
        //        transform.position += new Vector3(i * Time.deltaTime, 0, 0);
        //    }
        
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, i * Time.deltaTime, 0);

        //}
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    transform.position += new Vector3(0, 0, i * Time.deltaTime);

        //}
    }

    //private void OnAnimatorMove()
    //{
    //    Animator animator = GetComponent<Animator>();

    //    if (animator)
    //    {
    //        Vector3 newPosition = transform.position;
    //        newPosition.x += animator.GetFloat("Runspeed") * Time.deltaTime;
    //        transform.position = newPosition;
    //    }
    //}

    public void MoveS()
    {
        Second = new Vector3(1, 1, 0);
        hER.transform.position = Second;
        Debug.Log("Привет");
    }
    public void MoveF()
    {
        First = new Vector3(0, 0, 0);
        hER.transform.position = First;
        Debug.Log("Пока");
    }
}