//0-maxNumber arasinda rasgele sayi uretir.
const randomNumbers = (maxNumber) => Math.ceil(Math.random() * (maxNumber));


export const arrayASC = array => {
    // return array.sort(compareNumericASC());
    return array.sort((a, b) => a - b);
};


export const arrayDESC = array => {
    // let result = arrayASC(array);
    // return result.reverse();
    return array.sort((a, b) => b - a)
}



const compareNumericASC = (a, b) => {
    if (a > b) return 1;
    if (a == 0) return 0;
    return -1;
}

export const getArray = count => {
    const resultArray = [];
    for (let index = 0; index < count; index++) {
        resultArray.push(randomNumbers(100));
    };
    return resultArray;
};



















// function randomNumberOld(maxNumber){
//     return Math.floor(Math.random() * (maxNumber + 1)) + 1;
// };