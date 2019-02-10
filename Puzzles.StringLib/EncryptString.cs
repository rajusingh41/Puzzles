using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.StringLib
{
    public class EncryptString
    {

        public string Encrypt(string phrase)
        {
            if(string.IsNullOrEmpty(phrase))
            {
                throw new ArgumentNullException(nameof(phrase));
            }

          var  alphabetArry = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            StringBuilder restul= new StringBuilder();
            var _phraseArray =  phrase.Split(' ');
            for(int i =0;i<_phraseArray.Length;i++)
            {
                var reversString = string.Empty;
                var stringLength = 0;
                stringLength = _phraseArray[i].Length - 1;
                while(stringLength>=0)
                {
                    reversString = reversString + _phraseArray[i][stringLength];
                    stringLength--;
                }

                StringBuilder encString = new StringBuilder();
                for(int j = 0; j<reversString.Length;j++)
                {
                    if(j==0)
                    {
                        encString.Append(reversString[j]);
                    }
                    else
                    {
                        for(int k =0;k<alphabetArry.Length;k++)
                        {
                            if(reversString[j]==alphabetArry[k])
                            {
                                var next = k + j;
                                encString.Append(alphabetArry[next]);
                            }
                        }
                    }
                }

                restul = restul.Length == 0 ? restul.Append(encString) : restul.Append(" " + encString);

            }

            return restul.ToString();
        }

        
    }
}
