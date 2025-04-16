using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;
public class GameManager : Singleton<GameManager>
{
    //public delegate int MoneyChange();
    //public static event MoneyChange OnMoneyChanged;
    public UnityEvent<int> OnMoneyChanged;
    private int _money;
    public int _Money
    {
        get => _money;
        //get
        //{
        //    return _money;
        //}

        set
        {
            //Money += 123
            //value = 123
            _money += value;
            //_money += value;
            OnMoneyChanged?.Invoke(_money);
        }
    }

    [ContextMenu("Debug Money")]
    public void DebugCurrentMoney()
    {
        Debug.Log($"Current money is {_money}");
    }
    }