using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NicknameInput : MonoBehaviour
{
    public InputField nameInputField; // 닉네임 입력 필드

    public void OnSubmitName()
    {
        if (!string.IsNullOrEmpty(nameInputField.text))
        {
            // 입력한 닉네임을 저장 (PlayerPrefs는 간단한 저장 방법)
            PlayerPrefs.SetString("PlayerName", nameInputField.text);

            // 게임 씬으로 이동
            SceneManager.LoadScene("GameScene");
        }
    }
}
