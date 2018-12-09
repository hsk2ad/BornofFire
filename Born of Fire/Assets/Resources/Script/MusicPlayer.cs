using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    public static MusicPlayer instance;

    public AudioSource player;

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        } else {
            Destroy(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        player.loop = true;
        player.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
