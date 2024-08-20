import express from 'express'

const app = express();
app.listen(() => {

    let arr: number[] = [1, 2, 4, 8];
    let arrayForInsert: number[] = [0];
    arrayForInsert.forEach(x => {
        arr = addToArray(arr, x)
    })
    console.log(arr);
})

function addToArray(mainArray: number[], x: number): number[] {

    if (mainArray.length == 0)
        return [];

    if (mainArray.every(y => x < y)) {
        mainArray.unshift(x);
        return mainArray ?? [];
    }

    for (let i = 0; i < mainArray.length; i++) {
        //если найден промежуток в который необходимо вставить значение
        if (x > mainArray[i] && x < mainArray[i + 1]) {
            mainArray.splice(i + 1, 0, x);
            break;
        }
        //если данные уже есть, просто добавить след. элементов
        else if (x == mainArray[i]) {
            mainArray.splice(i, 0, x);
            break;
        }
        //для добавления в конец
        else if (x > mainArray[i] && !mainArray[i + 1]) {
            mainArray.push(x);
            break;
        }
    }
    return mainArray ?? [];
}