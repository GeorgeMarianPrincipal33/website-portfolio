export function parseColon(value) {
    var parsedString = value.split(';')
    
    return parsedString
}


export function parseComplex(value) {
    var parsedString = value.split('|')
    var details = []

    parsedString.forEach(element => {
        const jobDetails = parseColon(element)
        details.push({
            company: jobDetails[0],
            duration: jobDetails[1],
            position: jobDetails[2],
        })
    });
    
    return details
}