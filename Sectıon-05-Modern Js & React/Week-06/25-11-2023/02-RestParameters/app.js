const calculateCircleArea = (r, pi = Math.PI) => {
    return `Circle Area: ${r * r * pi}`;
};

// console.log(calculateCircleArea(5));

const calculateCircleArea2 = (...parameters) => {
    let array = [...parameters];
    let r = array[0];
    let pi = array[1] == undefined ? Math.PI : array[3];
    return `Circle Area: ${r * r * pi}`;
};

// console.log(calculateCircleArea2(5, 3));




const getTotal = (...numbers) => {
    let numbersArray = [...numbers];
    let total = 0;
    for (let index = 0; index < numbersArray.length; index++) {
        total += numbersArray[index];

    };
    return total;
};

const basketItemsPrices=[123,542,7654,234];
console.log(getTotal(...basketItemsPrices));

// console.log(getTotal(12, 2))

