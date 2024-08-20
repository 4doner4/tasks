import express from 'express'

const app = express();
app.listen(() => {
    let array1: number[] = [1, 2, 7, 9, 5];
    let array2: number[] = [4, 6, 8, 3];

    [array1, array2] = [
        filterAndSortArrays(array1, true),
        filterAndSortArrays(array2, false),
    ]

    console.log(array1, array2)
})
function filterAndSortArrays(arr: number[] , is_even: boolean): number[] {
    if (arr.length == 0)
        return [];
    
    if (is_even) {
        return arr?.filter(x => x % 2 !== 0)
            ?.sort((a, b) => a > b ? 1 : -1) ?? [];
    }
    return arr?.filter(x => x % 2 === 0)
        ?.sort((a, b) => a > b ? 1 : -1) ?? [];
}


