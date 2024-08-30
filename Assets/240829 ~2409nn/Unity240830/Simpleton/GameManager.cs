using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    //========================================================================================================


    // 1. 단 하나의 인스턴스르 보장한다.

    // 게임에 단 하나만 존재할 수 있는 static 변수를 생성
    private static GameManager instance = null;

    private void Awake()
    {
        // Awake : 처음 만들어졌을 때 호출되는 함수

        // (1) 호출될 때 싱글톤이 없었으면 -> 지금 만든 인스턴스를 싱글톤으로 사용한다
        if (instance == null)
        {
            instance = this;
            // DontDestroyOnLoad = 현재 씬에서 새로운 씬전환(=로딩)으로의 전환을 실행하면서도,
            //                     현재 씬을 지워지지 않는 게임오브젝트로 만들어준다.
            DontDestroyOnLoad(gameObject);
        }
        // (2) 호출될 때 싱글톤이 있었으면 -> 지금 만든 인스턴스를 삭제한다
        else // = if (instance != null)
        {
            Destroy(instance);
        }

        // 해당 코드를 실행 시 : 씬 내에 게임매니저가 여러 개 존재하더라도, 단 하나만 남기고 삭제시켜준다.
    }


    //========================================================================================================

    // 2. 프로그램 어디에서든지 접근할 수 있는, 전역적인 접근점을 제공한다.

    public static GameManager Instance { get { return instance; } }
    //    해당 변수를 통해, 게임매니저를 사용하고 싶을 땐
    // -> Instance를 불러와, 게임 어디에서든지 사용해줄 수 있게 할 수 있다.


}
