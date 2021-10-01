package main

import (
	"errors"
	"fmt"
	"reflect"
)

type Process struct {
	BaseProcess
}

func NewProcess() *Process {
	proc := new(Process)
	return proc
}

func (p *Process) NextMethod() {
	var pm ProcessMethods
	reflect.ValueOf(&pm).MethodByName(p.nextMethodName).Call([]reflect.Value{})
}

func (p *Process) BackMethod() {
	var pm ProcessMethods
	reflect.ValueOf(&pm).MethodByName(p.backMethodName).Call([]reflect.Value{})
}

func (p *Process) ProcessCalculation(num1 int,num2 int) {

	/*
			.
		    .
		    ....ToDoSomething()
	*/
	answer, err := Divided(num1, num2)
	if err != nil {
		p.BackMethod()
		return
	}
	fmt.Println("Answer : ", answer)
	p.NextMethod()
}

func Divided(num1 int, num2 int) (int, error) {
	if num2 == 0 {
		return -1, errors.New("Sıfır(0) bir sayı bölünmez")
	}
	return num1 / num2, nil
}