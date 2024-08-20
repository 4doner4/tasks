import express from 'express'

const app = express();
app.listen(() => {
    let array1 = [1, 2, 7, 9, 5]
    let array2 = [4, 6, 8, 3]
    array1 = array1.filter(x => x % 2 !== 0);
    array2 = array2.filter(x => x % 2 === 0);
    console.log(array1,array2)
})



