window.addEventListener('load', () => {
    loader.classList.add('none');
    document.body.classList.remove('hide-scroll-bar');
});


const ul = document.querySelector('header ul');

const hamburger = document.querySelector('.hamburger-icon');

hamburger.addEventListener('click', () => {
    ul.classList.toggle('show');
    hamburger.classList.toggle('show');
});


const faq = document.querySelector('#faq');

const toggleQuestion = (event) => {

    //Bail if our clicked element doesn't have the class
    if (!event.target.classList.contains('accordion-toggle')) return;

    // Get the target content
    const content = document.querySelector(event.target.hash);
    if (!content) return;

    // Prevent default link behavior
    event.preventDefault();

    // If the content is already expanded, collapse it and quit
    if (content.classList.contains('active')) {
        content.classList.remove('active');
        return;
    }

    // Get all open accordion content, loop through it, and close it
    const accordions = document.querySelectorAll('.accordion-content.active');
    for (let i = 0; i < accordions.length; i++) {
        accordions[i].classList.remove('active');
    }

    // Toggle our content
    content.classList.toggle('active');

}
// Listen for click on the document
faq.addEventListener('click', toggleQuestion);