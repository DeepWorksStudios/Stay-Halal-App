namespace Stay_Halal.MVVM.Model;

public class MessageModel
{
    #region Private Data
    private readonly string title;
    private readonly string message;
    private readonly string image_light;
    private readonly string image_dark;
    private readonly bool buttonEnabled;
    private readonly string buttonText;
    private readonly string targetRoute; 
    private  bool unlook;
    private string customeMessage=string.Empty;
    #endregion

    #region Public Data
    public string Title { get { return title; } }
    public string Message { get { return message; } }
    public string CustomeMessage { get { return customeMessage; } }
    public string Image_Light { get { return image_light; } }
    public string Image_Dark { get { return image_dark; } }

    public bool ButtonEnabled { get { return buttonEnabled; } }
    public bool Unlook { get { return unlook; } }
    public string ButtonText { get { return buttonText; } }
    public string TargetRoute { get { return targetRoute; } }
    #endregion

    #region Constructor
    public MessageModel(string _title, string _message, string _image_light, string _image_dark, bool _buttonEnabled=false,string _buttonText="", string _targetRoute="")
    {
        title = _title;
        message = _message;
        image_dark = _image_dark;
        image_light = _image_light;
        buttonEnabled = _buttonEnabled;
        buttonText = _buttonText;
        targetRoute = _targetRoute;
      
    }
    #endregion

    #region Public Call
    public void SetAllowUnlock(bool _unlook)
    {
        unlook = _unlook;
    }
    public void SetCustomeMessage(string _msg)
    {
        customeMessage = _msg;
    }
    #endregion
}

