using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public GameObject LoginView;
    public InputField inputField_ID;
    public InputField inputField_PW;
    public Button Button_Login;

    private string user = "User";
    private string password = "1234";

    public void LoginButtonClick()
    {
        if(inputField_ID.text == user && inputField_PW.text == password)
        {
            SceneManager.LoadScene("Fac1Map");
        }
    }
}
