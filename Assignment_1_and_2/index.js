function isEvenOrOdd(number) {
  if (number % 2 === 0) {
    return "The number is even.";
  } else {
    return "The number is odd.";
  }
}

function displayResult() {
  var number = prompt("Please enter a number");
  document.getElementById("result").innerHTML = isEvenOrOdd(number);
}
