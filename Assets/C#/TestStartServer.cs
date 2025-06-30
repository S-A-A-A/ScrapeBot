using System.Diagnostics;
using UnityEngine;

public class TestStartServer : MonoBehaviour
{
    // 起動したいexeファイルのパス（絶対パス or 相対パス）
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
            startInfo.UseShellExecute = true; // ウィンドウを表示させる
            Process.Start(startInfo);
        }
        catch (System.Exception ex)
        {
            UnityEngine.Debug.LogError("EXE起動に失敗: " + ex.Message);
        }
    }
}
