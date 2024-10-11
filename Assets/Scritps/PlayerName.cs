using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NicknameInput : MonoBehaviour
{
    public InputField nameInputField; // �г��� �Է� �ʵ�

    public void OnSubmitName()
    {
        if (!string.IsNullOrEmpty(nameInputField.text))
        {
            // �Է��� �г����� ���� (PlayerPrefs�� ������ ���� ���)
            PlayerPrefs.SetString("PlayerName", nameInputField.text);

            // ���� ������ �̵�
            SceneManager.LoadScene("GameScene");
        }
    }
}
