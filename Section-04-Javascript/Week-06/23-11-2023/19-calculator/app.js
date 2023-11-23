const display = document.querySelector(".calculator-input");
const keys = document.querySelector(".calculator-keys");


let displayValue = "0";
let waitingForSecondValue = false;
let previousValue = null;
let operator = null;

function updateDisplay() {
    display.value = displayValue;

};
keys.addEventListener("click", function (e) {
    const element = e.target;
    const value = element.value;
    if (!element.matches("button")) return;
    switch (value) {
        case "+":
        case "-":
        case "*":
        case "/":
        case "=":
            handleOperator(value);
            break;
        case ".":
            inputDecimal();
            break;

        case "clear":
            clearDisplay()
            break;
        default:
            inputNumber(value);
            break;
    };
    updateDisplay();
});

function handleOperator(nextOperator) {
    let value = parseFloat(displayValue);

    if (operator == null && waitingForSecondValue == true) {
        operator = nextOperator;

        return;
    }
    if (previousValue == null) {
        previousValue = value;
    } else {
        const result = calculate(previousValue, operator, value);
        displayValue = result.toString();
        previousValue = result;
    }
    operator = nextOperator;
    waitingForSecondValue = true;

}

function calculate(firstNumber, op, secondNumber) {
    switch (op) {
        case "+":
            return firstNumber + secondNumber;
        case "-":
            return firstNumber - secondNumber;
        case "*":
            return firstNumber * secondNumber;
        case "/":
            return firstNumber / secondNumber;
            default:
                
    }
}

function inputDecimal() {
    if (displayValue.indexOf(".") == -1) {
        displayValue += ".";
    }
};
function clearDisplay() {
    displayValue = "0";
    waitingForSecondValue = false;
    previousValue = null;
    operator = null;
}

function inputNumber(num) {
    if (!waitingForSecondValue) {
        displayValue = displayValue == "0" ? num : displayValue + num;

    } else {
        displayValue = num;
        waitingForSecondValue = false;
    }

}
updateDisplay();