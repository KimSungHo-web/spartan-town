using UnityEngine;
using UnityEngine.UI;

public class NameChange : MonoBehaviour
{
    public InputField nameInputField; // 이름을 입력할 필드
    public GameObject nameUIPanel; // 이름 변경 UI 패널
    public Text characterNameText; // 캐릭터 머리 위에 표시될 이름

    void Start()
    {
        // PlayerPrefs에서 저장된 이름을 불러와서 캐릭터 머리 위에 표시
        string savedName = PlayerPrefs.GetString("PlayerName", "Player");
        characterNameText.text = savedName;

        // InputField에 기존 저장된 이름을 미리 표시
        nameInputField.text = savedName;
    }

    // 이름 변경
    public void ChangeName()
    {
        string newName = nameInputField.text; // 입력된 이름
        if (!string.IsNullOrEmpty(newName))
        {
            characterNameText.text = newName; // 캐릭터 위에 이름 변경
            PlayerPrefs.SetString("PlayerName", newName); // 새로운 이름을 PlayerPrefs에 저장

            nameUIPanel.SetActive(false); // 이름 변경 후 UI 닫기
        }
        else
        {
            Debug.LogWarning("이름이 입력되지 않았습니다.");
        }
    }

    // 이름 변경 UI를 보여주는 함수
    public void ShowNameUI()
    {
        nameUIPanel.SetActive(true); // 이름 변경 UI 활성화
    }

    // 이름 변경 UI를 숨기는 함수
    public void HideNameUI()
    {
        nameUIPanel.SetActive(false); // 이름 변경 UI 비활성화
    }
}
