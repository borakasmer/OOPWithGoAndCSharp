package main

type OrExpression struct {
	Exp1 Expression
	Exp2 Expression
}

func NewOrExpression(_exp1 Expression, _exp2 Expression) *OrExpression {
	oe := new(OrExpression)
	oe.Exp1 = _exp1
	oe.Exp2 = _exp2
	return oe
}

func (oe *OrExpression) Interpret(content string) bool {
	return oe.Exp1.Interpret(content) || oe.Exp2.Interpret(content)
}
