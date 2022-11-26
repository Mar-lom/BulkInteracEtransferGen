using System;
namespace LmiSurveyRbcBulkTransfer
{


    public class User

    {

        private string _firstName;
        private string _lastName;
        private string _email;
        private float _amountMoney;

        private string _password = "First the Letters of Alphabet";

        private string _question = "ABC";


        public string FirstName { set { _firstName = value; } }
        public string LastName { set { _lastName = value; } }


        public string FullName { get { return _firstName + " " + _lastName; } }

        public string Email { get { return _email; } set { _email = value; } }

        public int BatchReferenceNumber { get; set; }

        public DateTime CreatedDate { get; set; }


        public string AccountHolder
        {
            get
            {
                return "Anishinabek Employment and Training Services";
            }
        }

        public string UserPassword { get { return _password; } set { _password = value; } }

        public string UserQuestion { get { return _question; } set { _question = value; } }

        public float AmountMoney { get { return _amountMoney; } set { _amountMoney = value; } }


    }

}






