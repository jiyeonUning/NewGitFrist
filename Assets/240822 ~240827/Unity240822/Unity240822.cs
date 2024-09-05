using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// 유니티 메시지 함수(이벤트 함수) : 유니티가 보내는 메세지에 반응하는 함수.

// < 실행 구조 >
// 1. MonoBehaviour 클래스에 메시지와 같은 이름의 함수가 반응
// 2. 스크립트는 유니티 엔진이 보내는 메시지를 받아, 사건 타이밍을 확인
// 3. 메시지 함수에서 자신의 행동을 정의하여 기능을 구성

public class Unity240822 : MonoBehaviour
{
    // 함수별 기능을 유니티 메시지 함수에 담아 작성 
    private void Awake() // =준비
    {
        // 어웨이크 : 스크립트가 씬에 포함되었을 때, 1회 호출됨
        //            스크립트가 비활성화 되어 있는 경우에도 호출된다.
        //     역할 : 스크립트가 필요로 하는 작업을 초기화 하는 작업을 진행한다. (외부 게임 상황과 무관한 초기화 작업)
        Debug.Log("어웨이크");    
    }

    void Start() // =시작
    {
        // 스타트 : 스크립트가 씬에 처음으로 업데이트 하기 직전에, 1회 호출됨
        //          스크립트가 비활성화 되어 있는 경우에는 호출되지 않는다
        //   역할 : 스크립트가 필요로 하는 작업을 진행한다. (외부 게임상황이 필요한 초기화 작업)
        Debug.Log("시작");
    }

    private void OnEnable() // =활성화
    {
        // 온인에이블 : 스크립트가 활성화될 때 마다 호출
        //       역할 : 스크립트가 활성화 되었을 때 작업을 진행한다.
        Debug.Log("활성화");
    }

    private void OnDisable() //=비활성화
    {
        // 온디세이블 : 스크립트가 비활성화 될 때 마다 호출
        //       역할 : 서크립트가 비활성화 되었을 때 작업을 진행한다.
        Debug.Log("비활성화");
    }

    void Update() // =진행
    {
        // 업데이트 : 게임의 프레임을 호출해준다.
        //     역할 : 핵심 게임 로직을 구현해준다. 동작 도중에는 계속 진행된다.
        Debug.Log("갱신");
    }

    private void OnDestroy() // =마무리 작업
    {
        // 온디스토로이 : 스크립트가 씬에서 삭제되었을 때, 1회 호출
        //         역할 : 스크립트가 필요로 하는 마무리 작업을 진행한다.
        Debug.Log("마무리 작업");
    }

    private void LateUpdate()
    {
        // 레이트업데이트 : 게임의 프레임 마지막마다 호출된다.
        // 씬의 모든 게임오브젝트의 업데이트가 진행된 후 진행한다.
    }

    private void FixedUpdate()
    {
        // 픽스드업데이트 : 추후 작성
    }


    //=================================================================

    // 직렬화 : 데이터 구조, 또는 게임오브젝트 상태를 보관&관리 하는 기법.
    //          인스펙터 창에서 오브젝트의 직렬화된 멤버변수 값을 보여준다.
    //          이를 이용하여, 소스코드의 수정 없이 유니티 에디터에서 값의 변경이 가능하다.

    // <데이터 직렬화>
    // 오브젝트의 멤벼변수 값을 확인 or 변경해줄 수 있다.
    // 오브젝트의 멤버변소 참조를 드래그&드랍 방식으로 연결해줄 수 있다.


    [Header("Value Tpye")]
    // C# 타입
    public bool boolValue;
    public int inValue;
    public float floatValue;
    public string stringValue;

    // 유니티 타입
    public Vector3 vector3; // = x축, y축, z축을 포함하는 데이터
    public Vector3 vector2; // = x축, y축만 포함하는 데이터
    public Vector3Int intVector3;
    public Vector2Int intVector2;
    public Color color;

    public Rect rect;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;

    // 열거형
    public enum JobType { Warrioror, Mage, Rogue }
    public JobType jobType;

    // 배열 기반 자료구조
    public int[] array;
    public List<int> list;

    // 참조
    public Rigidbody rigid;
    public Collider Collider;


    // < 어트리뷰트 > : 클래스, 속성 또는 함수 위에 명시하여, 특별한 동작을 나타낼 수 있는 마커.
    [Space(30)]
    [Header("Referance Tpye")] // = 제목으로 데이터를 나눠준다.
    [SerializeField] private int privateValue; // = private 라도 인스펙터에 노출시켜준다.
    [HideInInspector] public int puvlicValue; // public 이더라도 인스펙터에서 숨겨준다.

    [Range(3, 5)]
    public float percent; // = 값을 지정한 값 만큼 슬라이드로 조정해줄 수 있다.

    [TextArea(3, 5)]
    public string story; // = 한번에 보이는 문장수를 지정하고, 그 이상을 넘어가면 슬라이드로 넘어가게 해줄 수 있다.

    [System.Serializable]
    public struct Data // = 구조체에 작성된 데이터의 값을 조정해줄 수 있다.
    {
        public string name;
        public int level; 
        public float rate;
    }
    public Data data;

    [System.Serializable]
    public class ClassTpye // 클래스도 동일
    {
        public string Name;
        public int Level;
        public float Rate;
    }
    public ClassTpye classType;

    // 회전 메모
    [SerializeField] float rotateSpeed;
    [SerializeField] float yRotate;
    [SerializeField] float xRotate;
    [SerializeField] Quaternion target;

    void RotateTest()
    {
        // 1. 축을 통해서 각도로 회전
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // 2. 기준점을 기준으로 회전
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        // 3. 목표 위치를 바라보도록 회전
        transform.LookAt(Vector3.zero);

        // 4. 회전 각도값을 주어줘서 회전
        transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);

        // 5. 방향으로 회전
        transform.rotation = Quaternion.LookRotation(Vector3.right);

        // 6. 처음에는 빨랐다가, 느려지면서 회전
        transform.rotation = Quaternion.Lerp(transform.rotation, target, 3 * Time.deltaTime);

        // 7. 목표회전으로 지속적으로 회전
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, rotateSpeed * Time.deltaTime);

    }
}
