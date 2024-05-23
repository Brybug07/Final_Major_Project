using UnityEngine;

public static class DataSaver
{
    public static void SetData(string keyName, int value)
    {
        PlayerPrefs.SetInt(keyName, value);
    }

    public static void SetData(string keyName, float value)
    {
        PlayerPrefs.SetFloat(keyName, value);
    }

    public static float GetFloatData(string keyName)
    {
        return PlayerPrefs.GetFloat(keyName);
    }

    public static int GetIntData(string keyName)
    {
        return PlayerPrefs.GetInt(keyName);
    }
}