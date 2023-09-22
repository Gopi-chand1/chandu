import { SAVE_ITEM,LIST_ITEMS } from "./constaints";

const initialState=[
   
   
];

export const reducer=(state=initialState,action)=>{

    switch(action.type){
        case SAVE_ITEM : 
       { 
        return [...state,
               action.data
        ]}
    
        

        
            

        default: return state;
    }
}