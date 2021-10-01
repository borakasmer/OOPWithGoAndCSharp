package main

type Interpret interface {
	GetMaleExpression() Expression
	GetFemaleExpression() []Expression
}

type InterpretPattern struct{}

var araba = NewCheckExpression("araba")
var futbol = NewCheckExpression("futbol")

var anne = NewCheckExpression("anne")
var bebe = NewCheckExpression("bebe")
var sürt = NewCheckExpression("sürt")
var çiz = NewCheckExpression("çiz")

var spor = NewCheckExpression("spor")
var vur = NewCheckExpression("vur")

func (me *InterpretPattern) GetMaleExpression() Expression {
	return NewOrExpression(futbol, araba)
}

func (fe *InterpretPattern) GetFemaleExpression() []Expression {
	var ListExpression = make([]Expression, 0)
	var andEx1 = NewAndExpression(sürt, araba)
	var andEx2 = NewAndExpression(çiz, araba)
	var orEx1 = NewOrExpression(anne, bebe)
	var andEx3 = NewAnd3Expression(spor, araba, vur)

	ListExpression = append(ListExpression, andEx1, andEx2, orEx1, andEx3)

	return ListExpression
}
