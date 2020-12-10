using System;
using System.Collections.Generic;
using System.Text;

namespace task_3
{
    class PrimitiveCalculator
    {
        public event EventHandler<PrimitiveCalculatorEventArgs> Calculation;
        public char Operator { get; set; } = '+';
        public PrimitiveCalculator()
        {
        }
        public void ChangeStrategy(char @operator)
        {
            if( @operator == '+' || @operator == '-' || @operator == '*' || @operator == '/')
            {
                Operator = @operator;
            }
            else throw new Exception("Invalid operator");
        }
        public void PerformCalculation(int firstOperand, int secondOperand)
        {
            var data = new PrimitiveCalculatorEventArgs(firstOperand, secondOperand, Operator);
            OnCalculation(data);
        }

        protected virtual void OnCalculation(PrimitiveCalculatorEventArgs e)
        {
            Calculation?.Invoke(this, e);
        }
    }
}
