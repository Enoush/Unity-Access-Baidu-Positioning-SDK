using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ע�⣺���ڿ�����֪ʶ���Ϊ Unity��Android��������������Ŀ����������
        //��������Ҫ��Androidƽ̨���ɵ�������SDK
        //�����Ȼ���뵽��������ҪUnity��Android֮����н���
        //��Ҫ��Unity�˵���Android�˿����õĶ���
        //����������Ҫ����������Ŀ
        //֮�����Android������Ŀ�����������SDK�����߼�����
        #endregion

        #region ֪ʶ��һ ����Unity��Android Studio��Ŀ
        //1.����Unity��Ŀ���л���Androidƽ̨�����ð�����Android�汾
        //2.����Android Studio
        //  ѡ�� Phone and Tablet������һ��Empty Activity��Ŀ
        //  ע�⣺
        //  1.������Minimum SDK�汾Ҫ��Unity��Ŀһ�� ��û����ͬSDK�汾������AndroidStudio������
        //  2.������ɺ󣬵ȴ����ؽ�����ɾ������������Test��Ŀ�Լ�res�µ�������Դ   
        #endregion

        #region ֪ʶ��� ����build.gradle�ļ�
        //1.��Android Studio��Projectҳǩ���л�ΪProject
        //2.չ����������appҳǩ����build.gradle�ļ�
        //  ��Ҫ�޸ģ�
        //      1.id 'com.android.application'  �޸�Ϊ id 'com.android.library'
        //      2.ɾ��defaultConfig�е� applicationId ��
        //      3.������Ͻ�ͬ����ť Sync Now
        #endregion

        #region ֪ʶ���� ���� classes.jar ��
        //·����Unity��װĿ¼\Data\PlaybackEngines\AndroidPlayer\Variations\mono(il2cpp)\Release\Classes��
        //1.����������AndroidStudio�е�app\libs��
        //2.����� ѡ��� �Ҽ���� Add As Library
        #endregion

        #region ֪ʶ���� ���� UnityPlayerActivity �ű�
        // ·����Unity��װĿ¼/Data/PlaybackEngines/AndroidPlayer/Source/....
        //      ��·���µ��ļ��п�����AndroidStudio�е� app/src/main/java��
        #endregion

        #region ֪ʶ���� �޸�MainActivity�ű�
        //������Ҫ�޸�Android Studio�е�MainActivity�ű�
        //1.��Ϊ�̳�UnityPlayerActivity
        //2.ע��onCreate�����е�setContentView����
        #endregion

        #region ֪ʶ���� �޸�AndroidManifest.xml�����ļ�
        //1.ɾ��application�е���������
        //2.��activity�м���һ�� <meta-data android:name="unityplayer.UnityActivity" android:value="true"/>
        #endregion

        #region ֪ʶ���� ����Untiy�õ�aar��
        //ѡ��MainActivity�ű�
        //ѡ�� ����������>Build����>Make Moudle .....

        //������aar��ʱ ������ ����������ݵ� ����  ��ô����Ҫ��ȴ�һ�����������ɹ��� һ����ܹ������ɹ�
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
