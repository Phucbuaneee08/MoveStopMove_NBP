using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFail : UICanvas
{
    [SerializeField] Text playerCoin;
    private int coin;
    public override void Open()
    {
        base.Open();
        GameManager.Ins.ChangeState(GameState.Finish);

    }
    public void HomeButton()
    {
        UserData.Ins.coin += coin;
        UserData.Ins.SetIntData(UserData.Key_Coin, ref UserData.Ins.coin, UserData.Ins.coin);
        LevelManager.Ins.Home();
     
    }
    public void SetCoin(int coin)
    {
        this.coin = coin;
        playerCoin.text = coin.ToString();

    }
    public void X3Button()
    {
        UserData.Ins.coin += coin * 3;
        LevelManager.Ins.Home();
        UserData.Ins.SetIntData(UserData.Key_Coin, ref UserData.Ins.coin, UserData.Ins.coin);
    }
}
