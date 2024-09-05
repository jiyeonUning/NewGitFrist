using UnityEngine;

public class MoveClick : MonoBehaviour
{
    // < 코드 작성 전 알아두면 좋은 정보 > : 자동으로 참조하기
    //         [ 사용 시 주의점 ]          : 태그는 딱 하나만 있는 컴포넌트에게만 사용해주는 것을 추천
    //                          찾는 속도는 빠르나, 연산과정이 많아서 컴퓨터에 부하가 걸림

    // 태그가 "MainCamera"인 카메라 컴포넌트를 가져올 수 있는 코드 : Camera.main;
    // 특정 태그를 단 게임 오브젝트를 가져올 수 있는 함수 : GameObject.FindGameObjectWithTag("(탐색할 태그의 이름)");

    // ==================================================================================================================
    // ==================================================================================================================
    //                                                  ~ 만들어 줄 기능 ~

    //   게임창에서 마우스를 우클릭 하면, 해당 위치로 이동하는 캐릭터 조작 구현
    // = 카메라에서 레이저를 쏘아, 레이저가 해당하는 위치와 부딫히면 이동하는 방식의 원리

    // ==================================================================================================================
    // ==================================================================================================================



    [SerializeField] Camera cam;                 // 카메라가 참조될 장소
    [SerializeField] GameObject playerOBJ;       // 게임 오브젝트가 참조될 장소
    [SerializeField] PlayerMoveThere playermove; // 플레이어가 이동하는 컴포넌트가 참조될 장소



    private void Start()
    {
        // "MainCamera" 태그를 가진 컴포넌트를 게임 실행 시 자동으로 참조시켜준다.
        cam = Camera.main;
        // "Player" 태그를 가진 컴포넌트를 게임 실행 시 자동으로 참조시켜준다.
        playerOBJ = GameObject.FindGameObjectWithTag("Player");
        // GetComponent를 통해 플레이어 컴포넌트를 가져온다.
        playermove = playerOBJ.GetComponent<PlayerMoveThere>();
    }

    private void Update()
    {
        // 이동하고 싶은 위치을 향해 마우스 우클릭 버튼을 눌렀을 때, 이동이 이루어지게 하는 if문
        if (Input.GetMouseButtonDown(1)) { ClickMove(); }
    }

    void ClickMove()
    {
        // 카메라에서 해당하는 위치를 향해 레이저(ray)의 위치값을 저장하게 해줄 수 있는 함수 ScreemPointToRay
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        // 레이저가 어떠한 바닥 오브젝트에 닿았을 때,
        if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
        {
            Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red, 0.2f);
            // 값을 저장한 후, 플레이어 컴포넌트를 통해 레이저가 부딫힌 위치로 이동한다.
            Vector3 destination = hit.point;
            playermove.Move(destination);
        }
        // 그렇지 않을 땐,
        else
        {
            // 레이캐스트의 시작지점값, 어느 방향으로 얼마나 레이저를 길게 쏠 것인지, 레이저의 색, 레이저는 몇 초 간 등장하는지
            //  ~ 에 대한 정보값을 작성하고, DrawRay를 통해 레이저를 발사한다.
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 0.2f);
        }

    }
}
