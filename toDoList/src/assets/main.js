import '@assets/css/style.css';

document.querySelector('form').addEventListener('submit', (x) => {
    x.preventDefault();
    const input = x.target.querySelector('input')
    const value = input.value.trim();
    if(!value) return;
    const template = document.getElementById('todo-template').content.cloneNode(true);
    const li = template.querySelector('li');
    const span = li.querySelector('span');
    span.textContent = value;
    li.querySelector('.delete').addEventListener('click', () => li.remove());
    li.querySelector('.ok').addEventListener('click', () => {
        span.classList.add('text-green-500');
        span.textContent += ' ✅';
    });
    document.querySelector('ul').appendChild(li);
    input.value = '';
});