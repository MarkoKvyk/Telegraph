namespace Telegraph.Models;

/// <summary>
///  This object represents a file uploaded to Telegram servers.
/// </summary>
public class TelegraphFile
{
	/// <summary>
	/// File path
	/// </summary>
	public string Path { get; set; }

	/// <summary>
	/// Full link to the telegraph
	/// </summary>
	public string Link { get; set; }
}