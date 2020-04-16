using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BikeRentalOpdracht.Model
{

    public class Customer : BikeRentalModel
    {
        #region Attributes

        private string _namecustomer;
        private NameGender _namegender;
        private string _id;
        private string _email;
        #endregion
        public string NameCustomer { get => _namecustomer; set { _namecustomer = value; Notify("Name"); } }
        public NameGender Gender { get => _namegender; set { _namegender = value; Notify("Gender"); } }
        public string ID { get => _id; set { _id = value; Notify("ID"); } }
        public string Email { get => _email; set { _email = value; Notify("Email"); } }
    }
    public enum NameGender
    {
        Man,
        Vrouw
    }
}