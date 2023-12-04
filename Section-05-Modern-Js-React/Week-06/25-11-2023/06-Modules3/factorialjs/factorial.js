// kendisine verilecek sayinin faktoriyelini hesaplayan ve geri donduren bir function hazirliyoruz.

const calculateFactorial = number => {
    if (number == 0 || number == 1) return 1;
    for (let i = number - 1; i >= 1; i--) {
        number = number * i;
    };
    return number;
};

const display = () => {
    console.log("merhaba");
};

export { display };
export default calculateFactorial;