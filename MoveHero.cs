using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rigidbody2D;
    public GameObject hero;
    public bool InCrouch; // разрешение на прыжок
    [SerializeField] private bool isGrounded = false; // находится ли персонаж на хемле или нет
    [SerializeField] private float speed;
    [SerializeField] private float jump;

    private bool check = false; // Положение персонажа в присиде
    public Transform froundCheck; //для соприкосновение с землей
    private float groundRadius = 0.2f; //радиус
    public LayerMask whatisGround; // ссылка на слой, представляющий землю
    void Start()
    {
       // anim.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0); //передвижени
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 4f * Time.deltaTime, 0); //передвижени
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0); //передвижени
        }
        CrouchLogic();

    }
    private void FixedUpdate()
    {
        JumpLogic();
    }

    void JumpLogic()
    {
        if (InCrouch == true)
        {
            Rigidbody2D rigidbody2D = new Rigidbody2D();
            isGrounded = Physics2D.OverlapCircle(froundCheck.position,
                groundRadius, whatisGround); // высчитывает находится ли персонаж на земле
            if (!isGrounded) // не на земле
            {
                return;
            }
            if (isGrounded && Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            { // на землb

                //  anim.SetFloat("vSpeed", rigidbody2D.velocity.y);
                //    anim.SetBool("Ground", false);
                //    transform.Translate(0, Time.deltaTime * jump, 0);
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 50);
                //  rigidbody2D.AddForce(new Vector3(0, 3200));
            }
        }
    }
    void CrouchLogic()
    {
        if (isGrounded && Input.GetKey(KeyCode.DownArrow)) // присед
        {
            InCrouch = false;
            if (check == false)
            {
                StartCoroutine(crouchOn());
            }
        }
        if (!Input.GetKey(KeyCode.DownArrow))
        {
            StartCoroutine(crouchOff());
        }
    }

    IEnumerator crouchOn() // логика приседа
    {

        yield return new WaitForSeconds(0.1f);
        check = true;
        this.transform.localScale = new Vector3(1.3f, 0.7f, 1);
    }
    IEnumerator crouchOff() // выкл логики приседа
    {

        yield return new WaitForSeconds(0.1f);
        check = false;
        this.transform.localScale = new Vector3(1f, 1f, 1);
        InCrouch = true;
    }
}