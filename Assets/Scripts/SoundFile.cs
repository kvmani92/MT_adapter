using SQLite4Unity3d;

public class SoundFile  {

	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }
	public string Name { get; set; }
	public string Path { get; set; }
	public string Tags { get; set; }

	public override string ToString ()
	{
		return string.Format ("[Animals: Id={0}, Name={1},  Path={2}, Tags={3}]", Id, Name, Path, Tags);
	}
}
