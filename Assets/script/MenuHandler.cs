using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuHandler : MonoBehaviour
{
    [SerializeField] GameObject StartStage;
    [SerializeField] GameObject EndStage;
    public Button startButton;
    public Button restartButton;
    [SerializeField] GameObject Intro1;
    [SerializeField] GameObject Intro2;
    [SerializeField] GameObject Array1;
    [SerializeField] GameObject Array2;
    [SerializeField] GameObject Array3;
    [SerializeField] GameObject Array4;
    [SerializeField] List<GameObject> ArraySection1;
    [SerializeField] List<GameObject> ArraySection2;
    [SerializeField] List<GameObject> ArraySection3;
    [SerializeField] List<GameObject> ArraySection4;
    [SerializeField] GameObject background_grass;
    public Button NextButton;
    public Button PreviousButton;
    [SerializeField] GameObject Store;
    [SerializeField] GameObject Puzzle;
    [SerializeField] GameObject Battle;
    [SerializeField] List<GameObject> StoreSection;
    [SerializeField] List<GameObject> PuzzleSection;
    [SerializeField] List<Button> StoreQuiz1Button;
    [SerializeField] List<Dropdown> StoreQuiz2Dropdown;
    [SerializeField] List<Dropdown> StoreQuiz3Dropdown;
    [SerializeField] List<Dropdown> PuzzleQuiz1Dropdown;
    [SerializeField] Dropdown PuzzleQuiz2Dropdown;
    [SerializeField] List<Button> BattleButton;
    [SerializeField] Text BossHP;
    [SerializeField] Text BossWeakness;
    [SerializeField] Text Result;
    [SerializeField] GameObject Map;
    [SerializeField] GameObject Fight;
    [SerializeField] GameObject Blank;
    [SerializeField] GameObject Selected;
    [SerializeField] List<GameObject> BlankBlock;
    [SerializeField] List<GameObject> SelectBlock;
    [SerializeField] GameObject choiceFirst;
    [SerializeField] GameObject choiceSecond;
    [SerializeField] List<Button> choiceFirstButton;
    [SerializeField] List<Button> choiceSecondButton;
    [SerializeField] Text MonsterHP;
    [SerializeField] GameObject background_cave;

    private int HP;
    private int monsterHP;


    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(Prepare);
        restartButton.onClick.AddListener(Restart);
        NextButton.gameObject.SetActive(false);
        PreviousButton.gameObject.SetActive(false);
        StartStage.SetActive(true);
        EndStage.SetActive(false);

        StoreQuiz2Dropdown[0].onValueChanged.AddListener(delegate {
            StoreQuiz2CheckDropdown();
        });
        StoreQuiz2Dropdown[1].onValueChanged.AddListener(delegate {
            StoreQuiz2CheckDropdown();
        });
        StoreQuiz2Dropdown[2].onValueChanged.AddListener(delegate {
            StoreQuiz2CheckDropdown();
        });
        StoreQuiz2Dropdown[3].onValueChanged.AddListener(delegate {
            StoreQuiz2CheckDropdown();
        });

        StoreQuiz3Dropdown[0].onValueChanged.AddListener(delegate {
            StoreQuiz3CheckDropdown();
        });
        StoreQuiz3Dropdown[1].onValueChanged.AddListener(delegate {
            StoreQuiz3CheckDropdown();
        });
        StoreQuiz3Dropdown[2].onValueChanged.AddListener(delegate {
            StoreQuiz3CheckDropdown();
        });
        StoreQuiz3Dropdown[3].onValueChanged.AddListener(delegate {
            StoreQuiz3CheckDropdown();
        });

        PuzzleQuiz1Dropdown[0].onValueChanged.AddListener(delegate {
            PuzzleQuiz1CheckDropdown();
        });
        PuzzleQuiz1Dropdown[1].onValueChanged.AddListener(delegate {
            PuzzleQuiz1CheckDropdown();
        });
        PuzzleQuiz1Dropdown[2].onValueChanged.AddListener(delegate {
            PuzzleQuiz1CheckDropdown();
        });

        PuzzleQuiz2Dropdown.onValueChanged.AddListener(delegate {
            PuzzleQuiz2CheckDropdown();
        });

        HP = 100;
        monsterHP = 100;
    }

    void StoreQuiz2CheckDropdown() {
        StoreQuiz2();
    }

    void StoreQuiz2ResetDropdown() {
        StoreQuiz2Dropdown[0].value = 0;
        StoreQuiz2Dropdown[1].value = 0;
        StoreQuiz2Dropdown[2].value = 0;
        StoreQuiz2Dropdown[3].value = 0;
    }

    void StoreQuiz3CheckDropdown() {
        StoreQuiz3();
    }

    void StoreQuiz3ResetDropdown() {
        StoreQuiz3Dropdown[0].value = 0;
        StoreQuiz3Dropdown[1].value = 0;
        StoreQuiz3Dropdown[2].value = 0;
        StoreQuiz3Dropdown[3].value = 0;
    }

    void PuzzleQuiz1CheckDropdown() {
        PuzzleQuiz1();
    }

    void PuzzleQuiz1ResetDropdown() {
        PuzzleQuiz1Dropdown[0].value = 0;
        PuzzleQuiz1Dropdown[1].value = 0;
        PuzzleQuiz1Dropdown[2].value = 0;
    }

    void PuzzleQuiz2CheckDropdown() {
        PuzzleQuiz2();
    }

    void PuzzleQuiz2ResetDropdown() {
        PuzzleQuiz2Dropdown.value = 0;
    }

    void Restart() {
        background_cave.SetActive(false);
        background_grass.SetActive(true);
        StartStage.SetActive(true);
        EndStage.SetActive(false);
        NextButton.gameObject.SetActive(false);
        PreviousButton.gameObject.SetActive(false);
    }

    void Prepare() {
        HP = 100;
        monsterHP = 100;

        NextButton.gameObject.SetActive(true);
        PreviousButton.gameObject.SetActive(true);
        StartCoroutine(IntroPlay1());
    }

    IEnumerator IntroPlay1() {
        StartStage.SetActive(false);
        Intro1.SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            Intro1.SetActive(false);
            StartCoroutine(IntroPlay2());
        } else if (waitForButton.PressedButton == PreviousButton) {
            Intro1.SetActive(false);
            Restart();
        }
    }

    IEnumerator IntroPlay2() {
        Intro2.SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            Intro2.SetActive(false);
            StartCoroutine(ArrayPlay1_1());
        } else if (waitForButton.PressedButton == PreviousButton) {
            Intro2.SetActive(false);
            StartCoroutine(IntroPlay1());
        }
    }

    IEnumerator ArrayPlay1_1() {
        Array1.SetActive(true);
        ArraySection1[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            ArraySection1[0].SetActive(false);
            StartCoroutine(ArrayPlay1_2());
        } else if (waitForButton.PressedButton == PreviousButton) {
            Array1.SetActive(false);
            ArraySection1[0].SetActive(false);
            StartCoroutine(IntroPlay2());
        }
    }

    IEnumerator ArrayPlay1_2() {
        ArraySection1[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            ArraySection1[1].SetActive(false);
            StartCoroutine(ArrayPlay1_3());
        } else if (waitForButton.PressedButton == PreviousButton) {
            ArraySection1[1].SetActive(false);
            StartCoroutine(ArrayPlay1_1());
        }
    }

    IEnumerator ArrayPlay1_3() {
        ArraySection1[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            Array1.SetActive(false);
            ArraySection1[2].SetActive(false);
            StartCoroutine(ArrayPlay2_1());
        } else if (waitForButton.PressedButton == PreviousButton) {
            ArraySection1[2].SetActive(false);
            StartCoroutine(ArrayPlay1_2());
        }
    }

    IEnumerator ArrayPlay2_1() {
        Array2.SetActive(true);
        ArraySection2[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            ArraySection2[0].SetActive(false);
            StartCoroutine(ArrayPlay2_2());
        } else if (waitForButton.PressedButton == PreviousButton) {
            Array2.SetActive(false);
            ArraySection2[0].SetActive(false);
            Array1.SetActive(true);
            StartCoroutine(ArrayPlay1_3());
        }
    }

    IEnumerator ArrayPlay2_2() {
        ArraySection2[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            Array2.SetActive(false);
            ArraySection2[1].SetActive(false);
            StartCoroutine(ArrayPlay3_1());
        } else if (waitForButton.PressedButton == PreviousButton) {
            ArraySection2[1].SetActive(false);
            StartCoroutine(ArrayPlay2_1());
        }
    }

    IEnumerator ArrayPlay3_1() {
        Array3.SetActive(true);
        ArraySection3[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            ArraySection3[0].SetActive(false);
            StartCoroutine(ArrayPlay3_2());
        } else if (waitForButton.PressedButton == PreviousButton) {
            Array3.SetActive(false);
            ArraySection3[0].SetActive(false);
            Array2.SetActive(true);
            StartCoroutine(ArrayPlay2_2());
        }
    }

    IEnumerator ArrayPlay3_2() {
        ArraySection3[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            ArraySection3[1].SetActive(false);
            StartCoroutine(ArrayPlay3_3());
        } else if (waitForButton.PressedButton == PreviousButton) {
            ArraySection3[1].SetActive(false);
            StartCoroutine(ArrayPlay3_1());
        }
    }

    IEnumerator ArrayPlay3_3() {
        ArraySection3[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            ArraySection3[2].SetActive(false);
            StartCoroutine(ArrayPlay3_4());
        } else if (waitForButton.PressedButton == PreviousButton) {
            ArraySection3[2].SetActive(false);
            StartCoroutine(ArrayPlay3_2());
        }
    }

    IEnumerator ArrayPlay3_4() {
        ArraySection3[3].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            Array3.SetActive(false);
            ArraySection3[3].SetActive(false);
            StartCoroutine(ArrayPlay4_1());
        } else if (waitForButton.PressedButton == PreviousButton) {
            ArraySection3[3].SetActive(false);
            StartCoroutine(ArrayPlay3_3());
        }
    }

    IEnumerator ArrayPlay4_1() {
        Array4.SetActive(true);
        ArraySection4[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            ArraySection4[0].SetActive(false);
            StartCoroutine(ArrayPlay4_2());
        } else if (waitForButton.PressedButton == PreviousButton) {
            Array4.SetActive(false);
            ArraySection4[0].SetActive(false);
            Array3.SetActive(true);
            StartCoroutine(ArrayPlay3_4());
        }
    }

    IEnumerator ArrayPlay4_2() {
        ArraySection4[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            ArraySection4[1].SetActive(false);
            StartCoroutine(ArrayPlay4_3());
        } else if (waitForButton.PressedButton == PreviousButton) {
            ArraySection4[1].SetActive(false);
            StartCoroutine(ArrayPlay4_1());
        }
    }

    IEnumerator ArrayPlay4_3() {
        ArraySection4[2].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            Array4.SetActive(false);
            ArraySection4[2].SetActive(false);
            StartCoroutine(StoreStart());
        } else if (waitForButton.PressedButton == PreviousButton) {
            ArraySection4[2].SetActive(false);
            StartCoroutine(ArrayPlay4_2());
        }
    }

    IEnumerator StoreStart() {
        background_cave.SetActive(true);
        background_grass.SetActive(false);
        Store.SetActive(true);
        StoreSection[0].SetActive(true);

        var waitForButton = new WaitForUIButtons(NextButton, PreviousButton);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == NextButton) {
            StoreSection[0].SetActive(false);
            NextButton.gameObject.SetActive(false);
            PreviousButton.gameObject.SetActive(false);
            StartCoroutine(StoreQuiz1());
        } else if (waitForButton.PressedButton == PreviousButton) {
            background_cave.SetActive(false);
            background_grass.SetActive(true);
            Store.SetActive(false);
            StoreSection[0].SetActive(false);
            Array4.SetActive(true);
            StartCoroutine(ArrayPlay4_3());
        }
    }

    IEnumerator StoreQuiz1() {
        StoreSection[1].SetActive(true);

        var waitForButton = new WaitForUIButtons(StoreQuiz1Button[0], StoreQuiz1Button[1], StoreQuiz1Button[2], StoreQuiz1Button[3]);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == StoreQuiz1Button[1]) {
            StoreSection[1].SetActive(false);
            StoreQuiz2();
        } else {
            StartCoroutine(StoreQuiz1());
        }
    }

    void StoreQuiz2() {
        StoreSection[2].SetActive(true);

        if (StoreQuiz2Dropdown[0].value == 2 && StoreQuiz2Dropdown[1].value == 4 && StoreQuiz2Dropdown[2].value == 3 && StoreQuiz2Dropdown[3].value == 1) {
            StoreSection[2].SetActive(false);
            StoreQuiz2ResetDropdown();
            StoreQuiz3();
        }
    }

    void StoreQuiz3() {
        StoreSection[2].SetActive(false);
        StoreSection[3].SetActive(true);

        if (StoreQuiz3Dropdown[0].value == 2 && StoreQuiz3Dropdown[1].value == 3 && StoreQuiz3Dropdown[2].value == 4 && StoreQuiz3Dropdown[3].value == 1) {
            StoreSection[3].SetActive(false);
            Store.SetActive(false);
            StoreQuiz3ResetDropdown();
            PuzzleQuiz1();
        }
    }

    void PuzzleQuiz1() {
        Puzzle.SetActive(true);
        PuzzleSection[0].SetActive(true);

        if (PuzzleQuiz1Dropdown[0].value == 3 && PuzzleQuiz1Dropdown[1].value == 2 && PuzzleQuiz1Dropdown[2].value == 1) {
            PuzzleSection[0].SetActive(false);
            PuzzleQuiz1ResetDropdown();
            PuzzleQuiz2();
        }
    }

    void PuzzleQuiz2() {
        PuzzleSection[0].SetActive(false);
        PuzzleSection[1].SetActive(true);

        if (PuzzleQuiz2Dropdown.value == 1) {
            Puzzle.SetActive(false);
            PuzzleSection[1].SetActive(false);
            PuzzleQuiz2ResetDropdown();
            StartCoroutine(BattleBoss());
        }
    }

    void changeWeakness(int select) {
        if (select == 1) {
            BossWeakness.text = "Weakness: Sword";
        } else if (select == 2) {
            BossWeakness.text = "Weakness: Magic";
        } else if (select == 3) {
            BossWeakness.text = "Weakness: Hammer";
        } else if (select == 4) {
            BossWeakness.text = "Weakness: Bow";
        }
    }

    void Attack() {
        int amount = UnityEngine.Random.Range(10, 40);

        if(HP - amount <= 0) {
            HP = 0;
            BossHP.text = "HP: " + HP + "/100";
            StartCoroutine(FightBoss());
        } else {
            HP = HP - amount;
            BossHP.text = "HP: " + HP + "/100";
            StartCoroutine(BattleBoss());
        }
    }

    IEnumerator BattleBoss() {
        Battle.SetActive(true);
        
        int select = UnityEngine.Random.Range(1, 4);

        changeWeakness(select);

        var waitForButton = new WaitForUIButtons(BattleButton[0], BattleButton[1], BattleButton[2], BattleButton[3]);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == BattleButton[0] && select == 1) {
            Attack();
        } else if (waitForButton.PressedButton == BattleButton[1] && select == 2) {
            Attack();
        } else if (waitForButton.PressedButton == BattleButton[2] && select == 3) {
            Attack();
        } else if (waitForButton.PressedButton == BattleButton[3] && select == 4) {
            Attack();
        } else {
            End();
        }
    }

    void ActivateAllBlank(bool set) {
        int i;

        for(i = 0;i <= 19;i++) {
            BlankBlock[i].SetActive(set);
        }
    }

    void ActivateAllSelect(bool set) {
        int i;

        for(i = 0;i <= 19;i++) {
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
            MonsterHP.text = "HP: " + monsterHP + "/100";
            End();
        } else {
            monsterHP = monsterHP - amount;
            MonsterHP.text = "HP: " + monsterHP + "/100";
            StartCoroutine(FightBoss());
        }
    }

    IEnumerator FightBoss() {
        Battle.SetActive(false);
        Fight.SetActive(true);
        choiceFirst.SetActive(true);
        choiceSecond.SetActive(false);
        
        int select = UnityEngine.Random.Range(0, 19);

        ChangeBlock(select);

        var waitForButton = new WaitForUIButtons(choiceFirstButton[0], choiceFirstButton[1], choiceFirstButton[2], choiceFirstButton[3], choiceFirstButton[4]);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == choiceFirstButton[0] && (select >= 0 && select <= 3)) {
            StartCoroutine(FightBoss2(select));
        } else if (waitForButton.PressedButton == choiceFirstButton[1] && (select >= 4 && select <= 7)) {
            StartCoroutine(FightBoss2(select));
        } else if (waitForButton.PressedButton == choiceFirstButton[2] && (select >= 8 && select <= 11)) {
            StartCoroutine(FightBoss2(select));
        } else if (waitForButton.PressedButton == choiceFirstButton[3] && (select >= 12 && select <= 15)) {
            StartCoroutine(FightBoss2(select));
        } else if (waitForButton.PressedButton == choiceFirstButton[4] && (select >= 16 && select <= 19)) {
            StartCoroutine(FightBoss2(select));
        } else {
            End();
        }
    }

    IEnumerator FightBoss2(int select) {
        choiceFirst.SetActive(false);
        choiceSecond.SetActive(true);

        var waitForButton = new WaitForUIButtons(choiceSecondButton[0], choiceSecondButton[1], choiceSecondButton[2], choiceSecondButton[3]);
        yield return waitForButton.Reset();

        if (waitForButton.PressedButton == choiceSecondButton[0] && select % 4 == 0) {
            choiceSecond.SetActive(false);
            AttackMonster();
        } else if (waitForButton.PressedButton == choiceSecondButton[1] && select % 4 == 1) {
            choiceSecond.SetActive(false);
            AttackMonster();
        } else if (waitForButton.PressedButton == choiceSecondButton[2] && select % 4 == 2) {
            choiceSecond.SetActive(false);
            AttackMonster();
        } else if (waitForButton.PressedButton == choiceSecondButton[3] && select % 4 == 3) {
            choiceSecond.SetActive(false);
            AttackMonster();
        } else {
            choiceSecond.SetActive(false);
            End();
        }
    }

    void End() {
        if (HP == 0) {
            Result.text = "WIN";
        } else {
            Result.text = "LOSE";
        }

        Fight.SetActive(false);
        EndStage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
