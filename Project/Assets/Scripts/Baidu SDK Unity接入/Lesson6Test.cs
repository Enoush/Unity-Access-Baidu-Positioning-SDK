using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson6Test : MonoBehaviour
{
    public Text txtPos;
    public Button btnGetPos;
    
    void Awake()
    {
        btnGetPos.onClick.AddListener(()=>{
            using(AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer")){
                using(AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity")){
                    androidJavaObject.Call("GetAddress");
                }
            }
        });
    }
    public void UpdatePos(string posString)
    {
        if(posString.Contains("null")){
            txtPos.text = "-------��λ��--------";
        }else{
            txtPos.text = "��ǰλ��:"+posString;
        }
    }
}
