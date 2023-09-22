import { configureStore } from "@reduxjs/toolkit";
import rootReducer from "./rootReducer";
import AsyncStorage from '@react-native-async-storage/async-storage';
import { persistStore, persistReducer } from 'redux-persist'

import {reducer} from './reducer';
import { createStore } from 'redux'
// import storage from 'redux-persist/lib/storage' 

const persistConfig = {
  key: 'root',
  storage: AsyncStorage,
}

const persistedReducer = persistReducer(persistConfig, rootReducer)

export const store = createStore(persistedReducer)
export const persistor = persistStore(store)

// const store=configureStore({
//     reducer:rootReducer
// })
