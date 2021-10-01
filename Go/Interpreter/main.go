package main

import "fmt"

func main() {
	Description1 := "Futbol maçlarını çok sevsem de, genelde izlemiyorum"
	Description2 := "Bebeğimin sağlığı için anne sütüne çok önem veriyorum."
	Description3 := "Spor'a giderken arabayı vurdum."

	interPattern := InterpretPattern{}
	fmt.Print(Description1 + " (Erkek):")
	fmt.Println(interPattern.GetMaleExpression().Interpret(Description1))

	var expResult = false
	fmt.Print(Description2 + " (Bayan):")
	for _, exp := range interPattern.GetFemaleExpression() {
		if exp.Interpret(Description2) {
			expResult = true
			break
		}
	}
	fmt.Println(expResult)

	var expResult2 = false
	fmt.Print(Description3 + " (Bayan):")
	for _, exp := range interPattern.GetFemaleExpression() {
		if exp.Interpret(Description3) {
			expResult2 = true
			break
		}
	}
	fmt.Println(expResult2)
}
