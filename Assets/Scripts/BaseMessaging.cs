/// <summary>
/// Base class for messaging groups.
/// </summary>
public class BaseMessaging
{
    // Reference to the server communication.
    protected ServerCommunication client;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:BaseMessaging"/> class.
    /// </summary>
    /// <param name="client">Client.</param>
    public BaseMessaging(ServerCommunication client)
    {
        this.client = client;
    }
}

/// <summary>
/// Echo message model.
/// </summary>
[System.Serializable]
public class EchoMessageModel
{
    public string text;
}
/// <summary>
/// Message model.
/// </summary>
[System.Serializable]
public class MessageModel
{
    public string method;
    public string message;
}

