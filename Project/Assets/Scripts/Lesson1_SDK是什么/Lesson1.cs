using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 什么是SDK？
        //SDK是Software Development Kit（软件开发包）的简写
        //一般都是一些软件工程师为特定的软件包、软件框架、硬件平台、操作系统等建立应用软件时的开发工具的集合

        //说人话：
        //SDK就是程序员针对某些操作系统（比如Windows、Android、IOS）写好的代码，这些代码用于完成某些功能逻辑
        //操作系统的不同，那么对应的开发语言也就不同，比如Android平台可能是基于Java写的，IOS平台可能是基于Objective-C写的等等
        #endregion

        #region 知识点二 为什么要接入SDK？
        //很多游戏或软件的第三方功能都是第三方平台提供的
        //我们想要在产品中使用这些功能，就需要接入这些第三方的SDK
        //比如游戏内的 支付宝支付功能、微信支付功能、各平台登录功能、数据统计功能等等

        //举例：
        //我们制作的游戏找到了代理商 为腾讯，腾讯要求能够支持QQ号登录、微信登录
        //这时我们就需要接入 腾讯提供的 平台登录SDK，让我们的游戏能够具备这样的功能
        #endregion

        #region 知识点三 应该如何学习接入SDK
        //1.需要掌握Unity和Android交互相关知识点（重点：相互调用）
        //2.需要详细阅读第三方SDK提供的开发文档（重点：相关API调用、应用配置、权限配置等）
        //3.集成SDK后，一般情况下，为了发布顺利，建议最后使用Android Studio进行打包（重点：避免相关依赖项不能正确加载）
        #endregion

        #region 总结
        //通过以上知识点的讲解
        //大家对SDK有一个基本的认识了
        //应该也能意识到，SDK接入这个工作内容，一般都会放在项目的中后期来完成
        //一般都是整体项目基本完成，最终要上线测试前进行接入
        //这部分知识点也是相对较为重要的
        //可以提升我们的就业竞争力
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
