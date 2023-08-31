using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Demo : MonoBehaviour {
    public string materialUrl = "https://drive.google.com/uc?export=download&id=1M0b_VuidZWfbLIueh3ubC8f_jGNEc53J";

    void Start() {
        StartCoroutine(GetMaterial(materialUrl));
    }

    IEnumerator GetMaterial(string url) {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError) {
            Debug.LogError(request.error);
        } else {
            byte[] data = request.downloadHandler.data;
            Material material = new Material(Shader.Find("Skybox/Cubemap"));
            material.SetTexture("_Tex", LoadTextureFromData(data));

            Renderer renderer = GetComponent<Renderer>();
            if (renderer == null) {
                Debug.LogError("Failed to get Renderer component from game object.");
            } else {
                renderer.material = material;
            }
        }

        request.Dispose();
    }

    Texture2D LoadTextureFromData(byte[] data) {
        Texture2D texture = new Texture2D(2, 2, TextureFormat.RGB24, false);
        texture.LoadImage(data);
        texture.wrapMode = TextureWrapMode.Clamp;
        texture.filterMode = FilterMode.Trilinear;
        return texture;
    }
}
