function displayType(values) {
    if (typeof (values) === "number")
        console.log('values is number.');
    else if (typeof (values) === "string")
        console.log('values is string.');
}
displayType(49);
displayType("BALL");
