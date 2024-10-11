using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public GameObject selectUIPanel; // Select UI 패널 (캐릭터 선택창)
    public Image playerUIImage; // playerUI에 표시될 이미지
    public Sprite character1Sprite; // 첫 번째 캐릭터 이미지
    public Sprite character2Sprite; // 두 번째 캐릭터 이미지
    public string selectedCharacter = ""; // 선택된 캐릭터 저장

    void Start()
    {
        // 처음에 아무것도 선택되지 않았다면 기본값을 Character1으로 설정
        if (string.IsNullOrEmpty(selectedCharacter))
        {
            SetDefaultCharacter();
        }

        // 선택창은 처음에 비활성화 상태
        selectUIPanel.SetActive(false);
    }

    // 기본 캐릭터 설정 (Character1)
    void SetDefaultCharacter()
    {
        selectedCharacter = "Character1";
        PlayerPrefs.SetString("SelectedCharacter", selectedCharacter); // 기본 캐릭터를 PlayerPrefs에 저장
        playerUIImage.sprite = character1Sprite; // 기본 캐릭터 이미지 설정
        Debug.Log("Default Character 1 Selected");
    }

    // 첫 번째 캐릭터 선택
    public void SelectCharacter1()
    {
        selectedCharacter = "Character1";
        Debug.Log("Character 1 Selected");
        PlayerPrefs.SetString("SelectedCharacter", selectedCharacter); // 선택된 캐릭터를 PlayerPrefs에 저장
        playerUIImage.sprite = character1Sprite; // playerUI 이미지 변경
        HideSelectionUI(); // 선택 후 UI 숨기기
    }

    // 두 번째 캐릭터 선택
    public void SelectCharacter2()
    {
        selectedCharacter = "Character2";
        Debug.Log("Character 2 Selected");
        PlayerPrefs.SetString("SelectedCharacter", selectedCharacter); // 선택된 캐릭터를 PlayerPrefs에 저장
        playerUIImage.sprite = character2Sprite; // playerUI 이미지 변경
        HideSelectionUI(); // 선택 후 UI 숨기기
    }

    // 선택창을 활성화하는 함수 (playerUI 버튼 클릭 시 호출)
    public void ShowSelectionUI()
    {
        selectUIPanel.SetActive(true); // 선택창 활성화
    }

    // 선택창을 비활성화하는 함수
    void HideSelectionUI()
    {
        selectUIPanel.SetActive(false); // 선택창 비활성화
    }

    public string GetSelectedCharacter()
    {
        return selectedCharacter;
    }
}