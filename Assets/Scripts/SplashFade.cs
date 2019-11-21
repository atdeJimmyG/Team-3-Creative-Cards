using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashFade : MonoBehaviour
{
    public Image splashImage;
    public string loadLevel;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(5.5f);
        FadeOut();
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 3.5f, false);
    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 4.5f, false);
    }
}
