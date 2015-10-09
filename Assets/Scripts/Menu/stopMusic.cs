using UnityEngine;
using System.Collections;

public class stopMusic : MonoBehaviour {

    public GameObject audio;

	public int isMutedAudio;
	private bool isToMuteNow = false;
	private bool isToUnmuteNow = false;

	void Awake() {
		checkMusic ();
		//Debug.Log ("isMutedAudio :: " + isMutedAudio);
	}

	void checkMusic() {
		isMutedAudio = PlayerPrefs.GetInt("config.musicIsMuted");
		if (isMutedAudio == 1) {
			audio.audio.mute = true;

		} else {
			audio.audio.mute = false;
		}
	}

	void setMusic() {
		if (isMutedAudio == 1) {
			//unmuteNow();
			isToUnmuteNow = true;
			isMutedAudio = 0;

		} else {
			//muteNow();
			isToMuteNow = true;
			isMutedAudio = 1;

		}
		
		PlayerPrefs.SetInt("config.musicIsMuted", isMutedAudio);
	}

	void muteNow(){
		if (audio.audio.volume <= 0) {
			audio.audio.mute = true;
			isToMuteNow = false;

		} else {
			audio.audio.volume -= Time.deltaTime;
		}

	}

	void unmuteNow() {
		if (audio.audio.mute == true) {
			audio.audio.mute = false;

		}
		if (audio.audio.volume < 1) {
			audio.audio.volume += Time.deltaTime;
		}
		if (audio.audio.volume == 1) {
			isToUnmuteNow = false;
		}

	}

	void Update() {
		if (isToMuteNow) {
			muteNow();
		}
		if (isToUnmuteNow) {
			unmuteNow();
		}
	}

    void OnMouseDown()
    {
		//Debug.Log ("isMutedAudio :: " + isMutedAudio);
		setMusic ();
    }
}
