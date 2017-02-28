using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CreateDBScript : MonoBehaviour {

	public Text DebugText;

	// Use this for initialization
	void Start () {
		StartSync();
	}

    private void StartSync()
    {
		var sdb = new SoundDB("AudioLibrary.db");
		sdb.initDB();
        
		var soundFiles = sdb.GetSoundFiles ();
        ToConsole (soundFiles);
		var soundPath = sdb.getSoundFilePath ("Dog");
        ToConsole("Searching for Dog ...");
		ToConsole (soundPath); 
//		sdb.createSoundFile("Zebra");
//		ToConsole("New Animal has been created");
//		var p = ds.GetAnimalSound ("Zebra");
//		ToConsole(p.ToString());
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
