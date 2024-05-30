using System.IO;
using UnityEngine;

public class MachineDataManager : MonoBehaviour
{
    public string machineDataFilePath = "machine-data.json";

    private MachineData machineData;

    void Start()
    {
        LoadMachineDataFromJSON();
        UpdateMachineInScene();
    }

    private void LoadMachineDataFromJSON()
    {
        string jsonFilePath = Path.Combine(Application.streamingAssetsPath, machineDataFilePath);
        string jsonData = File.ReadAllText(jsonFilePath);
        machineData = JsonUtility.FromJson<MachineData>(jsonData);
    }

    private void UpdateMachineInScene()
    {
        Debug.Log($"��� ������: {machineData.machineName}");
        Debug.Log($"��� ������: {machineData.machineType}");
        Debug.Log($"������������ ��������: {machineData.maxSpeed}");
        Debug.Log($"������� �������������: {machineData.hasAutomation}");
    }
}

[System.Serializable]
public class MachineData
{
    public string machineName;
    public string machineType;
    public float maxSpeed;
    public bool hasAutomation;
}

