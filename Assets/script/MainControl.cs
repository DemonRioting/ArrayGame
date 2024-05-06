using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControl : MonoBehaviour
{
    [SerializeField] GameObject StartStage;
    public Button startButton;
    [SerializeField] List<GameObject> Intro;
    [SerializeField] List<GameObject> Story_1;
    [SerializeField] List<GameObject> Story_2;
    [SerializeField] List<GameObject> Story_3;
    [SerializeField] List<GameObject> Story_4;
    [SerializeField] List<GameObject> Story_5;
    [SerializeField] List<GameObject> Tutorial_1;
    [SerializeField] List<GameObject> Tutorial_2;
    [SerializeField] List<GameObject> Tutorial_3;
    [SerializeField] List<GameObject> Tutorial_4;
    [SerializeField] List<GameObject> Tutorial_5;
    [SerializeField] List<GameObject> Quiz_1;
    [SerializeField] List<GameObject> Quiz_2;
    [SerializeField] List<GameObject> Quiz_3;
    [SerializeField] List<GameObject> Quiz_4;
    [SerializeField] List<GameObject> Quiz_5;
    [SerializeField] List<GameObject> Score_1;
    [SerializeField] List<GameObject> Score_2;
    [SerializeField] List<GameObject> Score_3;
    [SerializeField] List<GameObject> Score_4;
    [SerializeField] List<GameObject> Score_5;
    public Button BackButton;
    public Button NextButton;
    public Button SkipButton;
    [SerializeField] List<Button> Stage1Quiz1Button;
    [SerializeField] List<Dropdown> Stage1Quiz2Dropdown;
    [SerializeField] List<Button> Stage1Quiz3Button;
    [SerializeField] List<Button> Stage2Quiz1Button;
    [SerializeField] List<Dropdown> Stage2Quiz2Dropdown;
    [SerializeField] List<Button> Stage2Quiz3Button;
    [SerializeField] List<GameObject> BlankBlock;
    [SerializeField] List<GameObject> SelectBlock;
    [SerializeField] Text Stage2Quiz3MonsterHP;
    [SerializeField] Text Stage2Quiz3Select;
    [SerializeField] List<Dropdown> Stage3Quiz1Dropdown;
    [SerializeField] List<Dropdown> Stage4Quiz1Dropdown;
    [SerializeField] List<Button> Stage4Quiz2Button;
    [SerializeField] List<Button> Stage5Quiz1Button;
    [SerializeField] List<Button> Stage5Quiz2Button;
    [SerializeField] List<Button> Stage5Quiz3Button;
    [SerializeField] List<Button> StageButton;
    [SerializeField] List<GameObject> Background;

    bool[] StageStatus = {true, false, false, false, false};
    int[] StageScore = {0, 0, 0, 0, 0};
    int monsterHP;
    // Start is called before the first frame update
    void Start()
    {
        // int[] StageStatus = {1, 0, 0, 0, 0};
        // int[] StageScore = {0, 0, 0, 0, 0};

        // Debug.Log(StageStatus[0]);

        Stage1Quiz2Dropdown[0].onValueChanged.AddListener(delegate {
            Stage1Quiz2CheckDropdown();
        });
        Stage1Quiz2Dropdown[1].onValueChanged.AddListener(delegate {
            Stage1Quiz2CheckDropdown();
        });
        Stage1Quiz2Dropdown[2].onValueChanged.AddListener(delegate {
            Stage1Quiz2CheckDropdown();
        });

        Stage2Quiz2Dropdown[0].onValueChanged.AddListener(delegate {
            Stage2Quiz2CheckDropdown();
        });
        Stage2Quiz2Dropdown[1].onValueChanged.AddListener(delegate {
            Stage2Quiz2CheckDropdown();
        });
        Stage2Quiz2Dropdown[2].onValueChanged.AddListener(delegate {
            Stage2Quiz2CheckDropdown();
        });

        Stage3Quiz1Dropdown[0].onValueChanged.AddListener(delegate {
            Stage3Quiz1CheckDropdown();
        });
        Stage3Quiz1Dropdown[1].onValueChanged.AddListener(delegate {
            Stage3Quiz1CheckDropdown();
        });
        Stage3Quiz1Dropdown[2].onValueChanged.AddListener(delegate {
            Stage3Quiz1CheckDropdown();
        });

        Stage4Quiz1Dropdown[0].onValueChanged.AddListener(delegate {
            Stage4Quiz1CheckDropdown();
        });
        Stage4Quiz1Dropdown[1].onValueChanged.AddListener(delegate {
            Stage4Quiz1CheckDropdown();
        });
        Stage4Quiz1Dropdown[2].onValueChanged.AddListener(delegate {
            Stage4Quiz1CheckDropdown();
        });

        StartCoroutine(WaitingToStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StageScore_1(int n) {
        if(n <= 0) {
            Score_1[0].SetActive(true);
            Score_1[1].SetActive(true);
            Score_1[2].SetActive(true);
            Score_1[3].SetActive(false);
            Score_1[4].SetActive(false);
            Score_1[5].SetActive(false);
        } else if(n == 1) {
            Score_1[0].SetActive(false);
            Score_1[1].SetActive(true);
            Score_1[2].SetActive(true);
            Score_1[3].SetActive(true);
            Score_1[4].SetActive(false);
            Score_1[5].SetActive(false);
        } else if(n == 2) {
            Score_1[0].SetActive(false);
            Score_1[1].SetActive(false);
            Score_1[2].SetActive(true);
            Score_1[3].SetActive(true);
            Score_1[4].SetActive(true);
            Score_1[5].SetActive(false);
        } else if(n == 3) {
            Score_1[0].SetActive(false);
            Score_1[1].SetActive(false);
            Score_1[2].SetActive(false);
            Score_1[3].SetActive(true);
            Score_1[4].SetActive(true);
            Score_1[5].SetActive(true);
        }
    }

    void StageScore_2(int n) {
        if(n <= 0) {
            Score_2[0].SetActive(true);
            Score_2[1].SetActive(true);
            Score_2[2].SetActive(true);
            Score_2[3].SetActive(false);
            Score_2[4].SetActive(false);
            Score_2[5].SetActive(false);
        } else if(n == 1) {
            Score_2[0].SetActive(false);
            Score_2[1].SetActive(true);
            Score_2[2].SetActive(true);
            Score_2[3].SetActive(true);
            Score_2[4].SetActive(false);
            Score_2[5].SetActive(false);
        } else if(n == 2) {
            Score_2[0].SetActive(false);
            Score_2[1].SetActive(false);
            Score_2[2].SetActive(true);
            Score_2[3].SetActive(true);
            Score_2[4].SetActive(true);
            Score_2[5].SetActive(false);
        } else if(n == 3) {
            Score_2[0].SetActive(false);
            Score_2[1].SetActive(false);
            Score_2[2].SetActive(false);
            Score_2[3].SetActive(true);
            Score_2[4].SetActive(true);
            Score_2[5].SetActive(true);
        }
    }

    void StageScore_3(int n) {
        if(n <= 0) {
            Score_3[0].SetActive(true);
            Score_3[1].SetActive(true);
            Score_3[2].SetActive(true);
            Score_3[3].SetActive(false);
            Score_3[4].SetActive(false);
            Score_3[5].SetActive(false);
        } else if(n == 1) {
            Score_3[0].SetActive(false);
            Score_3[1].SetActive(true);
            Score_3[2].SetActive(true);
            Score_3[3].SetActive(true);
            Score_3[4].SetActive(false);
            Score_3[5].SetActive(false);
        } else if(n == 2) {
            Score_3[0].SetActive(false);
            Score_3[1].SetActive(false);
            Score_3[2].SetActive(true);
            Score_3[3].SetActive(true);
            Score_3[4].SetActive(true);
            Score_3[5].SetActive(false);
        } else if(n == 3) {
            Score_3[0].SetActive(false);
            Score_3[1].SetActive(false);
            Score_3[2].SetActive(false);
            Score_3[3].SetActive(true);
            Score_3[4].SetActive(true);
            Score_3[5].SetActive(true);
        }
    }

    void StageScore_4(int n) {
        if(n <= 0) {
            Score_4[0].SetActive(true);
            Score_4[1].SetActive(true);
            Score_4[2].SetActive(true);
            Score_4[3].SetActive(false);
            Score_4[4].SetActive(false);
            Score_4[5].SetActive(false);
        } else if(n == 1) {
            Score_4[0].SetActive(false);
            Score_4[1].SetActive(true);
            Score_4[2].SetActive(true);
            Score_4[3].SetActive(true);
            Score_4[4].SetActive(false);
            Score_4[5].SetActive(false);
        } else if(n == 2) {
            Score_4[0].SetActive(false);
            Score_4[1].SetActive(false);
            Score_4[2].SetActive(true);
            Score_4[3].SetActive(true);
            Score_4[4].SetActive(true);
            Score_4[5].SetActive(false);
        } else if(n == 3) {
            Score_4[0].SetActive(false);
            Score_4[1].SetActive(false);
            Score_4[2].SetActive(false);
            Score_4[3].SetActive(true);
            Score_4[4].SetActive(true);
            Score_4[5].SetActive(true);
        }
    }

    void StageScore_5(int n) {
        if(n <= 0) {
            Score_5[0].SetActive(true);
            Score_5[1].SetActive(true);
            Score_5[2].SetActive(true);
            Score_5[3].SetActive(false);
            Score_5[4].SetActive(false);
            Score_5[5].SetActive(false);
        } else if(n == 1) {
            Score_5[0].SetActive(false);
            Score_5[1].SetActive(true);
            Score_5[2].SetActive(true);
            Score_5[3].SetActive(true);
            Score_5[4].SetActive(false);
            Score_5[5].SetActive(false);
        } else if(n == 2) {
            Score_5[0].SetActive(false);
            Score_5[1].SetActive(false);
            Score_5[2].SetActive(true);
            Score_5[3].SetActive(true);
            Score_5[4].SetActive(true);
            Score_5[5].SetActive(false);
        } else if(n == 3) {
            Score_5[0].SetActive(false);
            Score_5[1].SetActive(false);
            Score_5[2].SetActive(false);
            Score_5[3].SetActive(true);
            Score_5[4].SetActive(true);
            Score_5[5].SetActive(true);
        }
    }

    void CloseAllBackground() {
        int i;
        for(i = 0;i < 9;i++) {
            Background[i].SetActive(false);
        }
    }
    
    void Stage1Quiz2CheckDropdown() {
        Quiz1_2();
    }

    void Stage1Quiz2ResetDropdown() {
        Stage1Quiz2Dropdown[0].value = 0;
        Stage1Quiz2Dropdown[1].value = 0;
        Stage1Quiz2Dropdown[2].value = 0;
    }

    void Stage2Quiz2CheckDropdown() {
        Quiz2_2();
    }

    void Stage2Quiz2ResetDropdown() {
        Stage1Quiz2Dropdown[0].value = 0;
        Stage1Quiz2Dropdown[1].value = 0;
        Stage1Quiz2Dropdown[2].value = 0;
    }

    void Stage3Quiz1CheckDropdown() {
        Quiz3_1();
    }

    void Stage3Quiz1ResetDropdown() {
        Stage3Quiz1Dropdown[0].value = 0;
        Stage3Quiz1Dropdown[1].value = 0;
        Stage3Quiz1Dropdown[2].value = 0;
    }

    void Stage4Quiz1CheckDropdown() {
        Quiz4_1();
    }

    void Stage4Quiz1ResetDropdown() {
        Stage4Quiz1Dropdown[0].value = 0;
        Stage4Quiz1Dropdown[1].value = 0;
        Stage4Quiz1Dropdown[2].value = 0;
    }

    IEnumerator WaitingToStart() {
        StartStage.SetActive(true);
        BackButton.gameObject.SetActive(false);
        NextButton.gameObject.SetActive(false);
        SkipButton.gameObject.SetActive(false);
        CloseAllBackground();
        Background[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(startButton);
        yield return waitForButton.Reset();

        NextButton.gameObject.SetActive(true);
        StartStage.SetActive(false);
        StartCoroutine(IntroPlay1());
    }

    IEnumerator IntroPlay1() {
        Intro[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton);
        yield return waitForButton.Reset();

        Intro[0].SetActive(false);
        StartCoroutine(IntroPlay2());
    }

    IEnumerator IntroPlay2() {
        Intro[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton);
        yield return waitForButton.Reset();

        Intro[1].SetActive(false);
        StartCoroutine(IntroPlay3());
    }

    IEnumerator IntroPlay3() {
        Intro[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton);
        yield return waitForButton.Reset();

        Intro[2].SetActive(false);
        StartCoroutine(IntroPlay4());
    }

    IEnumerator IntroPlay4() {
        Intro[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton);
        yield return waitForButton.Reset();

        Intro[3].SetActive(false);
        NextButton.gameObject.SetActive(false);
        StartCoroutine(Menu());
    }

    void ShowAllStage() {
        // Debug.Log(StageStatus[0]);

        if(StageStatus[0]) {
            // Debug.Log("Yes");
            StageButton[0].gameObject.SetActive(true);
            StageScore_1(StageScore[0]);
        } else {
            StageButton[0].gameObject.SetActive(false);
        }

        if(StageStatus[1]) {
            StageButton[1].gameObject.SetActive(true);
            StageScore_2(StageScore[1]);
        } else {
            StageButton[1].gameObject.SetActive(false);
        }

        if(StageStatus[2]) {
            StageButton[2].gameObject.SetActive(true);
            StageScore_3(StageScore[2]);
        } else {
            StageButton[2].gameObject.SetActive(false);
        }

        if(StageStatus[3]) {
            StageButton[3].gameObject.SetActive(true);
            StageScore_4(StageScore[3]);
        } else {
            StageButton[3].gameObject.SetActive(false);
        }

        if(StageStatus[4]) {
            StageButton[4].gameObject.SetActive(true);
            StageScore_5(StageScore[4]);
        } else {
            StageButton[4].gameObject.SetActive(false);
        }
    }

    void CloseAllStage() {
        int i;

        for(i = 0;i < 5;i++) {
            StageButton[i].gameObject.SetActive(false);
        }

        for(i = 0;i < 6;i++) {
            Score_1[i].SetActive(false);
        }

        for(i = 0;i < 6;i++) {
            Score_2[i].SetActive(false);
        }

        for(i = 0;i < 6;i++) {
            Score_3[i].SetActive(false);
        }

        for(i = 0;i < 6;i++) {
            Score_4[i].SetActive(false);
        }

        for(i = 0;i < 6;i++) {
            Score_5[i].SetActive(false);
        }
    }
    void ShowStage(int n) {
        StageStatus[n] = true;
        StageButton[n].gameObject.SetActive(true);
    }

    IEnumerator Menu() {
        ShowAllStage();
        CloseAllBackground();
        Background[0].SetActive(true);
        NextButton.gameObject.SetActive(false);
        SkipButton.gameObject.SetActive(false);
        BackButton.gameObject.SetActive(true);

        var waitForButton = new WaitForUIButtons(BackButton, StageButton[0], StageButton[1], StageButton[2], StageButton[3], StageButton[4]);
        yield return waitForButton.Reset();
        
        if (waitForButton.PressedButton == BackButton) {
            CloseAllStage();
            StartCoroutine(WaitingToStart());
        } else if (waitForButton.PressedButton == StageButton[0]) {
            CloseAllStage();
            StartCoroutine(Story1_1());
        } else if (waitForButton.PressedButton == StageButton[1]) {
            CloseAllStage();
            StartCoroutine(Story2_1());
        } else if (waitForButton.PressedButton == StageButton[2]) {
            CloseAllStage();
            StartCoroutine(Story3_1());
        } else if (waitForButton.PressedButton == StageButton[3]) {
            CloseAllStage();
            StartCoroutine(Tutorial4_1());
        } else if (waitForButton.PressedButton == StageButton[4]) {
            CloseAllStage();
            StartCoroutine(Story5_1());
        }
    }

    IEnumerator Story1_1() {
        NextButton.gameObject.SetActive(true);
        SkipButton.gameObject.SetActive(true);
        CloseAllBackground();
        Background[1].SetActive(true);
        StageScore[0] = 3;
        Story_1[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story1_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial1_1());
        }
    }

    IEnumerator Story1_2() {
        Story_1[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story1_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial1_1());
        }
    }

    IEnumerator Story1_3() {
        CloseAllBackground();
        Background[2].SetActive(true);
        Story_1[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story1_4());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial1_1());
        }
    }

    IEnumerator Story1_4() {
        Story_1[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[3].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story1_5());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial1_1());
        }
    }

    IEnumerator Story1_5() {
        Story_1[4].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[4].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story1_6());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial1_1());
        }
    }

    IEnumerator Story1_6() {
        Story_1[5].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[5].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial1_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial1_1());
        }
    }

    IEnumerator Tutorial1_1() {
        Tutorial_1[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_1[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial1_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_1());
        }
    }

    IEnumerator Tutorial1_2() {
        Tutorial_1[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_1[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial1_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_1());
        }
    }

    IEnumerator Tutorial1_3() {
        Tutorial_1[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_1[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial1_4());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_1());
        }
    }

    IEnumerator Tutorial1_4() {
        Tutorial_1[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_1[3].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial1_5());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_1());
        }
    }

    IEnumerator Tutorial1_5() {
        Tutorial_1[4].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_1[4].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial1_6());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_1());
        }
    }

    IEnumerator Tutorial1_6() {
        Tutorial_1[5].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_1[5].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Quiz1_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_1());
        }
    }

    IEnumerator Quiz1_1() {
        Quiz_1[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(BackButton, Stage1Quiz1Button[0], Stage1Quiz1Button[1], Stage1Quiz1Button[2], Stage1Quiz1Button[3], Stage1Quiz1Button[4]);
        yield return waitForButton.Reset();

        Quiz_1[0].SetActive(false);

        if (waitForButton.PressedButton == Stage1Quiz1Button[3]) {
            StartCoroutine(Story1_7());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else {
            StageScore[0] = StageScore[0] - 1;
            StartCoroutine(Quiz1_1());
        }
    }

    IEnumerator Story1_7() {
        Story_1[6].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[6].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial1_7());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial1_7());
        }
    }

    IEnumerator Tutorial1_7() {
        Tutorial_1[6].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_1[6].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            Quiz1_2();
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz1_2();
        }
    }

    void Quiz1_2() {
        Quiz_1[1].SetActive(true);

        if (Stage1Quiz2Dropdown[0].value == 2 && Stage1Quiz2Dropdown[1].value == 5 && Stage1Quiz2Dropdown[2].value == 3) {
            Quiz_1[1].SetActive(false);
            StartCoroutine(Story1_8());
        }
    }
    
    IEnumerator Story1_8() {
        Stage1Quiz2ResetDropdown();
        CloseAllBackground();
        Background[3].SetActive(true);
        Quiz_1[1].SetActive(false);
        Story_1[7].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[7].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story1_9());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_3());
        }
    }

    IEnumerator Story1_9() {
        Story_1[8].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[8].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story1_10());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_3());
        }
    }

    IEnumerator Story1_10() {
        Story_1[9].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_1[9].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Quiz1_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz1_3());
        }
    }

    IEnumerator Quiz1_3() {
        Quiz_1[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(BackButton, Stage1Quiz3Button[0], Stage1Quiz3Button[1], Stage1Quiz3Button[2], Stage1Quiz3Button[3], Stage1Quiz3Button[4]);
        yield return waitForButton.Reset();

        Quiz_1[2].SetActive(false);

        if (waitForButton.PressedButton == Stage1Quiz3Button[0]) {
            StageStatus[1] = true;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[0] = 0;
            StartCoroutine(Menu());
        } else {
            StageScore[0] = StageScore[0] - 1;
            StartCoroutine(Quiz1_3());
        }
    }

    IEnumerator Story2_1() {
        CloseAllBackground();
        Background[4].SetActive(true);
        NextButton.gameObject.SetActive(true);
        SkipButton.gameObject.SetActive(true);
        StageScore[1] = 3;
        monsterHP = 100;
        Story_2[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_2[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story2_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial2_1());
        }
    }

    IEnumerator Story2_2() {
        Story_2[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_2[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story2_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial2_1());
        }
    }

    IEnumerator Story2_3() {
        Story_2[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_2[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story2_4());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial2_1());
        }
    }

    IEnumerator Story2_4() {
        Story_2[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_2[3].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial2_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial2_1());
        }
    }

    IEnumerator Tutorial2_1() {
        Tutorial_2[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_2[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial2_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz2_1());
        }
    }

    IEnumerator Tutorial2_2() {
        Tutorial_2[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_2[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial2_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz2_1());
        }
    }
    
    IEnumerator Tutorial2_3() {
        Tutorial_2[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_2[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial2_4());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz2_1());
        }
    }
    
    IEnumerator Tutorial2_4() {
        Tutorial_2[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_2[3].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Quiz2_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz2_1());
        }
    }

    IEnumerator Quiz2_1() {
        Quiz_2[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(BackButton, Stage2Quiz1Button[0], Stage2Quiz1Button[1], Stage2Quiz1Button[2], Stage2Quiz1Button[3], Stage2Quiz1Button[4]);
        yield return waitForButton.Reset();

        Quiz_2[0].SetActive(false);

        if (waitForButton.PressedButton == Stage2Quiz1Button[3]) {
            StartCoroutine(Story2_5());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else {
            StageScore[1] = StageScore[1] - 1;
            StartCoroutine(Quiz2_1());
        }
    }

    IEnumerator Story2_5() {
        Story_2[4].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_2[4].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story2_6());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz2_2();
        }
    }

    IEnumerator Story2_6() {
        Story_2[5].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_2[5].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            Quiz2_2();
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz2_2();
        }
    }

    void Quiz2_2() {
        Quiz_2[1].SetActive(true);

        if (Stage2Quiz2Dropdown[0].value == 1 && Stage2Quiz2Dropdown[1].value == 2 && Stage2Quiz2Dropdown[2].value == 1) {
            Quiz_2[1].SetActive(false);
            StartCoroutine(Story2_7());
        }
    }

    IEnumerator Story2_7() {
        Quiz_2[1].SetActive(false);
        Stage2Quiz2ResetDropdown();
        Story_2[6].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_2[6].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Quiz2_3_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz2_3_1());
        }
    }

    void ActivateAllBlank(bool set) {
        int i;

        for(i = 0;i <= 15;i++) {
            BlankBlock[i].SetActive(set);
        }
    }

    void ActivateAllSelect(bool set) {
        int i;

        for(i = 0;i <= 15;i++) {
            SelectBlock[i].SetActive(set);
        }
    }

    void ChangeBlock(int select) {
        ActivateAllBlank(true);
        ActivateAllSelect(false);
        SelectBlock[select].SetActive(true);
    }

    void AttackMonster() {
        int amount = UnityEngine.Random.Range(10, 40);

        if(monsterHP - amount <= 0) {
            monsterHP = 0;
            Stage2Quiz3MonsterHP.text = "HP: " + monsterHP + "/100";

            Quiz_2[2].SetActive(false);
            Stage2Quiz3Select.text = "Select[ ][ ]";
            StageStatus[2] = true;
            StartCoroutine(Menu());
        } else {
            monsterHP = monsterHP - amount;
            Stage2Quiz3MonsterHP.text = "HP: " + monsterHP + "/100";
            Stage2Quiz3Select.text = "Select[ ][ ]";
            StartCoroutine(Quiz2_3_1());
        }
    }

    IEnumerator Quiz2_3_1() {
        Quiz_2[2].SetActive(true);
        
        int select = UnityEngine.Random.Range(0, 15);

        ChangeBlock(select);

        var waitForButton = new WaitForUIButtons(BackButton, Stage2Quiz3Button[0], Stage2Quiz3Button[1], Stage2Quiz3Button[2], Stage2Quiz3Button[3]);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == Stage2Quiz3Button[0] && (select >= 0 && select <= 3)) {
            Stage2Quiz3Select.text = "Select[0][ ]";
            StartCoroutine(Quiz2_3_2(select));
        } else if (waitForButton.PressedButton == Stage2Quiz3Button[1] && (select >= 4 && select <= 7)) {
            Stage2Quiz3Select.text = "Select[1][ ]";
            StartCoroutine(Quiz2_3_2(select));
        } else if (waitForButton.PressedButton == Stage2Quiz3Button[2] && (select >= 8 && select <= 11)) {
            Stage2Quiz3Select.text = "Select[2][ ]";
            StartCoroutine(Quiz2_3_2(select));
        } else if (waitForButton.PressedButton == Stage2Quiz3Button[3] && (select >= 12 && select <= 15)) {
            Stage2Quiz3Select.text = "Select[3][ ]";
            StartCoroutine(Quiz2_3_2(select));
        } else if (waitForButton.PressedButton == BackButton) {
            Stage2Quiz3Select.text = "Select[ ][ ]";
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else {
            Stage2Quiz3Select.text = "Select[ ][ ]";
            StageScore[1] = StageScore[1] - 1;
            StartCoroutine(Quiz2_3_1());
        }
    }

    IEnumerator Quiz2_3_2(int select) {
        var waitForButton = new WaitForUIButtons(BackButton, Stage2Quiz3Button[0], Stage2Quiz3Button[1], Stage2Quiz3Button[2], Stage2Quiz3Button[3]);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == Stage2Quiz3Button[0] && select % 4 == 0) {
            AttackMonster();
        } else if (waitForButton.PressedButton == Stage2Quiz3Button[1] && select % 4 == 1) {
            AttackMonster();
        } else if (waitForButton.PressedButton == Stage2Quiz3Button[2] && select % 4 == 2) {
            AttackMonster();
        } else if (waitForButton.PressedButton == Stage2Quiz3Button[3] && select % 4 == 3) {
            AttackMonster();
        } else if (waitForButton.PressedButton == BackButton) {
            Stage2Quiz3Select.text = "Select[ ][ ]";
            StageScore[1] = 0;
            StartCoroutine(Menu());
        } else {
            Stage2Quiz3Select.text = "Select[ ][ ]";
            StageScore[1] = StageScore[1] - 1;
            StartCoroutine(Quiz2_3_1());
        }
    }

    IEnumerator Story3_1() {
        CloseAllBackground();
        Background[2].SetActive(true);
        NextButton.gameObject.SetActive(true);
        SkipButton.gameObject.SetActive(true);
        StageScore[2] = 3;
        Story_3[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_3[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story3_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[2] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial3_1());
        }
    }

    IEnumerator Story3_2() {
        Story_3[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_3[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story3_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[2] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial3_1());
        }
    }

    IEnumerator Story3_3() {
        Story_3[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_3[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial3_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[2] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial3_1());
        }
    }

    IEnumerator Tutorial3_1() {
        Tutorial_3[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_3[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial3_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[2] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz3_1();
        }
    }

    IEnumerator Tutorial3_2() {
        Tutorial_3[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_3[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial3_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[2] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz3_1();
        }
    }

    IEnumerator Tutorial3_3() {
        Tutorial_3[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_3[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial3_4());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[2] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz3_1();
        }
    }

    IEnumerator Tutorial3_4() {
        Tutorial_3[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_3[3].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial3_5());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[2] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz3_1();
        }
    }

    IEnumerator Tutorial3_5() {
        Tutorial_3[4].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_3[4].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            Quiz3_1();
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[2] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz3_1();
        }
    }

    void Quiz3_1() {
        Quiz_3[0].SetActive(true);

        if (Stage3Quiz1Dropdown[0].value == 1 && Stage3Quiz1Dropdown[1].value == 1 && Stage3Quiz1Dropdown[2].value == 2) {
            Quiz_3[0].SetActive(false);
            StageStatus[3] = true;
            StartCoroutine(Menu());
        }
    }

    IEnumerator Tutorial4_1() {
        NextButton.gameObject.SetActive(true);
        SkipButton.gameObject.SetActive(true);
        CloseAllBackground();
        Background[5].SetActive(true);
        StageScore[3] = 3;
        Tutorial_4[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_4[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial4_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Story4_1());
        }
    }

    IEnumerator Tutorial4_2() {
        Tutorial_4[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_4[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial4_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Story4_1());
        }
    }

    IEnumerator Tutorial4_3() {
        Tutorial_4[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_4[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story4_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Story4_1());
        }
    }

    IEnumerator Story4_1() {
        Story_4[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_4[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story4_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz4_1();
        }
    }

    IEnumerator Story4_2() {
        Story_4[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_4[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story4_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz4_1();
        }
    }

    IEnumerator Story4_3() {
        Story_4[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_4[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            Quiz4_1();
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            Quiz4_1();
        }
    }

    void Quiz4_1() {
        Quiz_4[0].SetActive(true);

        if (Stage4Quiz1Dropdown[0].value == 1 && Stage4Quiz1Dropdown[1].value == 2 && Stage4Quiz1Dropdown[2].value == 1) {
            Quiz_4[0].SetActive(false);
            StartCoroutine(Story4_4());
        }
    }

    IEnumerator Story4_4() {
        Stage4Quiz1ResetDropdown();
        CloseAllBackground();
        Background[6].SetActive(true);
        Quiz_4[0].SetActive(false);
        Story_4[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_4[3].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story4_5());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz4_2());
        }
    }

    IEnumerator Story4_5() {
        Story_4[4].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_4[4].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story4_6());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz4_2());
        }
    }

    IEnumerator Story4_6() {
        Story_4[5].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_4[5].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Quiz4_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz4_2());
        }
    }

    IEnumerator Quiz4_2() {
        Quiz_4[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(BackButton, Stage4Quiz2Button[0], Stage4Quiz2Button[1], Stage4Quiz2Button[2], Stage4Quiz2Button[3]);
        yield return waitForButton.Reset();

        Quiz_4[1].SetActive(false);

        if (waitForButton.PressedButton == Stage4Quiz2Button[1]) {
            StageStatus[4] = true;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[3] = 0;
            StartCoroutine(Menu());
        } else {
            StageScore[3] = StageScore[3] - 1;
            StartCoroutine(Quiz4_2());
        }
    }

    IEnumerator Story5_1() {
        CloseAllBackground();
        Background[7].SetActive(true);
        NextButton.gameObject.SetActive(true);
        SkipButton.gameObject.SetActive(true);
        StageScore[4] = 3;
        Story_5[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_5[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story5_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial5_1());
        }
    }

    IEnumerator Story5_2() {
        Story_5[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_5[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Story5_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial5_1());
        }
    }

    IEnumerator Story5_3() {
        Story_5[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_5[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial5_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial5_1());
        }
    }

    IEnumerator Tutorial5_1() {
        Tutorial_5[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_5[0].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial5_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz5_1());
        }
    }

    IEnumerator Tutorial5_2() {
        Tutorial_5[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_5[1].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Quiz5_1());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz5_1());
        }
    }

    IEnumerator Quiz5_1() {
        Quiz_5[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(BackButton, Stage5Quiz1Button[0], Stage5Quiz1Button[1], Stage5Quiz1Button[2], Stage5Quiz1Button[3]);
        yield return waitForButton.Reset();

        Quiz_5[0].SetActive(false);

        if (waitForButton.PressedButton == Stage5Quiz1Button[0]) {
            StartCoroutine(Story5_4());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else {
            StageScore[4] = StageScore[4] - 1;
            StartCoroutine(Quiz5_1());
        }
    }

    IEnumerator Story5_4() {
        Story_5[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_5[3].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial5_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial5_3());
        }
    }

    IEnumerator Tutorial5_3() {
        Tutorial_5[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_5[2].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial5_4());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz5_2());
        }
    }

    IEnumerator Tutorial5_4() {
        Tutorial_5[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_5[3].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Quiz5_2());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz5_2());
        }
    }

    IEnumerator Quiz5_2() {
        Quiz_5[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(BackButton, Stage5Quiz2Button[0], Stage5Quiz2Button[1], Stage5Quiz2Button[2], Stage5Quiz2Button[3]);
        yield return waitForButton.Reset();

        Quiz_5[1].SetActive(false);

        if (waitForButton.PressedButton == Stage5Quiz2Button[0]) {
            StartCoroutine(Story5_5());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else {
            StageScore[4] = StageScore[4] - 1;
            StartCoroutine(Quiz5_2());
        }
    }

    IEnumerator Story5_5() {
        CloseAllBackground();
        Background[8].SetActive(true);
        Story_5[4].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_5[4].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial5_5());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Tutorial5_5());
        }
    }

    IEnumerator Tutorial5_5() {
        Tutorial_5[4].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_5[4].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Tutorial5_6());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz5_3());
        }
    }

    IEnumerator Tutorial5_6() {
        Tutorial_5[5].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Tutorial_5[5].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Quiz5_3());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Quiz5_3());
        }
    }


    IEnumerator Quiz5_3() {
        Quiz_5[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(BackButton, Stage5Quiz3Button[0], Stage5Quiz3Button[1], Stage5Quiz3Button[2], Stage5Quiz3Button[3]);
        yield return waitForButton.Reset();

        Quiz_5[2].SetActive(false);

        if (waitForButton.PressedButton == Stage5Quiz3Button[2]) {
            StartCoroutine(Story5_6());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else {
            StageScore[4] = StageScore[4] - 1;
            StartCoroutine(Quiz5_3());
        }
    }

    IEnumerator Story5_6() {
        Story_5[5].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, BackButton, SkipButton);
        yield return waitForButton.Reset();

        Story_5[5].SetActive(false);

        if (waitForButton.PressedButton == NextButton) {
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == BackButton) {
            StageScore[4] = 0;
            StartCoroutine(Menu());
        } else if (waitForButton.PressedButton == SkipButton) {
            StartCoroutine(Menu());
        }
    }
}
