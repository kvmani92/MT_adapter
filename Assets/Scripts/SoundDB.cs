using SQLite4Unity3d;
using UnityEngine;

using System.Collections.Generic;

public class SoundDB  {

	private SQLiteConnection _connection;

	public SoundDB(string databaseName){

        var dbPath = string.Format(@"Assets/StreamingAssets/{0}", databaseName);

        _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        Debug.Log("Final PATH: " + dbPath);     

	}

	public void initDB(){
		_connection.DropTable<SoundFile> ();
		_connection.CreateTable<SoundFile> ();

		_connection.InsertAll (new[]{
			new SoundFile{
				Id = 1,
				Name = "Lion",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Lion, Roars, King"
			},
			new SoundFile{
				Id = 2,
				Name = "Duck",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Duck"
			},
			new SoundFile{
				Id = 3,
				Name = "Frog",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Frog, Croac"
			},
			new SoundFile{
				Id = 4,
				Name = "Hippo",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Hippopotomus, Hippo"
			},
			new SoundFile{
				Id = 5,
				Name = "Dog",
				Path = "Assets/StreamingAssets/Sounds/Dog.mp3",
				Tags = "Dog, Bark, Friend"
			},
			new SoundFile{
				Id = 6,
				Name = "Monkey",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Monkey, Ape, Chimpanzee"
			},
			new SoundFile{
				Id = 7,
				Name = "Snake",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Snake, Cobra"
			},
			new SoundFile{
				Id = 8,
				Name = "Wolf",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Wolf, Direwolf"
			},
			new SoundFile{
				Id = 9,
				Name = "Elephant",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Elephant, Giant"
			},
			new SoundFile{
				Id = 10,
				Name = "Penguin",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Penguin, Antartica"
			},
			new SoundFile{
				Id = 11,
				Name = "Cat",
				Path = "Assets/StreamingAssets/Sounds/Lion.mp3",
				Tags = "Cat, Meow"
			}
		});
	}

	public IEnumerable<SoundFile> GetSoundFiles(){
		return _connection.Table<SoundFile>();
	}

	//select path where animal name or tags is that.
	public string getSoundFilePath(string soundName){
		SoundFile con = _connection.Table<SoundFile>().Where(x => x.Name.ToLower() == soundName.ToLower()).First();
		return con.Path;
	}

	//return all tags of that specific animal.
	public SoundFile getTags(string soundName){
		var con = _connection.Table<SoundFile>().Where(x => x.Name.ToLower() == soundName.ToLower()).First();
		return con;
	}

	//create a new animal with given animal name and path.
//	public SoundFile createSoundFile(string name, string tag){
//		var p = new SoundFile{
//				Name = name,
//				Path = string.Format(@"Assets/StreamingAssets/Sounds/{0}.mp3", name),
//				Tags = tag
//		};
//		_connection.Insert (p);
//		return p;
//	}
}
