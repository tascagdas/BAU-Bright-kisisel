// let numbers = [4, 9, 14, 20, 19];
// let evenNumbers = numbers.map(nextNumber => {
//     if (nextNumber % 2 == 0) return nextNumber;
// });
// console.log(numbers);
// console.log(evenNumbers);


let prices = [50, 100, 200, 250];
let newPrices = prices.map(nextprice => {
    return nextprice * 1.2;
});

console.log(prices);
console.log(newPrices);