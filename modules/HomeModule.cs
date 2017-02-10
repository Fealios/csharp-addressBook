using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ =>
      {
        return View["index.cshtml", Contact.GetList()];
      };

      Get["/contact/{id}"] = parameter =>
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact SelectedContact = Contact.Find(parameter.id);
        return View["contact.cshtml", model];
      };

      Get["/contact/new"] = _ =>
      {
        return View["newcontact.cshtml"];
      };

      Post["/contact/new"] = _ =>
      {
        Contact newContact = new Contact(Request.Form["name"], Request.Form["phone"], Request.Form["address"]);
        Contact.GetList().Add(newContact);
        return View["index.cshtml", Contact.GetList()];
      };
    }
  }
}