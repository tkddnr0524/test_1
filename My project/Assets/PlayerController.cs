using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb; //�÷��̾ �̵���Ű�� ���� RigigBody
    public int moveSpeed = 5; //플레이어 이동 속도
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  //rb에 오브젝트 rigidbody를 넣음

    }

    
    // Update is called once per frame
    void Update()
    {
        // PlayerMove01();
        PlayerMove02();
    }

    public void PlayerMove01()          // 플레이어의 위치를 바꾸어 이동시키게 만드는 함수
    {
        Vector3 moveInput = new Vector3(0,0,0);               //Vector3.zero; == new Vector3(0,0,0);
        moveInput.x = Input.GetAxisRaw("Horizontal");           // 좌우 이동을 입력 받음  //AxisRaw << -1, 0, 1 세가지 값중 하나가 변환(string name)
        moveInput.y = Input.GetAxisRaw("Vertical");             // 상하 이동을 입력 받음

        moveInput.Normalize();                                  // 대각선 가속 방지
        transform.position += moveInput * moveSpeed * Time.deltaTime;            // //타임 델타 타임은 프레임의 변동으로 이동에 영향을 주게 하지않음
    }

    public void PlayerMove02()
    {
        Vector3 moveInput = new Vector3(0,0,0);
        moveInput.x = Input.GetAxisRaw("Horizontal");           
        moveInput.y = Input.GetAxisRaw("Vertical");             

        moveInput.Normalize();

        rb.velocity = moveInput * moveSpeed;
    }
}
