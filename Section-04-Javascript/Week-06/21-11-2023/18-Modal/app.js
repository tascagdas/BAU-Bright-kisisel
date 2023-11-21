const btnOpenModal = document.getElementById("btn-open-modal");
const mainModal = document.querySelector(".main-modal");
const btnCrossModal = document.querySelector(".btn-cross-modal");
const btnCloseModal = document.querySelector(".btn-close-modal");

btnOpenModal.addEventListener("click", function () {
    mainModal.classList.remove("main-modal-none");
});

btnCrossModal.addEventListener("click", closeModal);
btnCloseModal.addEventListener("click", closeModal);
mainModal.addEventListener("click", function (event) {
    // if (event.target.className == "main-modal") {
    //     closeModal();
    // };
    if (event.target.classList.contains("main-modal")) {
        closeModal();
    };
});


function closeModal() {
    mainModal.classList.add("main-modal-none");
};

