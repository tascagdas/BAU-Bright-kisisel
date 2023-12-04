// function getRandomNumber(min, max) {
//     return Math.floor(Math.random() * (max - min + 1)) + min;
// }

// export function generateRandomNumbers(count, min, max) {
//     let randomNumbers = [];
//     for (let i = 0; i < count; i++) {
//         randomNumbers.push(getRandomNumber(min, max));
//     }
//     return randomNumbers;
// }

// export const randomNumbers = generateRandomNumbers(10, 1, 100);

// console.log(randomNumbers);






//====================================================

export const getResult = () => {
    let number;
    const oddNumbers = [];
    const evenNumbers = [];
    const allNumbers = [];
    for (let i = 0; i < 10; i++) {
        number = Math.ceil(Math.random() * 100);
        allNumbers.push(number);
        if (number % 2 == 0) {
            evenNumbers.push(number);
        } else {
            oddNumbers.push(number);
        };

    };
    let result = {
        all: allNumbers,
        odds: oddNumbers,
        evens: evenNumbers
    };
    return result;
};






// export const randomNumbers = () => {
//     const result = [];
//     for (let i = 0; i < 10; i++) {
//         result.push(Math.ceil(Math.random() * 100));
//     };
//     return result;
// };

// export const getOddNumbers = (numbers) => {
//     const result = [];
//     // for (let index = 0; index < numbers.length; index++) {}
//     for (const i in numbers) {
//         // if (numbers[i] % 2 == 0) result.push(numbers[i]);
//         if (numbers[i] % 2 != 0) {
//             result.push(numbers[i]);
//         };
//     };
//     return result;
// };


// export const getEvenNumbers = (numbers) => {
//     const result = [];
//     for (const nextNumber of numbers) {
//         if (nextNumber % 2 == 0) {
//             result.push(nextNumber);
//         };
//     };
//     return result;
// };
