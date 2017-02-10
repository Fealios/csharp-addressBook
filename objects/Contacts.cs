using System.Collections.Generic;
// Imports System.Text.RegularExpressions;


namespace AddressBook.Objects
{
  public class Contact
  {
    // public static int counter = 0;
    private string _name;
    private string _phone;
    private string _address;
    private int _id;
    private static List<Contact> contactList = new List<Contact>{};

    public Contact(string name, string phone, string address)
    {
      SetName(name);
      SetPhone(phone);
      SetAddress(address);
      _id = GetList().Count;
      // _id = counter;
      // counter++;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetPhone(string phone)
    {
      _phone = phone;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public void SetAddress(string address)
    {
      _address = address;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetId(int id)
    {
      _id = id;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetList()
    {
      return contactList;
    }

    public static Contact Find(int id)
    {
      return contactList[id];
    }

    public static void ClearList()
    {
      contactList.Clear();
    }

    //     public static string searchItem;
    //
    // public static void SetSearchItem(string term)
    //     {
    //         searchItem = "/";
    //     }
    //
    // public static List<Contact> searchResults = new List<Contact> { };
    //
    //     RegexOptions options = RegexOptions.IgnoreCase;
    //
    // public static Contact Search(string searchTerm){
    //   foreach (var Contact in contactList)
    //         {
    //             if (Regex.IsMatch(Contact.GetName(), searchTerm))
    //             {
    //                 searchResults.Add(Contact);
    //             }
    //         }
    // }

  }
}
