namespace Telegraph.Models;

/// <summary>
/// This object represents a file ready to be uploaded.
/// </summary>
public class FileToUpload
{
	/// <summary>
	/// File bytes
	/// </summary>
	public byte[] Bytes { get; set; }

	/// <summary>
	/// MIME type. Available: image/gif, image/jpeg, image/jpg, image/png, video/mp4
	/// </summary>
	public string Type { get; set; }
}