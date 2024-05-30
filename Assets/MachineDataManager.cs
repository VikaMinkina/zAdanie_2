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
        Debug.Log($"Имя станка: {machineData.machineName}");
        Debug.Log($"Тип станка: {machineData.machineType}");
        Debug.Log($"Максимальная скорость: {machineData.maxSpeed}");
        Debug.Log($"Наличие автоматизации: {machineData.hasAutomation}");
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

