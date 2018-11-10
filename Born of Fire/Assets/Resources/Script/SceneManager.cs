using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(RawImage))]
public class SceneTransition : MonoBehaviour {

    public static SceneTransition instance;

    public Color fadecolor;

    public float fadeTime;

    RawImage img;
    bool changing;

	// Use this for initialization
	void Start () {
        instance = this;
        img = GetComponent<RawImage>();
        fadecolor.a = 0;
        img.color = fadecolor;

        DontDestroyOnLoad(transform.parent);
        changing = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator LoadScene(string sceneName) {
        
        float fadeCounter = 0;

        while(fadeCounter < fadeTime) {
            yield return null;
            fadeCounter += Time.deltaTime;
            img.color = new Color(fadecolor.r, fadecolor.g, fadecolor.b, fadeCounter / fadeTime);
        }
        img.color = new Color(fadecolor.r, fadecolor.g, fadecolor.b, 1);

        SceneManager.LoadScene(sceneName);

        fadeCounter = 0;
        while(fadeCounter < fadeTime) {
            yield return null;
            fadeCounter += Time.deltaTime;
            img.color = new Color(fadecolor.r, fadecolor.g, fadecolor.b, 1 - (fadeCounter / fadeTime));
        }
        img.color = new Color(fadecolor.r, fadecolor.g, fadecolor.b, 0);

        yield return null;
    }

    public static void GoToScene(string sceneName) {
        if(instance.changing) {
            return;
        }

        instance.StartCoroutine(instance.LoadScene(sceneName));
    }
}
