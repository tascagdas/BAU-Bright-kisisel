"use strict";
/*
    Document Object Model -- DOM
*/

// Single element
// let result;
// result = document.getElementById("task-list");

// result = document.getElementById("title");
// result.style.backgroundColor="red";
// result.style.color="white";
// result.style.padding="10px";
// // result.innerText="Fullstack Programlama"
// result.innerHTML="<span style='color:yellow> Full Stack</span> Programlama";


// result=document.querySelector("#title");
// result=document.querySelector(".card-title");
// result=document.querySelector("li")


// console.log(result);

// MULTI Elements

//get Elements By Class Name

// let result;
// result=document.getElementsByClassName("card-title");
// result=document.querySelectorAll("li");
// result=document.getElementsByClassName("task");
// result=document.getElementsByTagName("li");
// result=document.querySelectorAll('#task-list-2 li')
// console.log(result);

// arastirma odevi HTMLCollection ile NodeList arasindaki fark ve benzerlikleri arastir.

//Traversing Elements

let result;
// let taskList = document.getElementById("task-list");
// result = taskList.children;
// console.log(taskList);

// let body= document.querySelector("body");
// console.log(body);
// result=body.children;
// result=body.children[0];
// result=body.firstElementChild;
// result=body.lastElementChild;

result = document.getElementById("title");
result = result.parentElement;
result = result.nextElementSibling.nextElementSibling.previousElementSibling;


console.log(result);