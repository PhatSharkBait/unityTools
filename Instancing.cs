using UnityEngine;
using unityTools;

[CreateAssetMenu]
public class Instancing : ScriptableObject {
    public GameObject prefab;
    private int _listNum;
    
    public void CreateInstance() {
        Instantiate(prefab);
    }
    public void CreateInstance(Vector3DataSO obj) {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }
    public void CreateInstanceFromList(Vector3DataListSO obj) {
        foreach (Vector3DataSO vector3Data in obj.vector3DataSos) {
            Instantiate(prefab, vector3Data.value, Quaternion.identity);
        }
    }
    public void CreateInstanceCountFromList(Vector3DataListSO obj) {
        Instantiate(prefab, obj.vector3DataSos[_listNum].value, Quaternion.identity);
        _listNum++;
        if (_listNum >= obj.vector3DataSos.Count) {
            _listNum = 0;
        }
    }
    public void CreateInstanceRandomFromList(Vector3DataListSO obj) {
        Instantiate(prefab, obj.vector3DataSos[Random.Range(0, obj.vector3DataSos.Count)].value, Quaternion.identity);
    }
}
