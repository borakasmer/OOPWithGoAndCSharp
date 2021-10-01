package main

type WorkProcess interface {
	NextMethod()
	BackMethod()
}

type BaseProcess struct{
	nextMethodName string
	backMethodName string
}