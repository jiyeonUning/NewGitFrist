using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] Transform muzzlePoint; // 레이저를 쏘는 시작점의 위치
    [SerializeField] float maxDistance; // 레이저의 최대 거리
    [SerializeField] LayerMask layerMask; // 레이어 마스크 : 레이어를 통해 충돌할 오브젝트와 충돌하지 않는 오브젝트를 구분하는 등의 기능을 구현할 수 있다.


    // ==============================================================================================================
    //                                       총구에서 레이저를 쏠 수 있는 코드

    // 레이캐스트의 반환형 : bool형
    private void Update()
    {
        if  
        // Physics.Raycast(쏘는 위치, 쏘는 방향 / 부딫혔을 때의 정보( = RaycastHit ), 최대거리, 레이어마스크(=타겟그룹))
        // 부딫혔을 때의 정보를 추출할 수 있는 함수 RaycastHit            
            (Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, maxDistance, layerMask))
        {
            // = 부딫힌 물체가 있을 때
            Debug.Log($"{hit.collider.gameObject.name}와 부딫혔다. 해당 물체와의 거리는 {hit.distance}m 이다.");

            // 레이캐스트가 인식하고 있는 법위를 시각적으로 나타낼 수 있게 해주는 함수 Debug.DrawRay
            // 씬 창에서는 보이나, 게임 창에서는 보이지 않는다.
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * hit.distance, Color.green);

        }
        else  
        {   // = 부딫힌 물체가 없을 때
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * 100, Color.red);
        }
    }

    // ==============================================================================================================
    //                                                ~  기즈모   ~

    // 항상 표시하는 기즈모 함수 OnDrawGizmos
    private void OnDrawGizmosTest()
    {
        // 해당하는 기즈모의 색을 바꿔줄 수 있다.
        Gizmos.color = Color.green;
        // DraWire( ~ ) : 지정한 위치에, ( ~ )모양의 기즈모를 만들어줄 수 있다.
        Gizmos.DrawWireSphere(transform.position,10f);
    }

    // 선택하였을 때 표시되는 기즈모 함수 OnDrawGizmoSelected
    private void OnDrawGizmosSelectedTest()
    {
        // 해당하는 기즈모의 색을 바꿔줄 수 있다.
        Gizmos.color = Color.yellow;
        // DraWire ~ : 해당하는 위치에 
        Gizmos.DrawWireSphere(transform.position, 10f);
    }

    // ==============================================================================================================
    //                                                ~  레이어 충돌   ~


}
