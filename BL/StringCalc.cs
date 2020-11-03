using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e4_StringCalculator.BL
{
    public class Results
    {
        public string Messages { get; set; }
        public int FinalResult { get; set; }
    }

    public class StringCalc
    { 
        //Manipulate and fix string
        public Results CalculateString(string strOriginal)
        {
            Results CalculationResults = new Results();

            string messages = "";
            string strNewLine = "";
            char DelimeterChar = Convert.ToChar(",");
            string calcStr = strOriginal;

            //Check if delimiter should change
            if (calcStr.Substring(0, 2) == "//")
            {
                //Set the delimiter
                //Can only set to char so single character
                //Have tried it with multipe characters
                DelimeterChar = Convert.ToChar(calcStr.Substring(2, 1));
            }

            //try and get rid of breaks with reg expression
            calcStr = System.Text.RegularExpressions.Regex.Replace(calcStr, "(?<Text>.*)(?:[\r\n]?(?:\r\n)?)", "${Text}\r\n");
            //now replace line breaks old fashion way
            calcStr = calcStr.Replace(System.Environment.NewLine, DelimeterChar.ToString());
            //trimming ends just in case
            calcStr = calcStr.Trim();
            //Show new string results that will be splitted after all replacements
            messages += Environment.NewLine + "String after replacing new line : " + Environment.NewLine + calcStr + Environment.NewLine;



            //split initial string into rray
            string[] splittedArray = calcStr.Split(DelimeterChar);
            string[] splittedVersion1 = new string[splittedArray.Count()];
            int iinitialCount = splittedArray.Count();
            for (int i = 0; i < iinitialCount; i++)
            {
                if (splittedArray[i] != "")
                {
                    //set values in new array to get rid of emty vars
                    splittedVersion1.SetValue(splittedArray[i], i);
                }
            }

            //set counting variables
            Int32[] NrArray1 = new Int32[iinitialCount];
            int intCounter1 = 0;
            string negativenumbers = "";
            string nonIntegrs = "";


            //loop through array
            for (int i = 0; i < splittedVersion1.Count(); i++)
            {
                //make sure an array is not null, throw it out
                if (splittedVersion1[i] != null)
                {
                    //make sure array value is trimmed
                    if (splittedVersion1[i].Trim() != "")
                    {
                        //Make sure we use integers
                        int value;
                        if (int.TryParse(splittedVersion1[i], out value))
                        {
                            //Make sure we do not use negative values
                            if (Convert.ToInt32(splittedVersion1[i]) >= 0)
                            {
                                
                                    //Final string with delimter
                                    if (i < iinitialCount) 
                                    {
                                        intCounter1++;
                                        if (strNewLine != "")
                                        {
                                            strNewLine += DelimeterChar;
                                        }
                                    }
                                    intCounter1++;
                                    strNewLine += splittedVersion1[i];
                                
                            }
                            else
                            {
                                //store negative values for statistic
                                if (negativenumbers != "") { negativenumbers += ","; }
                                negativenumbers += splittedVersion1[i];
                            }
                        }
                        else
                        {
                            //store nonintegers values for statistic
                            if (nonIntegrs != "") { nonIntegrs += ","; };
                            nonIntegrs += splittedVersion1[i];
                        }
                    }
                }
            }

            //Show statistics
            if (nonIntegrs != "")
            {
                messages += Environment.NewLine + "The following non-integers were found : " + Environment.NewLine + nonIntegrs;
            }
            if (negativenumbers != "")
            {
                messages += Environment.NewLine + Environment.NewLine + "The following negatives were found : " + Environment.NewLine + negativenumbers;
            }
            //Show new string that should contained delimted integers only
            if (strNewLine != "")
            {
                messages += Environment.NewLine + Environment.NewLine + "NEW STRING : " + strNewLine + Environment.NewLine;
            }
            int intFinalResult = Add(strNewLine, DelimeterChar);
            messages += Environment.NewLine + "____________________________";
            messages += Environment.NewLine + "FINAL RESULT! : " + intFinalResult.ToString();
            messages += Environment.NewLine + "____________________________";

            CalculationResults.FinalResult = intFinalResult;
            CalculationResults.Messages = messages;
            return CalculationResults;
        }

        //calculate final result after cleaning string
        public int Add(string strClean, char strDelimiter)
        {
            string[] splitVariables = strClean.Split(strDelimiter);
            int intAddTotals = 0;
            //loop split
            for (int i = 0; i < splitVariables.Count(); i++)
            {
                //just make sure it is not empty
                if (splitVariables[i] != "")
                {
                    //plus integers
                    intAddTotals += Convert.ToInt32(splitVariables[i]);
                }
            }
            return intAddTotals;
        }
    }
}
