import express from 'express'

const app = express();
app.listen(() => {

    let arr = [1, 2, 4, 8];
    [15, 1, 13, 7].forEach(x => {
        for (let i = 0; i < arr.length; i++) {
            if (x > arr[i] && x < arr[i+1]) {
                arr.splice(i+1, 0, x);
                break;
            }
            else if(x == arr[i]){
                arr.splice(i, 0, x);
                break
            }
            else if(x >arr[i] && !arr[i+1]){
                arr.push(x);
                break
            }
        }
    });
    console.log(arr)

})
