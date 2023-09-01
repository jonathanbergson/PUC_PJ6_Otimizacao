using UnityEngine;

public class Cube : MonoBehaviour
{
    public Material[] materials;

    void Start()
    {
        int r = Random.Range(0, materials.Length);
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material = materials[r];
    }
}
