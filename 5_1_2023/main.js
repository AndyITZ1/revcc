function derivative(b, m) {
    return b * (m ** (b - 1))
}

function main() {
    console.log(derivative(1, 4));
    console.log(derivative(3, -2));
    console.log(derivative(4, -3));
}

main();