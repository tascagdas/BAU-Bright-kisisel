// let a = 20;

// if (a > 10) {
//     console.log("sayi 10dan buyuk");
// }else {
//     console.log("sayi 10dan kucuk");
// };

// let a = 150;

// if (a > 10) {
//     console.log("sayi 10dan buyuk");
// } else if(a<10) {
//     console.log("sayi 10dan kucuk");
// } else{
//     console.log("sayi 10'a esit")
// }

// let a = 10;
// if (a > 10) {
//     console.log("buyuk");
// };
// if (a < 10) {
//     console.log("kucuk");
// };
// if (a == 10) {
//     console.log("esit")
// }

/*
    0-16 arasindaysa cocuk
    17-35 arasinda genc
    36-50 arasi yasli
    51-70 olmus aglayani yok
    71den buyukse no comment
*/
// let age = 72;

// if (age<=16) {
//     console.log("cocuk");
// }else if(age<=35) {
//     console.log("genc");
// }else if(age<=50){
//     console.log("yasli");
// }else if(age<=70){
//     console.log("ölmüs aglayani yok");
// }else{
//     console.log("nocomment")
// }



//Ternary if operatoru (uclu operator)
// let message;
// let age = 35;

// if (age >= 18) {
//     message = "girebilirsin";
// } else {
//     message = "giremezsin";
// }
// message = age >= 18 ? "girebilirsin" : "giremezsin"
// console.log("yasin " + age + " oldugu icin " + message);

//ternary if cozumu



// let age = 200;
// let result;
// result = age <= 16 ? "cocuk" :
//     age <= 35 ? "genc" :
//         age <= 50 ? "yasli" :
//             age <= 70 ? "olmus aglayani yok" : "no comment";
// console.log(result)

// let message = "merhaba";
// alert(message)


// let age;
// age = prompt("Kac yasindasiniz?");
// console.log(age + " yasindasiniz");
// console.log(typeof age);

// result=confirm("emin misiniz?");

// let a = 40;
// let b = 60;
// let result;
// result = (a - b) < 30 ? "kucuk" : "buyuk";
// console.log(result);



let trueAnswer = "ECMAscript";

answer = prompt("JavaScript'in official ismi nedir?");
// if (trueAnswer == answer) {
//     console.log("Tebrikler")
// } else {
//     console.log("Yanlis cevap")
// }
result = trueAnswer == answer ? "tebrikler" : "yanlis cevap";
alert(result)