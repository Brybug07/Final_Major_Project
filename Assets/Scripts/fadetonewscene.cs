using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadetonewscene : MonoBehaviour
{
    // Start is called before the first frame update

    public string nextScene;

    public Canvas canvas;
    public float fadingSpeed = 3f;

    private bool stopFading = false;
    private float desiredAlpha;


    // when the GameObjects collider arrange for this GameObject

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(OverAllTime(fadingSpeed));
 
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gototscene()
    {
        SceneManager.LoadScene(nextScene);
    }



    IEnumerator CanvasAlphaChangeOverTime(Canvas canvas, float duration)
    {
        var alphaColor = canvas.GetComponent<CanvasGroup>().alpha;
        desiredAlpha = 1.0f;

      

        while (true)
        {
            alphaColor = Mathf.MoveTowards(alphaColor, desiredAlpha, 2.0f * Time.deltaTime);
            canvas.GetComponent<CanvasGroup>().alpha = alphaColor;

            if (stopFading == true)
            {
                break;
            }

            yield return null;
        }
    }

    IEnumerator OverAllTime(float time)
    {
        StartCoroutine(CanvasAlphaChangeOverTime(canvas, fadingSpeed));

        yield return new WaitForSeconds(time);

        stopFading = true;
        StopCoroutine("CanvasAlphaChangeOverTime");

        Gototscene();
    }

}
