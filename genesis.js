
// Q.2

function removeZeroes (num) {
    console.log(num);
    return parseFloat(num);
}

function test_removeZeroes() {
    
    let nums = [
        "5.0",
        "0005",
        "5.05",
        "5.05000",
        "005.0505000"
    ];

    for (let index = 0; index < nums.length; index++) {
        
        console.log(removeZeroes(nums[index]));
        
    }

}

// Q.4

let boatLaunch = false;
let gasLevel = 700;
let crewmateStatus = true;
let instrumentStatus = "green";

if (gasLevel >= 1000) {
    console.log("Gas level is good.");
    boatLaunch = true;
} else {
    console.log("WARNING: Not enough gas!");
    boatLaunch = false;
}

if (crewmateStatus && instrumentStatus === "green") {
    console.log("Crewmates and instruments are good");
    boatLaunch = true;
} else {
    console.log("WARNING: Crewmates or instruments are not good");
    boatLaunch = false;
}

if (boatLaunch) {
    console.log("Ready! Set! Go!");
    console.log("Bon voyage!");
} else {
    console.log("Nope not ready!");
}

// Q.5

function getSampleWeatherMap() {

    var xhr = new XMLHttpRequest();

    xhr.onreadystatechange = function() {
        if (xhr.readyState == XMLHttpRequest.DONE) {
            // alert(xhr.responseText);
            document.getElementById("dvGetResponse").innerHTML = xhr.responseText;
        }
    }

    xhr.open('GET', 'https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=439d4b804bc818953eb36d2a8c26a02', true);
    
    xhttp.setRequestHeader('Content-Type', 'application/x-www-form-urlencode');
    
    xhr.send(null);
}