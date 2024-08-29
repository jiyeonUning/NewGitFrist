using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    [SerializeField] GameObject tankPrefab;
    [SerializeField] Rigidbody rigidPrefab;
    [SerializeField] Rigidbody targetRigid;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // <생성>
            // Instantiate (생성할 오브젝트, 생성 위치) =  ()에 해당하는 오브젝트를 해당하는 위치에 생성한다.
            GameObject instance = Instantiate(tankPrefab, transform.position, transform.rotation);
            instance.name = "생성한 오브젝트의 이름을 생성해줄 수 있다.";

            // 리지드바디를 가진 오브젝트를 새로 생성하면서, 생성할 때 마다 앞으로 튕겨나가게 하는 기능 코드
            Rigidbody rigid = Instantiate(rigidPrefab, transform.position, transform.rotation);
            rigid.AddForce(Vector3.forward * 7, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //<파괴>
            // Destroy (제거할 오브젝트) = ()에 해당하는 오브젝트를 삭제한다. 
            Destroy(tankPrefab, 2); // 해당하는 오브젝트 뒤에 숫자를 붙이면, 해당하는 초만큼 딜레이 후 삭제시켜줄 수 있다.
        }
    }
}
