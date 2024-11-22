using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LoadingScene : MonoBehaviour
{
    private UIDocument _document;

    private ProgressBar _progressBar;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();

        _progressBar = _document.rootVisualElement.Q<ProgressBar>("LoadingProgressBar");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _progressBar.value = 0;
        StartCoroutine(StartLoading());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator StartLoading()
    {
        yield return new WaitForSeconds(1f);
        AsyncOperation load = SceneManager.LoadSceneAsync(1);
        load.allowSceneActivation = false;
        while (!load.isDone)
        {
            _progressBar.value = load.progress * 100;
            yield return new WaitForEndOfFrame();
            if (load.progress >= .9f && !load.allowSceneActivation)
            {
                float time = 0f;
                while (time < 1)
                {
                    time += Time.deltaTime;
                    yield return new WaitForEndOfFrame();
                }
                
                load.allowSceneActivation = true;
            }
        }
        yield return null;
    }
}
