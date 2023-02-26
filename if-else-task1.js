let mebleg = 50;
let result;
if(mebleg<100){
  console.log("5 %-li endirim");
  result = mebleg-(mebleg*0.05);
  console.log(result);
}

else if(mebleg >= 100 && mebleg <=1000){
   console.log("8 %-li endirim");
   result = mebleg-(mebleg*0.08);
   console.log(result)
}

else{
    console.log("10 %-li endirim");
    let result = mebleg-(mebleg*0.10);
    console.log(result);
}