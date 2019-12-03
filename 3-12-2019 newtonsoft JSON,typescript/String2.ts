type FruitsName = "Apple" | "Mango" | "Orange";  
function showFruitName(fruitsName: FruitsName): void {  
    console.log(fruitsName);  
}  
showFruitName('Mango');   //ok   
showFruitName('Apple');   //ok   
showFruitName('Banana');  //it gives compilation error beacuse of banana is not assigned.