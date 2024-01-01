using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 注意：本节课所有知识点均为 Unity和Android交互——交互项目创建中内容
        //由于我们要在Android平台集成第三方的SDK
        //因此自然联想到，我们需要Unity和Android之间进行交互
        //需要在Unity端调用Android端开发好的东西
        //所以我们需要创建交互项目
        //之后就在Android交互项目中引入第三方SDK进行逻辑开发
        #endregion

        #region 知识点一 创建Unity和Android Studio项目
        //1.创建Unity项目后，切换到Android平台，设置包名和Android版本
        //2.创建Android Studio
        //  选择 Phone and Tablet，创建一个Empty Activity项目
        //  注意：
        //  1.包名和Minimum SDK版本要和Unity项目一致 若没有相同SDK版本，请再AndroidStudio中下载
        //  2.创建完成后，等待加载结束后，删除工程中两个Test项目以及res下的无用资源   
        #endregion

        #region 知识点二 配置build.gradle文件
        //1.在Android Studio中Project页签中切换为Project
        //2.展开工程名下app页签，打开build.gradle文件
        //  重要修改：
        //      1.id 'com.android.application'  修改为 id 'com.android.library'
        //      2.删除defaultConfig中的 applicationId 项
        //      3.点击右上角同步按钮 Sync Now
        #endregion

        #region 知识点三 导入 classes.jar 包
        //路径：Unity安装目录\Data\PlaybackEngines\AndroidPlayer\Variations\mono(il2cpp)\Release\Classes中
        //1.将包拷贝到AndroidStudio中的app\libs下
        //2.导入后 选择包 右键点击 Add As Library
        #endregion

        #region 知识点四 导入 UnityPlayerActivity 脚本
        // 路径：Unity安装目录/Data/PlaybackEngines/AndroidPlayer/Source/....
        //      将路径下的文件夹拷贝到AndroidStudio中的 app/src/main/java中
        #endregion

        #region 知识点五 修改MainActivity脚本
        //我们需要修改Android Studio中的MainActivity脚本
        //1.改为继承UnityPlayerActivity
        //2.注释onCreate函数中的setContentView代码
        #endregion

        #region 知识点六 修改AndroidManifest.xml配置文件
        //1.删除application中的无用内容
        //2.在activity中加入一句 <meta-data android:name="unityplayer.UnityActivity" android:value="true"/>
        #endregion

        #region 知识点七 生成Untiy用的aar包
        //选中MainActivity脚本
        //选择 工具栏——>Build——>Make Moudle .....

        //如果打包aar包时 出现了 下载相关内容的 字样  那么就需要多等待一会儿，下载完成过后 一般就能够构建成功
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
