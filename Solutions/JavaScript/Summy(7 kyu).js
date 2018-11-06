function summy(stringOfInts) {
    return stringOfInts.split(" ").map(x => parseInt(x)).reduce((t, n) => t + n);
}