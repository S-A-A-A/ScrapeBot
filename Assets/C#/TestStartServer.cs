using System.Diagnostics;
using UnityEngine;

public class TestStartServer : MonoBehaviour
{
    // �N��������exe�t�@�C���̃p�X�i��΃p�X or ���΃p�X�j
    public string exePath = Application.streamingAssetsPath + @"\..\Python\dist\StartServer.exe";

    void Start()
    {
        LaunchExe();
    }

    void LaunchExe()
    {
        try
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
            startInfo.UseShellExecute = true; // �E�B���h�E��\��������
            Process.Start(startInfo);
        }
        catch (System.Exception ex)
        {
            UnityEngine.Debug.LogError("EXE�N���Ɏ��s: " + ex.Message);
        }
    }
}
