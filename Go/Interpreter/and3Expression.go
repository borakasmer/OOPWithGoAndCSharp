package main

type And3Expression struct {
	Exp1 Expression
	Exp2 Expression
	Exp3 Expression
}

func NewAnd3Expression(_exp1 Expression, _exp2 Expression, _exp3 Expression) *And3Expression {
	and3Expressin := new(And3Expression)
	and3Expressin.Exp1 = _exp1
	and3Expressin.Exp2 = _exp2
	and3Expressin.Exp3=_exp3
	return and3Expressin
}

func (ae *And3Expression) Interpret(content string) bool {
	return ae.Exp1.Interpret(content) && ae.Exp2.Interpret(content) && ae.Exp3.Interpret(content)
}
