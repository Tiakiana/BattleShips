using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Audio;

public class Menu : MonoBehaviour {


    public AudioClip[] aclip = new AudioClip[6];
    AudioSource aSource;

   public Sprite[] images = new Sprite[6];
    Image mainView;
    	void Start () {
       mainView = this.gameObject.GetComponent<Image>();
        aSource = gameObject.GetComponent<AudioSource>();
    }

    public void ChooseMusic(int i) {
        aSource.clip = aclip[i];
        aSource.Play();
    }

	void Update () {
	
	}

    public void ShowImage(int i) {
        mainView.overrideSprite = images[i] as Sprite;
    }

   
}
