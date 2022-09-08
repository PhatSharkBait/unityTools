using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Vector3ListSO : ScriptableObject {
    public List<Vector3> vector3s;

    public void ClearList(){
        vector3s.Clear();
    }

    public void AddVector3ToList(Vector3 newVector3) {
        vector3s.Add(newVector3);
    }
}
