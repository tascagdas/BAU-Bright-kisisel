

//============== WHILE ==============





// let i = 0;
// while (i <= 10) {
//     console.log(i);
//     i++;
// }

// let i = 1;
// while (i <= 50) {
//     a = i % 4;

//     a == 0 ? console.log(a) : i++;
// }





// let i = 1;
// let counter = 0;
// while (i <= 50) {
//     if (i % 4 == 0) {
//         counter++;
//     }
//     i++
// }
// console.log("1 ve 50 arasindaki 4'un katlari olan sayi adedi:" + counter);






//girilecek 3 adet sayiyi toplayip konsola yazidrma ornegi

// let i = 1;
// let num;
// let total = 0;
// while (i <= 3) {
//     num = Number(prompt("lutfen sayiyi giriniz:"));
//     // total = total + num;
//     total += num;




//     i++;

// }
// console.log(total)

//kulklanicinin istedigi kadar sayi girmesine izin veren ve girilen sayilari tpolayip konsola yazan kodu yaziniz
//not kullanici 0 girerse uygulama sona ersin.

// let i = 1;
// let total = 0;
// let num;
// while (true) {
//     num = Number(prompt("lutfen bir sayi giriniz:"));
//     if (num == 0) {
//         break;
//     }
//     total += num;
// }
// console.log("toplam: " + total);


//kulklanicinin istedigi kadar sayi girmesine izin veren ve girilen sayilari tpolayip konsola yazan kodu yaziniz
//not kullanici exit yazarsa uygulama sona ersin.


// let i = 1;
// let total = 0;
// let num;
// while (true) {
//     num = prompt("lutfen bir sayi giriniz:  (cikmak icin 'exit'");
//     if (num.toLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
// }
// console.log("toplam: " + total);








// let i = 1;
// let total = 0;
// let num;
// while (true) {
//     num = prompt("lutfen " + i + ". sayiyi giriniz:  (cikmak icin 'exit'");
//     if (num.toLowerCase() == "exit") {
//         break;
//     }
//     total += Number(num);
//     i++;
// }
// i--;
// console.log("girdiginiz " + i + " adet sayinin toplami: " + total + "dir.");










// let count = Number(prompt("lutfen bir sayi giriniz: "));
// for (let i = 1; i <= count; i++) {
//     console.log(i);
// }




// 1 ile 10 arasindaki cift sayilari konsolda yazdirin.
// for (let index = 0; index < 10; index += 2) {
//     if (index % 2 == 0) {
//         continue;
//     }
//     console.log(index)

// }



//kulklanicinin istedigi kadar sayi girmesine izin veren ve girilen sayilari tpolayip konsola yazan kodu yaziniz
//not kullanici exit yazarsa uygulama sona ersin. not2 for kullanin

// let total = 0;
// let num;
// for (let i = 0; i == 0;) {
//     num = prompt("lutfen bir sayi giriniz");
//     if (num.toLocaleLowerCase() == "exit") {
//         break;
//     };
//     total += Number(num);

// }
// console.log(total);

for (let index = 0; index < 20; index++) {
    if (index % 2 == 0) {
        console.log(index + " cift sayidir")
    }
    else {
        console.log(index + " tek sayidir.")
    }


}