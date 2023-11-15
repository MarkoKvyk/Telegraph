using System;

namespace Telegraph.Exceptions;

/// <summary>
///   Represents errors that occur during application execution.
/// </summary>
[Serializable]
public class TelegraphException : Exception
{
	/// <inheritdoc />
	public TelegraphException()
	{
	}

	/// <summary>
	///  Initializes a new instance of the <see cref="TelegraphException" /> class with a specified error message.
	/// </summary>
	/// <param name="message"> The message that describes the error. </param>
	public TelegraphException(string message) : base(message)
	{
	}

	/// <summary>
	///  Initializes a new instance of the <see cref="TelegraphException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message"> The error message that explains the reason for the exception. </param>
	/// <param name="inner"> The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception. </param>
	public TelegraphException(string message, Exception inner) : base(message, inner)
	{
	}

	/// <summary>
	///  Initializes a new instance of the <see cref="TelegraphException" /> class with serialized data.
	/// </summary>
	/// <param name="info"> The <see cref="System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
	/// <param name="context"> The <see cref="System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
	protected TelegraphException(
		System.Runtime.Serialization.SerializationInfo info,
		System.Runtime.Serialization.StreamingContext context) : base(info, context)
	{
	}
}