using System.Diagnostics;
using UnityEngine;

public class TestStartServer : MonoBehaviour
{
    private string exePath = Application.streamingAssetsPath + "/Server/dist/StartServer.exe";
    private Process launchedProcess;

    void Start()
    {
        LaunchExe();
    }

    private bool LaunchExe()
    {
        try
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
            startInfo.UseShellExecute = true; // ウィンドウを表示させる
            launchedProcess = Process.Start(startInfo);
            return true;
        }
        catch (System.Exception ex)
        {
            UnityEngine.Debug.LogError("EXE起動に失敗: " + ex.Message);
            return false;
        }
    }

    public bool StopServer()
    {
        try
        {
            if (launchedProcess == null)
            {
                return false;
            }

            int processId = launchedProcess.Id;
            Process.Start("taskkill", "/F /T /PID " + processId);

            if (launchedProcess.HasExited)
            {
                launchedProcess = null;
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (System.Exception ex)
        {
            UnityEngine.Debug.LogError("EXE停止に失敗: " + ex.Message);
            return false;
        }
    }

    public bool ResetServer()
    {
        try
        {
            StopServer();
            LaunchExe();
            return true;
        }
        catch (System.Exception ex)
        {
            UnityEngine.Debug.LogError("EXEリセットに失敗: " + ex.Message);
            return false;
        }
    }

    private void OnDisable()
    {
        StopServer();
    }
}
