import React from 'react';
import {SafeAreaView, Text} from 'react-native';
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';

import Homepage from './src/screens/Homescreen/Homepage';
import Budget from './src/screens/Homescreen/Budget';
import {View} from 'react-native';
import {Colors} from 'react-native/Libraries/NewAppScreen';
import { Provider} from 'react-redux'
import  {store}  from './src/screens/redux/store';

// const  Homescreen=() =>{
//   return (
//     <View style={{flex: 1, alignItems: 'center', justifyContent: 'center'}}>
//       <Text>Home Screen</Text>
//     </View>
//   );
// }

const Stack = createNativeStackNavigator();

function App(): JSX.Element {
  return (
    <Provider store={store}>
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen
          name=" "
          component={Homepage}
          //options={{title: "Budget"}}
          
        />
        <Stack.Screen
          name="BList"
          component={Budget}
          options={{
            title: 'Budget List',
            headerStyle: {
              backgroundColor: 'black',
            },
            headerTintColor: 'white',
            headerTitleStyle: {
              color: 'white',
              fontWeight: 'bold',
            },
          }}
        />
      </Stack.Navigator>
    </NavigationContainer>
    </Provider>
  );
}

export default App;
