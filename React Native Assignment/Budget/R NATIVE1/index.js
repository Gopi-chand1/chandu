import {AppRegistry} from 'react-native';
import App from './App';
import {name as appName} from './app.json';
import { Provider} from 'react-redux';


import { Text } from 'react-native';
import { PersistGate } from 'redux-persist/integration/react'



import {store, persistor} from './src/screens/redux/store';
const AppRedux=()=>(
    <Provider store={store}>
    <PersistGate loading={<Text>Loading...</Text>} persistor={persistor}>
      <App/>
    </PersistGate>
    </Provider>
)

AppRegistry.registerComponent(appName, () => AppRedux);
