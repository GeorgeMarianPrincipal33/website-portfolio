function parseColon(value) {
    var newString = value.split(';');
    console.log(newString[0], newString[1], newString[2]);
}

parseColon("fafacebook;instagram;email;");


function parseComplex(value) {
    var newString = value.split('|');
    console.log(newString);
    var details = [];
    newString.forEach(element => {
        var newVal = element.split(';');
        details.push(newVal);
    });
    
    console.log(details);
}

parseComplex("Ocado;06/2018-06/2018;Frameloading|Ocado;06/2018-06/2018;Frameloading|Ocado;06/2018-06/2018;Frameloading")