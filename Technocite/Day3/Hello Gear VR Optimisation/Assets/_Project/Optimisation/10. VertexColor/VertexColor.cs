using UnityEngine;
using System.Collections;

public class VertexColor : MonoBehaviour {

	public Color color;


	void Start () {

        Mesh mesh = Instantiate<Mesh>(GetComponent<MeshFilter>().sharedMesh);
        Color[] colors = new Color[mesh.vertices.Length];
        for (int i = 0; i < colors.Length; i++)
            colors[i] = color;
        mesh.colors = colors;
        GetComponent<MeshFilter>().sharedMesh = mesh;
	}

}
