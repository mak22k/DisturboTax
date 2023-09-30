// by Marisha Kulseng
// last modified 2/21/2020


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisturboTax
{
    public class TaxpayerInfo : IComparable
    {
        string /*fullName, */firstName, lastName, address, city, state, zip, ssn;
        decimal numExemptions, grossEarnings, taxWithheld, capGains, REtaxes, ExTax, MedExpense;
        // for form 2 use:
        decimal adjustedGross, taxToPay, taxLiability, penalty, taxOwed, refundOwed;

        //public TaxpayerInfo() { }
        public TaxpayerInfo(string tName, string tAdd, string tCity, string tState, string tZip, string tSSN,
            string tExemptions, string tGross, string tWithheld, string tCgains, 
            string tREtax, string tExcise, string tMExpenses)
        {
            setBothNames(parseName(tName));  // parses & sets first and last name
            address = tAdd;
            city = tCity;
            state = tState;
            zip = tZip;
            ssn = tSSN;
            numExemptions = Decimal.Parse(tExemptions);
            grossEarnings = Decimal.Parse(tGross);
            taxWithheld = Decimal.Parse(tWithheld);
            capGains = Decimal.Parse(tCgains);
            REtaxes = Decimal.Parse(tREtax);
            ExTax = Decimal.Parse(tExcise);
            MedExpense = Decimal.Parse(tMExpenses);

            adjustedGross = calcAdjGross();
            taxToPay = calcTotalTaxBurden(); // return 0 if negative?
            taxLiability =  (taxToPay >= 0m ? taxToPay : 0m);
            penalty = roundToDollar(calcPenalty());
            taxOwed = roundToDollar(calcTaxOwed());
            refundOwed = roundToDollar(calcRefundOwed());
        }

        public decimal getAdjGross() { return adjustedGross; }
        public decimal getTaxToPay() { return taxToPay; } // return 0 if negative?
        public decimal getTaxLiability() { return taxLiability; }
        public decimal getPenalty() { return penalty; }
        public decimal getTaxOwed() { return taxOwed; }
        public decimal getRefundOwed() { return refundOwed; }
        public decimal getTaxWithheld() { return taxWithheld; }
        public string getFName() { return firstName; }
        public string getLName() { return lastName; }
        public string getSSN() { return ssn; }

        int IComparable.CompareTo(object obj)
        {
            TaxpayerInfo tpayer = (TaxpayerInfo)obj;
            return String.Compare(this.ssn, tpayer.ssn);
        }



        public decimal calcRefundOwed()
        {
            return (taxWithheld > taxLiability ? taxWithheld - taxLiability : 0m);
        }



        public decimal calcTaxOwed()
        {
            return (taxWithheld < taxLiability ? (taxLiability + penalty - taxWithheld) : 0m);
        }

        public decimal calcPenalty()
        {
            if (taxLiability == 0)
                return 0m;
            else if ((taxWithheld / taxLiability) < .9m)
                return (taxLiability - taxWithheld) * 0.1m;
            else
                return 0m;
        }
        
        public decimal calcTotalTaxBurden()
        {
            // calculate all the tax for each bracket, then sum the results for tax burden
            decimal bracket1, bracket2, bracket3, bracket4, bracket5;
            bracket1 = calcTax(taxableInBounds(adjustedGross, 0m, 999.99m), .1m);
            bracket2 = calcTax(taxableInBounds(adjustedGross, 1_000m, 9_999.99m), .15m);
            bracket3 = calcTax(taxableInBounds(adjustedGross, 10_000m, 19_999.99m), .2m);
            bracket4 = calcTax(taxableInBounds(adjustedGross, 20_000m, 29_999.99m), .25m);
            bracket5 = calcTax((adjustedGross > 30_000m ? (adjustedGross - 30000m) : 0m), .28m);

            return roundToDollar(bracket1 + bracket2 + bracket3 + bracket4 + bracket5);            
        }

        public decimal taxableInBounds(decimal earnings, decimal min, decimal max)
        {
            if (earnings > max)
                return max - min;
            else if (earnings < min)
                return 0m;
            else
                return earnings - min;
        }


        public decimal calcTax(decimal earnings, decimal rate)
        {
            return earnings * rate;
        }

        public decimal calcAdjGross()
        {
            const decimal exemptionCoefficient = 1000m, physicalAssetPercentage = 0.25m, medExpensePercentage = 0.08m,
                capGainsPercentage = 0.15m;
            decimal deductedGross; // , spareChange;
            decimal exemptionDeduction = exemptionCoefficient * numExemptions;
            decimal REandExciseDeduction = (REtaxes + ExTax) * physicalAssetPercentage;// 0.25m;
            decimal medicalDeduction = MedExpense * medExpensePercentage;// 0.08m;
            // capGains assumes a negative value if losses, positive value if profits
            decimal capitalGainsCalculation = capGains * capGainsPercentage;// 0.15m;

            deductedGross = grossEarnings - exemptionDeduction - REandExciseDeduction -
                medicalDeduction + capitalGainsCalculation; // 2 negatives make a positive for capgains

            return roundToDollar(deductedGross);

        }

        public decimal roundToDollar(decimal total)
        {
            decimal spareChange = total % 1m;
            if (spareChange >= 0.50m)
                return total + (1m - spareChange);
            else
                return total - spareChange;
        }


        protected string[] parseName(string name)
        {
            char[] delim = { ' ' };
            string[] nameArr = new string[2];
            return name.Split(delim, 2, StringSplitOptions.None);
        }
        protected void setFirstName(string [] name) // can parse from full name...
        {
            this.firstName = name[0];
        }
        protected void setFirstName(string name) // or can just take a string
        {
            this.firstName = name;
        }

        protected void setLastName(string[] name) // can parse from full name...
        {
            this.lastName = name[1];
        }
        protected void setLastName(string name) // or can just take a string
        {
            this.lastName = name;
        }
        protected void setBothNames(string[] name) // can parse both names from full name...
        {
            this.firstName = name[0];
            try
            {
                this.lastName = name[1];
            }
            catch(Exception)
            {
                this.lastName = " ";
            }
        }

    }
}
