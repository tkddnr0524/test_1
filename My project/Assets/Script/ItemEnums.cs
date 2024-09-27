using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IItem
{
    string ItemName { get; }        //아이템 이름
    int ItemID { get; }             //아이템 ID
    string ItemType { get; }        //아이템 타입(무기, 방어구, 포션)
    string ItemEffect { get; }      //아이템 효과
    void Use();                     //아이템 사용 메서드
}

public class ItemEnums
{
    //아이템 타입
    public enum ItemTypes
    {
        Equip,
        Consumable
    }

    //장비 부위
    public enum EquipParts
    {
        Head,
        Chest,
        Pants,
        Boots,
        Weapons,
        Shield,
        Accessory
    }

    //무기 타입
    public enum WeaponTypes
    {
        Sword,      //검
        Bow,        //활
        Cane        //지팡이
    }

    //방어구 타입
    public enum ArmorTypes
    {
        Robe,       //로브
        Plate       //판금
    }

    public class Weapon : IItem
    {
        public string ItemName { get; private set; }
        public int ItemID { get; private set; }
        public string ItemType { get; private set; }
        public string ItemEffect { get; private set; }
        public string ItemAffixes { get; private set; } 
        public WeaponTypes WeaponType { get; private set; }
        public EquipParts EquipPart { get; private set; }

        public Weapon(string name, int id, string itemtype, string effect, string affixes, WeaponTypes weaponType, EquipParts equipPart)
        {
            ItemName = name;
            ItemID = id;
            ItemType = itemtype;
            ItemAffixes = affixes;
            ItemEffect = effect;
            WeaponType = weaponType;
            EquipPart = equipPart;
        }

        public void Use()
        {
            Debug.Log($"{ItemName}을 장착하였습니다");
            //아이템 장착 메소드 
            //아이템 장착 메소드에는 캐릭터에게 스탯을 이전해주는 기능을 넣어준다

        }


    }

}



