"use strict";
// function selamVer() {
//     console.log("Merhaba");
// }
// selamVer()


// function selamVer2(message) {
//     console.log(message);
// }
// selamVer2("Merhaba, Nasilsin? Bugun hava yagisli.")


// function today() {
//     let result = new Date();
//     return result;
// }
// let bugun = today();
// console.log(bugun);


// function calcAge(yearOfBirth) {
//     // let today=new Date();
//     // let year=today.getFullYear();
//     // let result=year-yearOfBirth;
//     // return result;
//     return new Date().getFullYear() - yearOfBirth;
// }
// console.log(calcAge(1995));

// function calcAge(yearOfBirth) {
//     let today = new Date();
//     let year = today.getFullYear();
//     let result = year - yearOfBirth;
//     return result;
// }

// function calculatePension(yearOfBirth, gender, fullName) {
//     let age = calcAge(yearOfBirth);
//     let diff = gender == "Kadin" ? 60 - age : 65 - age;
//     // let result = 'Sayin "' + fullName + '" emekli olmaniza ' + diff + ' yil kalmistir.';
//     // let result = 'Sayin \'' + fullName + '\' emekli olmaniza ' + diff + ' yil kalmistir.';
//     let result = ~
//     return result;
// }
// console.log(calculatePension(1995, "Kadin", "Sezen Aksu"))

// function calculate(short, long) {
//     let area = short * long;
//     let env = (short + long) * 2;
//     // let result=[area,env];
//     let result = { area, env };
//     return result;
// }
// console.log(calculate(4, 6));

// SORU: calistirildiginda bize "yazi" veya "Tura" seklinde bir sonuc veren fonksiyonu hazirlayiniz.

// function yaziTura() {
//     let random = (Math.random);
//     let result = random >= 0.5 ? "Yazi" : "Tura";
//     return result;
// }
// console.log(yaziTura());

//SORU: Kendisine gonderilen sayinin tam bolenlerini blup donduren fonksiyonu hazirlayiniz.

// function bolenBulma(sayi) {
//     let tamBolenArray = [];
//     for (let index = 2; index < sayi; index++) {
//         if (sayi % index == 0) {
//             tamBolenArray.push(index);
//         }
//         // if (sayi % index == 0) tamBolenArray.push(index);
//     }

// }
// console.log(bolenBulma(50));

function randomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1) + min);
}
console.log(randomInt(1, 10));