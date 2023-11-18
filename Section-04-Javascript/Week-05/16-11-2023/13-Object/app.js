"use strict";
//Java Script Object Notation - JSON
// let student1 = ["Zeynep Nur", "Ay", 28, "kadin"];
// let student2 = ["Cagdas", "Tas", 28, "Erkek"];
// let student3 = ["Furkan", "Gultekin", 20, "Erkek"];
// let students = [student1, student2, student3];

// console.log(students)

// for (let i = 0; i < students.length; i++) {
//     console.log(students[i][0] + " " + students[i][2]);
// }


// let student1 = {
//     firstName: "Zeynep Nur",
//     lastName: "Ay",
//     age: 28,
//     gender: "Kadin"
// };
//yukaridaki student1 degiskeni bir objedir OBJECT firstName lastName age ve gender ise bu objenin ozellikleridir (property)

// console.log(student1.firstName + " " + student1.age);






// let student2 = {
//     firstName: "Mehmet Emir",
//     lastName: "Surmeli",
//     age: 21,
//     gender: "Erkek"
// };
// let student3 = {
//     firstName: "Didier",
//     lastName: "Drogba",
//     age: 45,
//     gender: "Erkek"
// };

// let students = [student1, student2, student3];
// let total = 0;
// let studentCount = students.length;
// for (let i = 0; i < studentCount; i++) {
//     console.log(students[i].firstName + " " + students[1].gender);
//     total += students[i].age;
// };
// let average = total / studentCount;
// console.log("Yas ortalamalari: " + average.toFixed(2));


/*

icerisinde Ahmet Mehmet ve Yesim degerlerinin oldugu bir dizi tanimlayin, Ayrica yine icerisinde insaat muhendisligi yazilim muhendisligi ve mimarlik degerlerinin oldugu bir baska dizi daha tanimlayin. sonra icinde name ve department bilgilerinin yer aldigi 3 adet student objesini su sekilde olusturun:


3 ogrenciye rasgele bolum atansin ve ornek olarak su sekilde nesneler olussun:

{
    name:"Ahmet",
    department:" yazilim muhendisligi"
}

*/

let studentsName = ["Ahmet", "Mehmet", "Yeşim", "Gokay", "Birol", "Çağdaş", "Buğra", "Emirhan", "Ayşe"];
let departments = ["İnşaat Müh.", "Yazılım Muh.", "Mimarlık", "Kimya Müh.", "Bilgisayar Müh."];
let random;
let ogrenci = {};

for (let index = 0; index < studentsName.length; index++) {
    for (let index = 0; index < studentsName.length; index++) {
        random = Math.floor(Math.random() * (departments.length));
        ogrenci[index] = { isim: studentsName[index], department: departments[random] };
    }
}
console.log(ogrenci);


