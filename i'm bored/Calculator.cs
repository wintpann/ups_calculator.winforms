using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_m_bored
{
    static class Calculator
    {
        public static decimal Calculate(decimal firstNum, decimal secondNum, char operationMark)
        {
            switch (operationMark)
            {
                case '-':
                    return firstNum - secondNum;
                case '+':
                    return firstNum + secondNum;
                case 'x':
                    return firstNum * secondNum;
                case '/':
                    if (secondNum == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return firstNum / secondNum;
                    }
                default:
                    return 0;
            }
        }
    }
}
