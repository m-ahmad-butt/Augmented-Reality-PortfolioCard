using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Links : MonoBehaviour
{

    public void openGithub()
    {
        Application.OpenURL("https://github.com/muhammadahmad0313");
    }

    public void openLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/muhammad-ahmad-butt-0324b036a/");
    }

    public void SendMail()
    {
        Application.OpenURL("mailto:l233059@lhr.nu.edu.pk");
    }

    public void openInstagram()
    {
        Debug.Log("INSTA");
        Application.OpenURL("https://www.instagram.com/introvertahmad/");
    }
}
