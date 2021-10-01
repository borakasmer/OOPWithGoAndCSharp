package main

type AndExpression struct {
	Exp1 Expression
	Exp2 Expression
}

func NewAndExpression(_exp1 Expression, _exp2 Expression) *AndExpression {
	andExpressin := new(AndExpression)
	andExpressin.Exp1 = _exp1
	andExpressin.Exp2 = _exp2
	return andExpressin
}

func (ae *AndExpression) Interpret(content string) bool {
	return ae.Exp1.Interpret(content) && ae.Exp2.Interpret(content)
}
