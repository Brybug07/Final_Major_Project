using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeToNewScene : MonoBehaviour
{
    [SerializeField] private string _nextScene;

    [SerializeField] private Canvas _canvas;
    [SerializeField] private float _fadingSpeed = 3f;

    private bool _stopFading;
    private float _desiredAlpha = 1.0f;
    private Coroutine _coroutine;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _coroutine =  StartCoroutine(OverAllTime(_fadingSpeed));
    }

    void GoToNextScene()
    {
        SceneManager.LoadScene(_nextScene);
    }

    IEnumerator CanvasAlphaChangeOverTime(Canvas canvas, float duration)
    {
        if (!canvas.TryGetComponent(out CanvasGroup canvasGroup)) yield break;

        var alphaColor = canvasGroup.alpha;

        while (true)
        {
            alphaColor = Mathf.MoveTowards(alphaColor, _desiredAlpha, 2.0f * Time.deltaTime);
            canvasGroup.alpha = alphaColor;

            if (_stopFading)
            {
                yield break;
            }

            yield return null;
        }
    }

    IEnumerator OverAllTime(float time)
    {
        StartCoroutine(CanvasAlphaChangeOverTime(_canvas, _fadingSpeed));

        yield return new WaitForSeconds(time);

        _stopFading = true;
        StopCoroutine(_coroutine);

        GoToNextScene();
    }
}