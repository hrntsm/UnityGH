using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class GHMesh : MonoBehaviour
{
	// 頂点配列
	private Vector3[] vertices;
	// 三角形の順番配列
	private int[] triangles;
	// メッシュ
	private Mesh mesh;
	// メッシュ表示コンポーネント
	private MeshRenderer meshRenderer;
	// メッシュに設定するマテリアル
	public Material material;

    void Start () {
		gameObject.AddComponent<MeshFilter> ();
		meshRenderer = gameObject.AddComponent<MeshRenderer> ();
		mesh = GetComponent<MeshFilter> ().mesh;
		meshRenderer.material = material;
    }

    void Update () {
			// GHの頂点座標の取得
			string[] arr =  UDPMesh.textRep.Split(',');
			float[] FloatArray = new float[arr.Length+1];
			for (int i = 0; i < arr.Length; i++){
				FloatArray[i] = float.Parse(arr[i]);
			};
			// Unityでの頂点座標の生成
			Vector3[] vertices = new Vector3[arr.Length/3];
			for (int j = 0; j < arr.Length/3.0; j++){
				vertices[j] = new Vector3 (FloatArray[3*j], FloatArray[3*j+2],  FloatArray[3*j+1] );
			};
			// Unityでの三角形メッシュの生成
			int[] triangles = new int[arr.Length/3];
			for (int i = 0; i < arr.Length/3; i++){
				triangles[i] = i;
			};

			CreateMesh (mesh, vertices, triangles);
    }
	
	void CreateMesh(Mesh mesh, Vector3[] vertices, int[] triangles) {
		// 最初にメッシュをクリアする
		mesh.Clear();
		// 頂点の設定
		mesh.vertices = vertices;
		// 三角形メッシュの設定
		mesh.triangles = triangles;
		// Boundsの再計算
		mesh.RecalculateBounds ();
		// NormalMapの再計算
		mesh.RecalculateNormals ();
	}
}