function handleCalculationUsingJQuery() {
    const submitButton = $('#submitButton');

    submitButton.on("click", performCalculationUsingJQuery);
}

handleCalculationUsingJQuery();

function performCalculationUsingJQuery(e) {
    const stringOne = $('#firstNumber').val();
    const numberOne = parseFloat(stringOne);

    const stringTwo = $('#secondNumber').val();
    const numberTwo = parseFloat(stringTwo);

    $('#sumLabel').text(`Their Sum is: ${numberOne + numberTwo}`);
    $('#diffLabel').text(`Their Difference is: ${numberOne - numberTwo}`);
    $('#productLabel').text(`Their Product is: ${numberOne * numberTwo}`);
    $('#divisionLabel').text(`Their Division is: ${numberOne / numberTwo}`);

    e.stopPropagation();
    e.preventDefault();
}

function handleCalculationUsingPureJavascript() {
    const submitButton = document.getElementById('submitButton');

    submitButton.addEventListener("click", performCalculationUsingPureJavascript);
}

//handleCalculationUsingPureJavascript();

function performCalculationUsingPureJavascript(e) {
    const stringOne = document.getElementById('firstNumber').value;
    const numberOne = parseFloat(stringOne);

    const stringTwo = document.getElementById('secondNumber').value;
    const numberTwo = parseFloat(stringTwo);

    document.getElementById('sumLabel').innerText = numberOne + numberTwo;
    document.getElementById('diffLabel').innerText = numberOne - numberTwo;
    document.getElementById('productLabel').innerText = numberOne * numberTwo;
    document.getElementById('divisionLabel').innerText = numberOne / numberTwo;
    
    e.stopPropagation();
    e.preventDefault();
}


//NOT USED (Works Using Prompts, alerts and the Browser Console)
function basicMathematics(){
    console.log("A program to perform mathematical computations! \n");

    const stringOne = prompt("Enter the first number: ");
    const numberOne = parseFloat(stringOne);

    const stringTwo = prompt("Enter the second number: ");
    const numberTwo = parseFloat(stringTwo);

    const sum = numberOne + numberTwo;
    let diff = numberOne - numberTwo;
    diff = Math.abs(diff);
    const product = numberOne * numberTwo;
    const div = numberOne / numberTwo;
    
    console.log("Their sum is: " + sum);
    console.log("Their difference is: " + diff);
    console.log("Their Product is: " + product);
    console.log("Their Division is: " + div);

    alert("Their sum is: " + sum);
}