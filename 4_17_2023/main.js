function possibleBonus(a, b) {
    return (b > a) && (b - a <= 6);
}

function main() {
    console.log(possibleBonus(3, 7));
    console.log(possibleBonus(1, 9));
    console.log(possibleBonus(5, 3));
}

main();