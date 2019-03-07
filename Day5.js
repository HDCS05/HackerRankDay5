function main() {
    const n = parseInt(readLine(), 10);
    for (var i = 1; i <= 10; i++){
        var multiple = n * i;
        console.log(n + " x " + i + " = " + multiple);
    }
}