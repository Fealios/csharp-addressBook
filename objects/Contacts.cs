using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;

    public Contact(string name, string phone, string address)
    {
      SetName(name);
      SetPhone(phone);
      SetAddress(address);
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

    }

    public string GetAddress()
    {
      return _address;
    }

    
  }
}
