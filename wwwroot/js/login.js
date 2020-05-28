document.querySelector('.login-form').addEventListener('click', passwordPeak);

function passwordPeak(event) {
    if (event.target.classList.contains('fa-eye')) {
        if (event.target.previousElementSibling.type === "password") {
            event.target.previousElementSibling.type = "text";
        } else if (event.target.previousElementSibling.type === "text") {
            event.target.previousElementSibling.type = "password";
        }
    }
}