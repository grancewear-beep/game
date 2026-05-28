using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CustomMenuItem : MonoBehaviour
{
    [MenuItem("MuBaGames/Open Game Scene", priority = 0)]
    static void LoadGameScene()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/_Game/Scenes/Game.unity");
        }
    }

    [MenuItem("MuBaGames/Customize/Credit Panel")]
    static void OpenCreditData()
    {
        string path = "Assets/_Game/SO/Credit Data.asset";
        CreditDataSO data = (CreditDataSO)AssetDatabase.LoadAssetAtPath(path, typeof(CreditDataSO));
        Selection.activeObject = data;
    }
}
