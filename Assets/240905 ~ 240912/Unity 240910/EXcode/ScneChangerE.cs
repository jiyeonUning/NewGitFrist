using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScneChangerE : MonoBehaviour
{
    [SerializeField] Image loadingImage;
    [SerializeField] Slider loadingBar;

    public void ChangeScene(string sceneName)
    {
        if (loadingRoutine != null)return;

        loadingRoutine = StartCoroutine(LoadingRoutine(sceneName));
    }

    Coroutine loadingRoutine;

    IEnumerator LoadingRoutine(string sceneName)
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync(sceneName);

        oper.allowSceneActivation = false;
        loadingImage.gameObject.SetActive(true);

        while (oper.isDone == false)
        {
            if (oper.progress < 0.9f)
            {
                Debug.Log($"loding {oper.progress}");
            }
            else
            {
                break;
            }
            yield return null;
        }

        // 가짜 로딩 과정 
        float time = 0f;

        while (time < 5f)
        {
            time += Time.deltaTime;
            loadingBar.value = time / 5f;
            yield return null;
        }
        Debug.Log("로딩 완료");
        while (Input.anyKeyDown == false)
        {
            yield return null;
        }
        oper.allowSceneActivation = true;
        loadingImage.gameObject.SetActive(false);

        // 새로운 씬용 준비작업
        loadingBar.value = 1f;
        loadingImage.gameObject.SetActive (false);
        loadingRoutine = null;
    }
}
