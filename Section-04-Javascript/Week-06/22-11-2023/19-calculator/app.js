const display = document.querySelector(".calculator-input");
const keys = document.querySelector(".calculator-keys");
console.log(display, keys);

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
    waitingForSecondValue = true;

}

function inputNumber(num) {
    if (!waitingForSecondValue) {
        displayValue = displayValue == "0" ? num : displayValue + num;

    } else {
        displayValue = num;

    }

}
updateDisplay();