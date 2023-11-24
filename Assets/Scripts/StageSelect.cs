using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectionPopup : MonoBehaviour
{
    public GameObject popupPanel;
    public Button[] stageButtons;

    void Start()
    {
        // 팝업 초기화
        ClosePopup();

        // 스테이지 버튼에 클릭 이벤트 추가
        for (int i = 0; i < stageButtons.Length; i++)
        {
            int stageIndex = i; // 클로저 문제를 피하기 위해 변수를 별도로 만들어 사용

            stageButtons[i].onClick.AddListener(() =>
            {
                OnStageButtonClick(stageIndex);
            });
        }
    }

    void Update()
    {
        // 예를 들어, 특정 조건(버튼을 누르거나 특정 이벤트 발생 등)에 따라 팝업을 열 수 있습니다.
        if (Input.GetKeyDown(KeyCode.P))
        {
            OpenPopup();
        }
    }

    // 스테이지 버튼이 클릭되었을 때 호출되는 함수
    void OnStageButtonClick(int stageIndex)
    {

        // 여기에서 선택한 스테이지에 대한 게임 로직을 호출하면 됩니다.
        // 예: GameManager.StartGame(stageIndex);

        // 팝업을 닫습니다.
        ClosePopup();
    }

    // 팝업을 열기
    void OpenPopup()
    {
        popupPanel.SetActive(true);
    }

    // 팝업을 닫기
    void ClosePopup()
    {
        popupPanel.SetActive(false);
    }
}
