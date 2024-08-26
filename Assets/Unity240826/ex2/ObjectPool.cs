using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // < 디자인 패턴 : 오브젝트 풀 패턴 >
    //    프로그램 내에서 빈번하게 재활용하는 인스턴스들을 '풀'에 보간한 뒤
    // -> 인스턴스의 생성&삭제 대신, 대여&반납을 사용하는 기법.

    // < 구현법 >
    // 1. 인스턴스들을 보관할 '풀'을 생성한다.
    // 2. 프로그램의 시작 시, '풀'에 인스턴스들을 생성하여 보관한다.
    // 3. 인스턴스 생성이 필요할 때, '풀'에서 대여하여서 사용해준다.
    // 4. 인스턴스 삭제가 필요할 때, '풀'에 도로 반납하여 보관해둔다.

    // < 주의점 >
    // 1. 
    // 2. 오브젝트 풀 힙 영역의 여유공간이 줄어들어 오히려 프로그램에 부담이 되는 경우가 있다.





    [SerializeField] List<PooledObject> pool = new List<PooledObject>();
    [SerializeField] PooledObject prefab;
    [SerializeField] int size;

    void Awake()
    {
        for (int i = 0; i < size; i++)
        {
            PooledObject instance = Instantiate(prefab);
            instance.gameObject.SetActive(false);
            instance.transform.parent = transform;
            instance.returnPool = this;
            pool.Add(instance);
        }
    }

    // 풀에 보관한 것을 대여하는 함수
    public PooledObject GetPool(Vector3 position, Quaternion rotation)
    {
        if (pool.Count > 0)
        {
            PooledObject instance = pool[pool.Count - 1];
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            instance.transform.parent = null;
            instance.returnPool = this;
            instance.gameObject.SetActive(true);


            pool.RemoveAt(pool.Count - 1);

            return instance;
        }
        else
        {
            PooledObject instance = Instantiate(prefab, position, rotation);
            return instance;
        }
    }

    // 대여한 것을 다시 반납하는 함수
    public void ReturnPool(PooledObject instance)
    {
        instance.gameObject.SetActive(false);
        instance.transform.parent = transform;
        pool.Add(instance);
    }
}
