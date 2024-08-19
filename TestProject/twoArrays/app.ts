import express from 'express'


const app = express();
app.listen(() => {

    // let arr = [1, 2, 4, 8];
    // [3, 4, 6, 7].forEach(x => {
    //     for (let i = 0; i < arr.length; i++) {
    //         if (x > arr[i] && x < arr[i+1]) {
    //             arr.splice(i+1, 0, x);
    //             break;
    //         }
    //     }
    // });
    // console.log(arr)
    let array1 = [1, 2, 7, 9, 5]
    let array2 = [4, 6, 8, 3]
    array1 = array1.filter(x => x % 2 !== 0);
    array2 = array2.filter(x => x % 2 === 0);
    console.log(array1,array2)
})

// const host = 'localhost';
// const port = 8080;

// const server = http.createServer(function (req: any, res: { setHeader: (arg0: string, arg1: string) => void; writeHead: (arg0: number) => void; end: (arg0: Buffer) => void; }) {
//     fs.readFile(__dirname + "/pages/index.html")
//         .then(contents => {
//             res.setHeader("Content-Type", "text/html");
//             res.writeHead(200); // success status code
//             res.end(contents);
//         })
//         .catch(err => {
//             res.writeHead(500);
//             res.end(err);
//             return;
//         });
// });

// server.listen(port, host, function () {
//     console.log(`Server is running on http://${host}:${port}`);
// });

// app.use(express.json(
//     { "limit": "100mb" }
// ))

// app.get("/api/health", function (req, res) {
//     res.end("Service workng!");
// });

// app.get("/api/amoCRM/getLeads", express.json({ "limit": "100mb" }), async function (req, res) {

//     // const workbook = new excel.Workbook();

//     // try {

//     //     const fileDataDecoded = Buffer.from(req.body.base64File, 'base64');
//     //     await workbook.xlsx.load(fileDataDecoded);

//     //     let jsonData: any[] = [];

//     //     workbook.worksheets.forEach(function (sheet: excel.Worksheet) {

//     //         let firstRow = sheet.getRow(1);

//     //         if (!firstRow.cellCount) return;

//     //         let keys: any = firstRow.values;

//     //         sheet.eachRow((row, rowNumber) => {

//     //             if (rowNumber == 1) return;
//     //             let values: any = row.values;
//     //             let obj: any = {};

//     //             for (let i = 1; i < keys.length; i++) {
//     //                 obj[keys[i]] = values[i];
//     //             }

//     //             jsonData.push(obj);
//     //         });

//     //     });

//     //     return res.status(200).send(JSON.stringify(jsonData));
//     // }
//     // catch (err) {
//     //     res.status(400).send("Error get-xlsx-data(): " + err);
//     // }
// })


