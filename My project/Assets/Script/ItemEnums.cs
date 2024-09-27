using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IItem
{
    string ItemName { get; }        //������ �̸�
    int ItemID { get; }             //������ ID
    string ItemType { get; }        //������ Ÿ��(����, ��, ����)
    string ItemEffect { get; }      //������ ȿ��
    void Use();                     //������ ��� �޼���
}

public class ItemEnums
{
    //������ Ÿ��
    public enum ItemTypes
    {
        Equip,
        Consumable
    }

    //��� ����
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

    //���� Ÿ��
    public enum WeaponTypes
    {
        Sword,      //��
        Bow,        //Ȱ
        Cane        //������
    }

    //�� Ÿ��
    public enum ArmorTypes
    {
        Robe,       //�κ�
        Plate       //�Ǳ�
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
            Debug.Log($"{ItemName}�� �����Ͽ����ϴ�");
            //������ ���� �޼ҵ� 
            //������ ���� �޼ҵ忡�� ĳ���Ϳ��� ������ �������ִ� ����� �־��ش�

        }


    }

}



