package main

type Expression interface{
	Interpret(content string) bool
}

