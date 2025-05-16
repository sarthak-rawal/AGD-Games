using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Signup : MonoBehaviour
{
    public Text logtext;
public Text signtext;

 public  void Login()
    {
        logtext.text = "Login Successfull";
    }
    public void Su()
    {
        signtext.text = "Sign Up Successfull";
    }
}
