import { SAVE_ITEM,LIST_ITEMS } from "./constaints";

export function saveItem(item){
    return{
        type:SAVE_ITEM,
        data:item
    }

}


export function listItems(){
    return{
        type:LIST_ITEMS
    }

}