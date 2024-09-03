using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] Transform muzzlePoint; // 레이저를 쏘는 시작점의 위치
    [SerializeField] float maxDistance; // 레이저의 최대 거리

    // =======================================================================
    //                   총구에서 레이저를 쏠 수 있는 코드

    // 레이캐스트의 반환형 : bool형
    private void Update()
    {
        // 레이캐스트가 인식하고 있는 법위를 시각적으로 나타낼 수 있게 해주는 함수 DrawRay
        // 씬 창에서는 보이나, 게임 창에서는 보이지 않는다.

        if  // = 부딫힌 물체가 있을 때
        // Physics.Raycast(쏘는 위치, 쏘는 방향, 부딫혔을 때의 정보( = RaycastHit ), 최대거리)
        // 부딫혔을 때의 정보를 추출할 수 있는 함수 RaycastHit            
            (Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, maxDistance))
        {
            Debug.Log($"{hit.collider.gameObject.name}와 부딫혔다. 해당 물체와의 거리는 {hit.distance}m 이다.");
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * hit.distance, Color.red);

        }
        else  // = 부딫힌 물체가 없을 때
        {
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward * 100, Color.red);
        }
    }
}
