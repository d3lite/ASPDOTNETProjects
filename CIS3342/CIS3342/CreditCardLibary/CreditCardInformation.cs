using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CreditCardLibary
{
   public class CreditCardInfo
    {
        string ssn;
        string username;
        string ccnum;
        string cvvnum;
        string monthyear;
        string cardtype;
        string fname;
        string lname;
        string credbalance;
        string credlimit;
        string address;
        string city;
        string state;
        string zip;

       
        public CreditCardInfo()
        {

        }

        public CreditCardInfo(string socialsn, string uname, string crednum, string Cvvnum, string moyear, string ctype, string firstname, string lastname, string cbalance, string climit, string straddress, string billcity, string billstate, string billzip)
        {
            this.ssn = socialsn;
            this.username = uname;
            this.ccnum = crednum;
            this.cvvnum = Cvvnum;
            this.monthyear = moyear;
            this.cardtype = ctype;
            this.fname = firstname;
            this.lname = lastname;
            this.credbalance = cbalance;
            this.credlimit = climit;
            this.address = straddress;
            this.city = billcity;
            this.state = billstate;
            this.zip = billzip;


        }

        
        
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string CreditCardNumber
        {
            get { return ccnum; }
            set { ccnum = value; }
        }
        public string CVVNumber
        {
            get { return cvvnum; }
            set { cvvnum = value; }
        }
        public string MonthYear
        {
            get { return monthyear; }
            set { monthyear = value; }
        }

        public string CardType
        {
            get { return cardtype; }
            set { cardtype = value; }
        }
        
        public string FirstName
        {
            get { return fname; }
            set { fname = value; }

        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }
        public string CreditBalance
        {
            get { return credbalance; }
            set { credbalance = value; }
        }

        public string CreditLimit
        {
            get { return credlimit; }
            set { credlimit = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string ZipCode
        {
            get { return zip; }
            set { zip = value; }
        }
    
        
      
    }
}
