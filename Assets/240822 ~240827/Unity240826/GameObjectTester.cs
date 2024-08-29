using UnityEngine;

public class GameObjectTester : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Transform trans;
    [SerializeField] Rigidbody rigid;
    [SerializeField] Collider coll;

    void Start()
    {
        Debug.Log($"참조한 게임 오브젝트의 이름 : {target.name}");
        target.name = "탱크";
    }


    private void Write() // <오브젝트 컴포넌트 참조> : 유니티 엔진이 지원하는 메서드.
                         // 특정 오브젝트가 가진 컴포넌트를 참조할 수 있도록 할 수 있다.
    {
        // GetComponent = 해당 오브젝트에 연결된 타입<T>의 컴포넌트를 반환한다.
        // 컴포넌트가 여러 개 있을 때는, 가장 첫 번째로 발결한 컴포넌트 하나만 반환한다.
        // 해당 타입에 컴포넌트가 존재하지 않는다면, null을 반환한다.
        gameObject.GetComponent<Collider>();

        // GetComponents = 해당 오브젝트에 연결된 타입<T>의 모든 컴포넌트를 배열로 반환하여 전부 가져온다.
        // 해당 타입에 컴포넌트가 존재하지 않는다면, 빈 배열을 반환한다.
        gameObject.GetComponents<Collider>();

        // GetComponentInChildren = 해당 오브젝트와, 그 오브젝트의 자식을 순회하면서
        //                       -> 연결된 타입<T>의 컴포넌트를 반환한다.
        // 컴포넌트가 여러 개 있을 때는, 가장 첫 번째로 발견한 컴포넌트 하나만 반환한다.
        // 해당 타입에 컴포넌트가 존재하지 않는다면, null을 반환한다.
        gameObject.GetComponentInChildren<Collider>();

        // GetComponentsInChildren = 해당 오브젝트와, 그 오브젝트의 자식들을 순회하면서
        //                        -> 연결된 타입<T>의 모든 컴포넌트를 배열로 반환하여 전부 가져온다.
        // 해당 타입에 컴포넌트가 존재하지 않는다면, 빈 배열을 반환한다.
        gameObject.GetComponentsInChildren<Collider>();

        // GetComponentInParent = 해당 오브젝트와, 그 오브젝트의 부모들을 순회하면서
        //                     -> 연결된타입<T>의 컴포넌트를 반환한다.
        // 컴포넌트가 여려 개 있을 때는, 가장 첫 번째로 발견한 컴포넌트 하나만 반환한다.
        // 해당 타입에 컴포넌트가 존재하지 않는다면, null을 반환한다.
        gameObject.GetComponentInParent<Collider>();

        // GetComponentsInParent = 해당 오브젝트와, 그 오브젝트의 부모들을 순회하면서
        //                     -> 연결된 타입<T>의 모든 컴포넌트를 배열로 반환하여 전부 가져온다.
        // 해당 타입에 컴포넌트가 존재하지 않는다면, 빈 배열을 반환한다.
        gameObject.GetComponentsInParent<Collider>();
    }

}
