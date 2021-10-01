package main

import (
	"strings"
)

type CheckExpression struct {
	Word string
}

func NewCheckExpression(word string) *CheckExpression {
	checkExpressin := new(CheckExpression)
	return checkExpressin
}

func (ce *CheckExpression) Interpret(content string) bool {
	return strings.Contains(strings.ToLower(content), strings.ToLower(ce.Word))
}
