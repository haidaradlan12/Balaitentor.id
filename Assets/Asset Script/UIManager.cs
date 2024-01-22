using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Firebase;
using Firebase.Auth;
using TMPro;

public class UIManager : MonoBehaviour
{
    //Firebase variabel
    [Header("Firebase")]
    public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;
    public FirebaseUser User;

    //Login variabel
    [Header("Login")]
    public TMP_InputField emailLoginField;
    public TMP_InputField passwordLoginField;
    public TMP_Text warningLoginText;
    public TMP_Text confirmLoginText;

    //Register variabel
    [Header("Register")]
    public TMP_InputField usernameRegisterField;
    public TMP_InputField emailRegisterField;
    public TMP_InputField passwordRegisterField;
    public TMP_InputField passwordRegisterVerifyField;
    public TMP_Text warningRegisterText;

    [Header("Conten")]
    public RectTransform conten;

    [Header("down")]
    public GameObject d1; public GameObject d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d14, d13, d15, d16, d17, d18, d19, d20;
    [Header("up")]
    public GameObject dw1; public GameObject dw2, dw3, dw4, dw5, dw6, dw7, dw8, dw9, dw10, dw11, dw12, dw14, dw13, dw15, dw16, dw17, dw18, dw19, dw20;

    //variabel lain
    int TK, SD, SMP, SMA, MHS, S1, PPG, BHS, MTK,IPA,IPS,SB,PAI,PPKN, So, To, Lo, up, down, step=1, stup;
    int TK0, SD0, SMP0, SMA0, MHS0, S10, PPG0, BHS0, MTK0, IPA0, IPS0, SB0, PAI0, PPKN0;
    int TK1, SD1, SMP1, SMA1, MHS1, S11, PPG1, BHS1, MTK1, IPA1, IPS1, SB1, PAI1, PPKN1;

    int jumlahdata1, jumlahdata2;

    [Header("UI")]
    public RectTransform Sig; public RectTransform Log, Pu1, Pu2, Pu, PL, PGL, PI, back1;
    // Start is called before the first frame update
    void Update()
    {
        if (step==1)
        {
            jumlahdata1 = GameObject.FindGameObjectsWithTag("TampilanData").Length;
            jumlahdata2 = GameObject.FindGameObjectsWithTag("TampilinData2").Length;
            conten.sizeDelta = new Vector2(67.0f, ((692*jumlahdata1)+(447*jumlahdata2)));
        }
        else if (step==2)
        {
            TK = TK1;
            SD = SD1;
            SMP = SMP1;
            SMA = SMA1;
            MHS = MHS1;
            S1 = S11;
            PPG = PPG1;
            BHS = BHS1;
            MTK = MTK1;
            IPA = IPA1;
            IPS = IPS1;
            SB = SB1;
            PAI = PAI1;
            PPKN = PPKN1;

            step = 3;
        }
        else if (step==3) //save data
        {
            TK0 = TK;
            SD0 = SD;
            SMP0 = SMP;
            SMA0 = SMA;
            MHS0 = MHS;
            S10 = S1;
            PPG0 = PPG;
            BHS0 = BHS;
            MTK0 = MTK;
            IPA0 = IPA;
            IPS0 = IPS;
            SB0 = SB;
            PAI0 = PAI;
            PPKN0 = PPKN;

            step = 4;
        }
        else if (step==4)
        {
            TK = TK0;
            SD = SD0;
            SMP = SMP0;
            SMA = SMA0;
            MHS = MHS0;
            S1 = S10;
            PPG = PPG0;
            BHS = BHS0;
            MTK = MTK0;
            IPA = IPA0;
            IPS = IPS0;
            SB = SB0;
            PAI = PAI0;
            PPKN = PPKN0;

            step = 5;
        }
        else if (step==5)
        {
            if (TK == 1)
            {
                if (MHS == 0 && S1 == 0 && PPG == 0)
                {
                    dw3.SetActive(false);
                    dw8.SetActive(false);
                    dw19.SetActive(false);

                    d3.SetActive(false);
                    d8.SetActive(false);
                    d19.SetActive(false);
                }
                else
                {
                    if (MHS == 1 && (S1 == 1 || S1 == 0) && (PPG == 1 || PPG == 0))
                    {
                        dw19.SetActive(true);
                        d19.SetActive(false);
                    }
                    else
                    {
                        dw19.SetActive(false);
                        d19.SetActive(false);
                    }

                    if (S1 == 1 && (MHS == 1 || MHS == 0) && (PPG == 1 || PPG == 0))
                    {
                        dw3.SetActive(true);
                        d3.SetActive(false);
                    }
                    else
                    {
                        dw3.SetActive(false);
                        d3.SetActive(false);
                    }

                    if (PPG == 1 && (S1 == 1 || S1 == 0) && (MHS == 1 || MHS == 0))
                    {
                        dw8.SetActive(true);
                        d8.SetActive(false);
                    }
                    else
                    {
                        dw8.SetActive(false);
                        d8.SetActive(false);
                    }
                }
            }
            if (SD == 1)
            {
                if (MHS == 0 && S1 == 0 && PPG == 0) //semua
                {
                    dw1.SetActive(false);
                    dw2.SetActive(false);
                    dw5.SetActive(false);

                    dw8.SetActive(false);
                    dw9.SetActive(false);
                    dw12.SetActive(false);

                    dw13.SetActive(false);
                    dw14.SetActive(false);
                    dw15.SetActive(false);
                    dw16.SetActive(false);
                    dw19.SetActive(false);
                    dw20.SetActive(false);

                    d1.SetActive(false);
                    d2.SetActive(false);
                    d5.SetActive(false);

                    d8.SetActive(false);
                    d9.SetActive(false);
                    d12.SetActive(false);

                    d13.SetActive(false);
                    d14.SetActive(false);
                    d15.SetActive(false);
                    d16.SetActive(false);
                    d19.SetActive(false);
                    d20.SetActive(false);
                }
                else
                {
                    if (MHS == 1)
                    {
                        if (IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0 && BHS == 1 && MTK == 0)
                        {
                            dw13.SetActive(true);
                            dw14.SetActive(true);
                            d13.SetActive(false);
                            d14.SetActive(false);
                        }
                        else
                        {
                            dw13.SetActive(false);
                            dw14.SetActive(false);
                            d13.SetActive(false);
                            d14.SetActive(false);
                        }
                        if (IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0 && BHS == 0 && MTK == 1)
                        {
                            dw15.SetActive(true);
                            dw16.SetActive(true);
                            d15.SetActive(false);
                            d16.SetActive(false);
                        }
                        else
                        {
                            dw15.SetActive(false);
                            dw16.SetActive(false);
                            d15.SetActive(false);
                            d16.SetActive(false);
                        }
                        if (IPA == 1 || IPS == 1 || SB == 1 || PAI == 1 || PPKN == 1 || BHS == 1 || MTK == 1)
                        {
                            dw19.SetActive(true);
                            dw20.SetActive(true);
                            d19.SetActive(false);
                            d20.SetActive(false);
                        }
                        else
                        {
                            dw19.SetActive(false);
                            dw20.SetActive(false);
                            d19.SetActive(false);
                            d20.SetActive(false);
                        }
                    }
                    else
                    {
                        dw13.SetActive(false);
                        dw14.SetActive(false);
                        dw15.SetActive(false);
                        dw16.SetActive(false);
                        dw19.SetActive(false);
                        dw20.SetActive(false);

                        d13.SetActive(false);
                        d14.SetActive(false);
                        d15.SetActive(false);
                        d16.SetActive(false);
                        d19.SetActive(false);
                        d20.SetActive(false);
                    }
                    if (PPG == 1)
                    {
                        if (BHS == 1 || MTK == 1 || IPA == 1 || IPS == 1 || SB == 1 || PPKN == 1 || PAI == 1)
                        {
                            dw8.SetActive(true);
                            dw12.SetActive(true);
                            d8.SetActive(false);
                            d12.SetActive(false);
                        }
                        else
                        {
                            dw8.SetActive(false);
                            dw12.SetActive(false);
                            d8.SetActive(false);
                            d12.SetActive(false);
                        }

                        if (IPA == 0 && IPS == 0 && SB == 0 && PAI == 1 && PPKN == 0 && BHS == 0 && MTK == 0)
                        {
                            dw9.SetActive(true);
                            d9.SetActive(false);
                        }
                        else
                        {
                            dw9.SetActive(false);
                            d9.SetActive(false);
                        }
                    }
                    else
                    {
                        dw1.SetActive(false);
                        dw2.SetActive(false);
                        dw5.SetActive(false);

                        d1.SetActive(false);
                        d2.SetActive(false);
                        d5.SetActive(false);
                    }
                    if (S1 == 1)
                    {
                        if (IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0 && BHS == 1 && MTK == 0)
                        {
                            dw2.SetActive(true);
                            d2.SetActive(false);
                        }
                        else
                        {
                            dw2.SetActive(false);
                            d2.SetActive(false);
                        }
                        if (BHS == 1 || MTK == 1 || IPA == 1 || IPS == 1 || SB == 1 || PPKN == 1 || PAI == 1)
                        {
                            dw1.SetActive(true);
                            dw5.SetActive(true);
                            d1.SetActive(false);
                            d5.SetActive(false);
                        }
                        else
                        {
                            dw1.SetActive(false);
                            dw5.SetActive(false);
                            d1.SetActive(false);
                            d5.SetActive(false);
                        }
                    }
                    else
                    {
                        dw1.SetActive(false);
                        dw2.SetActive(false);
                        dw5.SetActive(false);

                        d1.SetActive(false);
                        d2.SetActive(false);
                        d5.SetActive(false);
                    }
                }
            }
            if (SMP == 1)
            {
                if (MHS == 0 && S1 == 0 && PPG == 0)
                {
                    dw2.SetActive(false);

                    dw7.SetActive(false);
                    dw8.SetActive(false);
                    dw9.SetActive(false);
                    dw10.SetActive(false);
                    dw12.SetActive(false);

                    dw13.SetActive(false);
                    dw15.SetActive(false);
                    dw16.SetActive(false);
                    dw17.SetActive(false);
                    dw19.SetActive(false);
                    dw20.SetActive(false);
                }
                else
                {
                    if (MHS == 1)
                    {
                        if (BHS == 1 || MTK == 1 || IPA == 1 || IPS == 1 || SB == 1 || PPKN == 1 || PAI == 1)
                        {
                            dw19.SetActive(true);
                            dw20.SetActive(true);
                            d19.SetActive(false);
                            d20.SetActive(false);
                        }
                        else
                        {
                            dw19.SetActive(false);
                            dw20.SetActive(false);
                            d19.SetActive(false);
                            d20.SetActive(false);
                        }

                        if (IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0 && BHS == 1 && MTK == 0)
                        {
                            dw13.SetActive(true);
                            d13.SetActive(false);
                        }
                        else
                        {
                            dw13.SetActive(false);
                            d13.SetActive(false);
                        }

                        if (IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0 && BHS == 0 && MTK == 1)
                        {
                            dw15.SetActive(true);
                            dw16.SetActive(true);
                            d15.SetActive(false);
                            d16.SetActive(false);
                        }
                        else
                        {
                            dw15.SetActive(false);
                            dw16.SetActive(false);
                            d15.SetActive(false);
                            d16.SetActive(false);
                        }

                        if (IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 1 && BHS == 0 && MTK == 0)
                        {
                            dw17.SetActive(true);
                            d17.SetActive(false);
                        }
                        else
                        {
                            dw17.SetActive(false);
                            d17.SetActive(false);
                        }
                    }
                    else
                    {
                        dw13.SetActive(false);
                        dw15.SetActive(false);
                        dw16.SetActive(false);
                        dw17.SetActive(false);
                        dw19.SetActive(false);
                        dw20.SetActive(false);

                        d13.SetActive(false);
                        d15.SetActive(false);
                        d16.SetActive(false);
                        d17.SetActive(false);
                        d19.SetActive(false);
                        d20.SetActive(false);
                    }
                    if (PPG == 1)
                    {
                        if (BHS == 1 || MTK == 1 || IPA == 1 || IPS == 1 || SB == 1 || PPKN == 1 || PAI == 1)
                        {
                            dw8.SetActive(true);
                            d8.SetActive(false);
                        }
                        else
                        {
                            dw8.SetActive(false);
                            d8.SetActive(false);
                        }

                        if (BHS == 1 && MTK == 0 && IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0)
                        {
                            dw7.SetActive(true);
                            dw10.SetActive(true);
                            d7.SetActive(false);
                            d10.SetActive(false);
                        }
                        else
                        {
                            dw7.SetActive(false);
                            dw10.SetActive(false);
                            d7.SetActive(false);
                            d10.SetActive(false);
                        }

                        if (BHS == 0 && MTK == 1 && IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0)
                        {
                            dw12.SetActive(true);
                            d12.SetActive(false);
                        }
                        else
                        {
                            dw12.SetActive(false);
                            d12.SetActive(false);
                        }

                        if (BHS == 0 && MTK == 0 && IPA == 0 && IPS == 0 && SB == 0 && PAI == 1 && PPKN == 0)
                        {
                            dw9.SetActive(true);
                            d9.SetActive(false);
                        }
                        else
                        {
                            dw9.SetActive(false);
                            d9.SetActive(false);
                        }
                    }
                    else
                    {
                        dw7.SetActive(false);
                        dw8.SetActive(false);
                        dw9.SetActive(false);
                        dw10.SetActive(false);
                        dw12.SetActive(false);

                        d7.SetActive(false);
                        d8.SetActive(false);
                        d9.SetActive(false);
                        d10.SetActive(false);
                        d12.SetActive(false);
                    }
                    if (S1 == 1)
                    {
                        if (BHS == 1 && MTK == 0 && IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0)
                        {
                            dw2.SetActive(true);
                            d2.SetActive(false);
                        }
                        else
                        {
                            dw2.SetActive(false);
                            d2.SetActive(false);
                        }
                    }
                    else
                    {
                        dw2.SetActive(false);
                        d2.SetActive(false);
                    }
                }
            }
            if (SMA == 1)
            {
                if (MHS == 0 && S1 == 0 && PPG == 0)
                {
                    d1.SetActive(false);
                    d2.SetActive(false);
                    d4.SetActive(false);
                    d6.SetActive(false);

                    d8.SetActive(false);
                    d9.SetActive(false);
                    d10.SetActive(false);
                    d11.SetActive(false);

                    d17.SetActive(false);
                    d18.SetActive(false);
                    d19.SetActive(false);

                    d1.SetActive(false);
                    d2.SetActive(false);
                    d4.SetActive(false);
                    d6.SetActive(false);

                    d8.SetActive(false);
                    d9.SetActive(false);
                    d10.SetActive(false);
                    d11.SetActive(false);

                    d17.SetActive(false);
                    d18.SetActive(false);
                    d19.SetActive(false);
                }
                else
                {
                    if (S1 == 1)
                    {
                        if (BHS == 1 || MTK == 1 || IPA == 1 || IPS == 1 || SB == 1 || PPKN == 1 || PAI == 1)
                        {
                            dw1.SetActive(true);
                            d1.SetActive(false);
                        }
                        else
                        {
                            dw1.SetActive(false);
                            d1.SetActive(false);
                        }

                        if (BHS == 1 && MTK == 0 && IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0)
                        {
                            dw2.SetActive(true);
                            d2.SetActive(false);
                        }
                        else
                        {
                            dw2.SetActive(false);
                            d2.SetActive(false);
                        }

                        if ((MTK == 1 || IPA == 1) && (BHS == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0))
                        {
                            dw4.SetActive(true);
                            d4.SetActive(false);
                        }
                        else
                        {
                            dw4.SetActive(false);
                            d4.SetActive(false);
                        }

                        if (BHS == 0 && MTK == 0 && IPA == 1 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0)
                        {
                            dw6.SetActive(true);
                            d6.SetActive(false);
                        }
                        else
                        {
                            dw6.SetActive(false);
                            d6.SetActive(false);
                        }
                    }
                    else
                    {
                        dw1.SetActive(false);
                        dw2.SetActive(false);
                        dw4.SetActive(false);
                        dw6.SetActive(false);

                        d1.SetActive(false);
                        d2.SetActive(false);
                        d4.SetActive(false);
                        d6.SetActive(false);
                    }

                    if (PPG == 1)
                    {
                        if (BHS == 1 || MTK == 1 || IPA == 1 || IPS == 1 || SB == 1 || PPKN == 1 || PAI == 1)
                        {
                            dw8.SetActive(true);
                            d8.SetActive(false);
                        }
                        else
                        {
                            dw8.SetActive(false);
                            d8.SetActive(false);
                        }

                        if (BHS == 1 && MTK == 0 && IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0)
                        {
                            dw10.SetActive(true);
                            d10.SetActive(false);
                        }
                        else
                        {
                            dw10.SetActive(false);
                            d10.SetActive(false);
                        }

                        if (BHS == 0 && MTK == 0 && IPA == 0 && IPS == 0 && SB == 0 && PAI == 1 && PPKN == 0)
                        {
                            dw9.SetActive(true);
                            d9.SetActive(false);
                        }
                        else
                        {
                            dw9.SetActive(false);
                            d9.SetActive(false);
                        }

                        if (BHS == 0 && MTK == 0 && IPA == 1 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0)
                        {
                            dw11.SetActive(true);
                            d11.SetActive(false);
                        }
                        else
                        {
                            dw11.SetActive(false);
                            d11.SetActive(false);
                        }
                    }
                    else
                    {
                        dw8.SetActive(false);
                        dw9.SetActive(false);
                        dw10.SetActive(false);
                        dw11.SetActive(false);

                        d8.SetActive(false);
                        d9.SetActive(false);
                        d10.SetActive(false);
                        d11.SetActive(false);
                    }

                    if (MHS == 1)
                    {
                        if (BHS == 1 || MTK == 1 || IPA == 1 || IPS == 1 || SB == 1 || PPKN == 1 || PAI == 1)
                        {
                            dw19.SetActive(true);
                            d19.SetActive(false);
                        }
                        else
                        {
                            dw19.SetActive(false);
                            d19.SetActive(false);
                        }

                        if (BHS == 0 && MTK == 0 && IPA == 1 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 0)
                        {
                            dw18.SetActive(true);
                            d18.SetActive(false);
                        }
                        else
                        {
                            dw18.SetActive(false);
                            d18.SetActive(false);
                        }

                        if (BHS == 0 && MTK == 0 && IPA == 0 && IPS == 0 && SB == 0 && PAI == 0 && PPKN == 1)
                        {
                            dw17.SetActive(true);
                            d17.SetActive(false);
                        }
                        else
                        {
                            dw17.SetActive(false);
                            d17.SetActive(false);
                        }
                    }
                    else
                    {
                        dw17.SetActive(false);
                        dw18.SetActive(false);
                        dw19.SetActive(false);

                        d17.SetActive(false);
                        d18.SetActive(false);
                        d19.SetActive(false);
                    }
                }
            }
            step = 1;
        }

    }
    void Start()
    {
        MHS1 = 1;
        S11 = 1;
        PPG1 = 1;
        BHS1 = 1;
        MTK1 = 1;
        IPA1 = 1;
        IPS1 = 1;
        SB1 = 1;
        PAI1 = 1;
        PPKN1 = 1;

        Sig.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Log.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Pu1.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PGL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PI.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        back1.DOAnchorPos(new Vector2(0, -2500), 0.2f);
    }
    public void button_kembali()
    {
        TK = 0;
        SD = 0;
        SMP = 0;
        SMA = 0;
        MHS = 0;
        S1 = 0;
        PPG = 0;
        BHS = 0;
        MTK = 0;
        IPA = 0;
        IPS = 0;
        SB = 0;
        PAI = 0;
        PPKN = 0;
    }
    public void button_filter()
    {
        MHS = 0;
        S1 = 0;
        PPG = 0;
        BHS = 0;
        MTK = 0;
        IPA = 0;
        IPS = 0;
        SB = 0;
        PAI = 0;
        PPKN = 0;
        step = 5;
    }
    public void button_OKE()
    {
        step = 2;
    }
    public void button_Canceled()
    {
        step = 3;
    }
    // button SO
    public void Button_SO_TK(int nilai1)
    {
        TK1 = nilai1;
        MHS1 = 1;
        S11 = 1;
        PPG1 = 1;
        BHS1 = 1;
        MTK1 = 1;
        IPA1 = 1;
        IPS1 = 1;
        SB1 = 1;
        PAI1 = 1;
        PPKN1 = 1;
        step = 2;
    }
    public void Button_SO_SD(int nilai2)
    {
        SD1 = nilai2;
        MHS1 = 1;
        S11 = 1;
        PPG1 = 1;
        BHS1 = 1;
        MTK1 = 1;
        IPA1 = 1;
        IPS1 = 1;
        SB1 = 1;
        PAI1 = 1;
        PPKN1 = 1;
        step = 2;
    }
    public void Button_SO_SMP(int nilai3)
    {
        SMP1 = nilai3;
        MHS1 = 1;
        S11 = 1;
        PPG1 = 1;
        BHS1 = 1;
        MTK1 = 1;
        IPA1 = 1;
        IPS1 = 1;
        SB1 = 1;
        PAI1 = 1;
        PPKN1 = 1;
        step = 2;
    }
    public void Button_SO_SMA(int nilai4)
    {
        SMA1 = nilai4;
        MHS1 = 1;
        S11 = 1;
        PPG1 = 1;
        BHS1 = 1;
        MTK1 = 1;
        IPA1 = 1;
        IPS1 = 1;
        SB1 = 1;
        PAI1 = 1;
        PPKN1 = 1;
        step = 2;
    }

    //button TO
    public void Button_TO_Mhs(int nilaiA)
    {
        MHS1 = nilaiA; 
    }
    public void Button_TO_S1(int nilaiB)
    {
        S11 = nilaiB; 
    }
    public void Button_TO_PPG(int nilaiC)
    {
        PPG1 = nilaiC; 
    }

    //button LO
    public void Button_LO_Bhs(int nilaia)
    {
        BHS1 = nilaia; 
    }
    public void Button_LO_MTK(int nilaib)
    {
        MTK1 = nilaib;
    }
    public void Button_LO_IPA(int nilaic)
    {
        IPA1 = nilaic;
    }
    public void Button_LO_IPS(int nilaid)
    {
        IPS1 = nilaid;
    }
    public void Button_LO_SB(int nilaie)
    {
        SB1 = nilaie;
    }
    public void Button_LO_PAI(int nilaif)
    {
        PAI1 = nilaif;
    }
    public void Button_LO_PPKN(int nilaig)
    {
        PPKN1 = nilaig;
    }
    //Auth Firebase
    private void Awake()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase depencies: " + dependencyStatus);
            }
        });
    }

    private void InitializeFirebase()
    {
        Debug.Log("Setting up Firebase Auth");

        auth = FirebaseAuth.DefaultInstance;
    }

    public void LoginButton()
    {
        StartCoroutine(Login(emailLoginField.text, passwordLoginField.text));
    }

    public void RegisterButton()
    {
        StartCoroutine(Register(emailRegisterField.text, passwordRegisterField.text, passwordRegisterVerifyField.text));
    }

    private IEnumerator Login(string _email, string _password)
    {
        var LoginTask = auth.SignInWithEmailAndPasswordAsync(_email, _password);

        yield return new WaitUntil(predicate: () => LoginTask.IsCompleted);

        if (LoginTask.Exception != null)
        {
            Debug.LogWarning(message: $"Failed to register task with {LoginTask.Exception}");
            FirebaseException firebaseEx = LoginTask.Exception.GetBaseException() as FirebaseException;
            AuthError errorCode = (AuthError)firebaseEx.ErrorCode;

            string message = "Login Failed!";
            switch (errorCode)
            {
                case AuthError.MissingEmail:
                    message = "Missing Email";
                    break;
                case AuthError.MissingPassword:
                    message = "Missing Password";
                    break;
                case AuthError.WrongPassword:
                    message = "Wrong Password";
                    break;
                case AuthError.InvalidEmail:
                    message = "Invalid Email";
                    break;
                case AuthError.UserNotFound:
                    message = "Account does not exist";
                    break;
            }
            warningLoginText.text = message;
            confirmLoginText.text = "";
        }
        else
        {
            User = LoginTask.Result;
            Debug.LogFormat("User signed in successfully : {0} ({1})", User.DisplayName, User.Email);
            warningLoginText.text = "";
            confirmLoginText.text = "Logged In";
            UI_Awal();
        }
    }

    private IEnumerator Register(string _email, string _password, string _username)
    {
        if (_username == "")
        {
            warningRegisterText.text = "Missing Username";
        }
        else if (passwordRegisterField.text != passwordRegisterVerifyField.text)
        {
            warningRegisterText.text = "Password Does Not Match!";
        }
        else
        {
            var RegisterTask = auth.CreateUserWithEmailAndPasswordAsync(_email, _password);

            yield return new WaitUntil(predicate: () => RegisterTask.IsCompleted);

            if (RegisterTask.Exception != null)
            {
                Debug.LogWarning(message: $"Failed to register task with {RegisterTask.Exception}");
                FirebaseException firebaseEx = RegisterTask.Exception.GetBaseException() as FirebaseException;
                AuthError errorCode = (AuthError)firebaseEx.ErrorCode;

                string message = "Register Failed!";
                switch (errorCode)
                {
                    case AuthError.MissingEmail:
                        message = "Missing Email";
                        break;
                    case AuthError.MissingPassword:
                        message = "Missing Password";
                        break;
                    case AuthError.WeakPassword:
                        message = "Weak Password";
                        break;
                    case AuthError.EmailAlreadyInUse:
                        message = "Email Already In Use";
                        break;
                }
                warningRegisterText.text = message;
            }
            else
            {
                User = RegisterTask.Result;
                if (User != null)
                {
                    UserProfile profile = new UserProfile { DisplayName = _username };

                    var ProfileTask = User.UpdateUserProfileAsync(profile);

                    yield return new WaitUntil(predicate: () => ProfileTask.IsCompleted);
                    if (ProfileTask.Exception != null)
                    {
                        Debug.LogWarning(message: $"Failed to register task with {ProfileTask.Exception}");
                        FirebaseException firebaseEx = ProfileTask.Exception.GetBaseException() as FirebaseException;
                        AuthError errorCode = (AuthError)firebaseEx.ErrorCode;
                        warningRegisterText.text = "Username Set Failed";
                    }
                    else
                    {
                        UI_Login();
                        warningRegisterText.text = "";
                    }
                }
            }
        }
    }
    //UI Manager
    public void UI_Signup()
    {
        Sig.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Log.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Pu1.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PGL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PI.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        back1.DOAnchorPos(new Vector2(0, -2500), 0.2f);
    }
    public void UI_Login()
    {
        Sig.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Log.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Pu1.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PGL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PI.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        back1.DOAnchorPos(new Vector2(0, -2500), 0.2f);
    }
    public void UI_Awal()
    {
        Sig.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Log.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Pu1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Pu2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Pu.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PGL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PI.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        back1.DOAnchorPos(new Vector2(0, 0), 1.8f);
    }
    public void UI_LevelSekolah()
    {
        Sig.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Log.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Pu1.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PL.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PGL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PI.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        back1.DOAnchorPos(new Vector2(0, -2500), 0.2f);
    }
    public void UI_PilihGuru()
    {
        Sig.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Log.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Pu1.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PGL.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PI.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        back1.DOAnchorPos(new Vector2(0, -2500), 0.2f);
    }
    public void UI_Informasi()
    {
        Sig.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Log.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        Pu1.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu2.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        Pu.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        PL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PGL.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        PI.DOAnchorPos(new Vector2(0, 0), 1.0f);
        back1.DOAnchorPos(new Vector2(0, -2500), 0.2f);
    }
}
