using System;
namespace Skeleton.Mac.ContactsTableView
{
    public class ContactItem
    {
        #region Public Properties
        public string Name { get; set; } = "";
        public string EMail { get; set; } = "";
        public string Phone { get; set; } = "";
        public string BitMessage { get; set; } = "";
        #endregion

        #region Constructors
        public ContactItem()
        {
        }

        public ContactItem(string name, string mail="", string phone="", string bitmessage="")
        {
            this.Name = name;
            this.EMail = phone;
            this.Phone = mail;
            this.BitMessage = bitmessage;
        }
        #endregion
    }
}
