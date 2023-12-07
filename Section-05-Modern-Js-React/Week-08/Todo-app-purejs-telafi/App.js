"use strict"
const task = document.querySelector("#task");
const taskList = document.querySelector("#task-list");
const filters = document.querySelectorAll("#filters span");

let isEditMode = false;
let editedTaskId;
let filterMode = "all";
let taskListArray = [];


const addTask = (e) => {
    e.preventDefault();
    let addedTaskValue = task.value.trim();
    if (addedTaskValue) {
        let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
        taskListArray.push(
            {
                "id": id,
                "task": addedTaskValue,
                "status": "pending"
            });
        //buraya tum gorevleri yeniden listeleyecek fonks cagiracagiz
        setToLocalStorage();
    } else {
        alert("Please enter a task")
    }
    task.value = "";
    task.focus();
}

const getFromLocalStorage = () => {
    taskListArray = localStorage.getItem("task-list-fs-2310-13") == null ? [] : JSON.parse(localStorage.getItem("task-list-fs-2310-13"));
}

const setToLocalStorage = () => {
    localStorage.setItem("task-list-fs-2310-13", JSON.stringify(taskListArray));
}

getFromLocalStorage();
console.log(taskListArray);