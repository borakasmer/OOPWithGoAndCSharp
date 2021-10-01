package main

func main() {
	var mainProcess = NewProcess()
	/*mainProcess.nextMethodName = "CallCrm"
	mainProcess.backMethodName = "BackCrm"*/

	mainProcess.nextMethodName="NextKommunity"
	mainProcess.backMethodName="BackKommunity"
	mainProcess.ProcessCalculation(35, 5)
}
