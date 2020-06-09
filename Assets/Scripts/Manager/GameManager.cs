using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Get { get; private set; }
    public UnitTable m_AssetUnitTable;

    DataAssetManager m_DataManager;

    void Awake()
    {
        Get = this;
        m_DataManager = new DataAssetManager();
        m_DataManager.Init(m_AssetUnitTable);
    }

    public UnitTable.UnitStats GetUnitData(string className)
    {
        return m_DataManager.GetUnitData(className);
    }

}
