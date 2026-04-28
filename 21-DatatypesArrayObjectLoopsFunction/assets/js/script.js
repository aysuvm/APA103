// function isPalindrome(word) {
//     let reversed = word.split('').reverse().join('');
//     return word === reversed;
// }


// console.log(isPalindrome("ana")); 
// console.log(isPalindrome("aysu")); 

// function checkNumber(n) {
//     let sum = 0;

//     for (let i = 1; i < n; i++) {
//         if (n % i === 0) {
//             sum += i;
//         }
//     }

//     if (sum > n) {
//         return "Abundant";
//     } else {
//         return "Deficient";
//     }
// }

// console.log(checkNumber(12)); 
// console.log(checkNumber(13)); 


function squareArray(arr) {
    return arr.map(x => x * x);
}


console.log(squareArray([1, 2, 3, 4])); 