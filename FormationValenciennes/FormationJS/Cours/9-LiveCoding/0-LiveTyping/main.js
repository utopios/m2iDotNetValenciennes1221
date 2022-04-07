const input = document.querySelector('input');
const result = document.querySelector('.result');

input.addEventListener('keyup',()=>{
    result.innerHTML = input.value;
})