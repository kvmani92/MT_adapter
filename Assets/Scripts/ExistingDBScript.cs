using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ExistingDBScript : MonoBehaviour {

	public Text DebugText;

	// Use this for initialization
	void Start () {
		SoundDB sdb = new SoundDB ("existing.db");
		//ds.CreateDB ();
		var soundFiles =  sdb.GetSoundFiles();
		ToConsole (soundFiles);

		string soundFilePath = sdb.getSoundFilePath("Lion");
		ToConsole("Searching for Lion Sound ...");
		ToConsole (soundFilePath);



	}
	
	private void ToConsole(IEnumerable<SoundFile> soundFiles){
		foreach (var soundFile in soundFiles) {
			ToConsole(soundFile.ToString());
		}
	}

	private void ToConsole(string msg){
		DebugText.text += System.Environment.NewLine + msg;
		Debug.Log (msg);
	}

}
