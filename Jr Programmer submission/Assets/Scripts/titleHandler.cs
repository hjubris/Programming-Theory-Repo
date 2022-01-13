using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class titleHandler : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI title;

    private int fadeTime = 4;
    private int waitTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(titleFadeIn(1f, title));
    }
    private void Update()
    {
        SkipFade();
    }

    void SkipFade()
    {
        if (Input.GetMouseButton(0))
        {
            fadeTime = 0;
            waitTime = 0;
        }
    }

    IEnumerator titleFadeIn(float time, TextMeshProUGUI title)
    {
        title.color = new Color(title.color.r, title.color.g, title.color.b, 0);
        while (title.color.a < 1.0f)
        {
            title.color = new Color(title.color.r, title.color.g, title.color.b, title.color.a + (fadeTime * Time.deltaTime / time));
        }
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("menu");
    }
}
