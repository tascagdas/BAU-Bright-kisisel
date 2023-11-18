"use strict";
const txtTaskDescription = document.getElementById("txt-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");

let taskListArray = [
    { id: 1, taskDescription: "Netflix izle", status: "completed" },
    { id: 2, taskDescription: "Pilav yap", status: "pending" },
    { id: 3, taskDescription: "Lahana al", status: "completed" },
    { id: 4, taskDescription: "Kod calis", status: "pending" }

];



btnAddTask.addEventListener("click", function (event) {
    event.preventDefault();
    let value = txtTaskDescription.value.trim();
    if (valuea != "") {
        let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
        taskListArray.push(
            {
                id: id,
                taskDescription: value,
                status: "pending"
            }
        );
        // console.log(taskListArray);

    } else {
        alert("gecerli deger girin");
    }
    txtTaskDescription.value = "";
    txtTaskDescription.focus();
});
function displayTasks() {
    //Bu function, her ihtiyac duyuldugunda tum gorevleri yeniden okuyup gostermek icin kullanilacak.
    taskList.innerHTML = ""
    if (taskListArray.length == 0) {
        taskList.innerHTML = `    <div class="alert alert-warning mb-0">
        Tanimli gorev bulunamamistir
    </div>`
    } else{
        
    }
}
