// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function palindrome(inputText) {
    var lower = inputText.toLowerCase();
    var reverse = lower.split('').reverse().join('');
    return reverse === lower;
}

function palindromes() {
    var input = document.getElementById("palindromes-input").value.toLowerCase();
    var list = document.getElementById("item-list");
    var results = [];
    list.innerHTML = "";

    console.log(input.length)

    for (var i = 3; i < input.length; i++) {

        for (var length = 0; length <= input.length; length++) {
            var sliced = input.substr(length, i);
            if (palindrome(sliced) && !results.includes(sliced) && sliced.length >= 3) {
                results.push(sliced)
                var element = document.createElement("li");
                element.innerHTML = sliced;
                list.appendChild(element);
            }
        }
    }
}