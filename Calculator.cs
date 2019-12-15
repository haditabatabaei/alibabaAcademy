using System;
using System.Collections;
using System.Collections.Generic;
namespace calculator {
    public class Calculator {
        private ArrayList historyList;

        public Calculator() {
            historyList = new ArrayList();
        } 
        public double sum(double firstOperand, double secondOperand) {
            historyList.Add(new History(firstOperand , secondOperand, "sum"));
            return firstOperand + secondOperand;
        }

        public double diff(double firstOperand, double secondOperand) {
            historyList.Add(new History(firstOperand , secondOperand, "diff"));
            return firstOperand - secondOperand;
        }

        public double div(double firstOperand, double secondOperand) {
            if(secondOperand != 0) {
                historyList.Add(new History(firstOperand , secondOperand, "div"));
                return firstOperand / secondOperand;
            } else {
                Console.WriteLine("Division By Zero.");
                return 0;
            }
        }

        public double mult(double firstOperand, double secondOperand) {
            historyList.Add(new History(firstOperand , secondOperand, "mult"));
            return firstOperand * secondOperand;
        }

        public void printHistories() {
            foreach(History history in historyList) {
                history.print();
            }
        }

        public int numOfSums() {
            int numOfSums = 0;
            for(int i = 0 ; i < historyList.Count ; i++) {
                if(((History)historyList[i]).getOperatorString() == "sum") {
                    numOfSums++;
                }
            }
            return numOfSums;
        }

        public int numOfDiffs() {
            int numOfDiffs = 0;
            for(int i = 0 ; i < historyList.Count ; i++) {
                if(((History)historyList[i]).getOperatorString() == "diff") {
                    numOfDiffs++;
                }
            }
            return numOfDiffs;
        }

    }

    public class History {
        private double firstOperand;
        private double secondOperand;
        private string operatorString;

        public string getOperatorString() {
            return operatorString;
        }

        public History(double firstOperand, double secondOperand, string operatorString) {
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;
            this.operatorString = operatorString;
        }

        public void print() {
            switch(operatorString) {
                case "sum":
                    Console.WriteLine(firstOperand + " + " + secondOperand + " = " + (firstOperand + secondOperand));
                    break;
                case "diff":
                    Console.WriteLine(firstOperand + " - " + secondOperand + " = " + (firstOperand - secondOperand));
                    break;
                case "div":
                    Console.WriteLine(firstOperand + " / " + secondOperand + " = " + (firstOperand / secondOperand));
                    break;
                case "mult":
                    Console.WriteLine(firstOperand + " * " + secondOperand + " = " + (firstOperand * secondOperand));
                    break;
            }
        }
    }
} 