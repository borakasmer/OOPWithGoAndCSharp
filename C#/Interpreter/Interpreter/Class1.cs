using System;
using System.Collections.Generic;

namespace Interpreter
{
    public interface Expression
    {
        bool Interpret(string content);
    }

    public class CheckExpression : Expression
    {
        private string word;

        public CheckExpression(string _word)
        {
            this.word = _word;
        }

        public bool Interpret(string content)
        {
            return content.ToLower().Contains(word.ToLower());
        }
    }

    public class OrExpression : Expression
    {
        private Expression exp1;
        private Expression exp2;

        public OrExpression(Expression _exp1, Expression _exp2)
        {
            this.exp1 = _exp1;
            this.exp2 = _exp2;
        }
        public bool Interpret(string content)
        {
            return (exp1.Interpret(content) || exp2.Interpret(content));
        }
    }

    public class AndExpression : Expression
    {
        private Expression exp1;
        private Expression exp2;

        public AndExpression(Expression _exp1, Expression _exp2)
        {
            this.exp1 = _exp1;
            this.exp2 = _exp2;
        }
        public bool Interpret(string content)
        {
            return (exp1.Interpret(content) && exp2.Interpret(content));
        }
    }

    public class And3Expression : Expression
    {
        //çanta,ayakkabı,kuaför
        private Expression exp1;
        private Expression exp2;
        private Expression exp3;
        public And3Expression(Expression _exp1, Expression _exp2, Expression _exp3)
        {
            this.exp1 = _exp1;
            this.exp2 = _exp2;
            this.exp3 = _exp3;
        }
        public bool Interpret(string content)
        {
            return (exp1.Interpret(content) && exp2.Interpret(content) && exp3.Interpret(content));
        }
    }

    public class Or3Expression : Expression
    {
        private Expression word1;
        private Expression word2;
        private Expression word3;

        public Or3Expression(Expression _word1,Expression _word2, Expression _word3)
        {
            this.word1 = _word1;
            this.word2 = _word2;
            this.word3 = _word3;
        }

        public bool Interpret(string content)
        {
            return (word1.Interpret(content) || word2.Interpret(content) || word3.Interpret(content));
        }
    }

    public class Or2AndOneExpression : Expression
    {
        private Expression word1;
        private Expression word2;
        private Expression word3;

        public Or2AndOneExpression(Expression _word1, Expression _word2, Expression _word3)
        {
            this.word1 = _word1;
            this.word2 = _word2;
            this.word3 = _word3;
        }

        public bool Interpret(string content)
        {
            return ((word1.Interpret(content) || word2.Interpret(content)) && word3.Interpret(content));
        }
    }

    public class InterpretPattern
    {
        public static Expression getMaleExpression()
        {
            Expression futbol = new CheckExpression("futbol");
            Expression araba = new CheckExpression("araba");
            Expression sakal = new CheckExpression("sakal");
            //return new Or2AndOneExpression(futbol, araba, sakal);
            return new OrExpression(futbol, araba);

        }
        public static List<Expression> getFemailExpressions()
        {
            List<Expression> ListExpression = new List<Expression>();

            Expression anne = new CheckExpression("anne");
            Expression bebe = new CheckExpression("bebe");
            Expression sürt = new CheckExpression("sürt");
            Expression çiz = new CheckExpression("çiz");
            Expression araba = new CheckExpression("araba");
            Expression futbol = new CheckExpression("futbol");

            Expression ver = new CheckExpression("ver");
            Expression sag = new CheckExpression("sağ");
            Expression onem = new CheckExpression("önem");

            //ListExpression.Add(new And3Expression(ver, sag, onem));
            ListExpression.Add(new Or3Expression(ver, sag, onem));
            ListExpression.Add(new OrExpression(anne, bebe));
            ListExpression.Add(new AndExpression(sürt, araba));
            ListExpression.Add(new AndExpression(çiz, araba));
            ListExpression.Add(new OrExpression(anne, futbol));
            return ListExpression;
        }
    }
}
