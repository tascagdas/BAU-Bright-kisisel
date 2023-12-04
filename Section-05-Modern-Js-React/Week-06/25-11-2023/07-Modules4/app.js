/* 

-rasgele uretilecek 1-100 arasindaki 10 adet sayiyi kullanarak bir dizi olusturun.

-bu olusturulan dizi icerisindeki tek sayilari tespit edip donduren bir function

-bu olusturulan dizi icerisindeki cift sayilari tespit edip donduren bir function

-iceren bir module dosyasi hazirlayip, app.js iceronde kullanin.


*/



import { getResult } from "./core.js";
let result = getResult();
console.log(`Orjinal Hali: ${result.all}`);
console.log(`Tek Sayilar: ${result.odds}`);
console.log(`Cift Sayilar: ${result.evens}`);





// import { randomNumbers, getOddNumbers, getEvenNumbers } from "./core.js";
// const numbers = randomNumbers();
// const oddNumbers = getOddNumbers(numbers);
// const evenNumbers = getEvenNumbers(numbers);


// console.log(`Dizinin orjinal hali: ${numbers}`);
// console.log(`Dizideki tek sayilar: ${oddNumbers}`);
// console.log(`Dizideki cift sayilar: ${evenNumbers}`);

