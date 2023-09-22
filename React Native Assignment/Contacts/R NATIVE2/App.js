import { StatusBar } from 'expo-status-bar';
import { ScrollView, StyleSheet, Text, View } from 'react-native';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import NewContact from './components/NewContact';
import AppHome from './components/AppHome';
import EditProfile from './components/EditProfile';
import ContactDetail from './components/ContactDetail';
import { createDataBase } from './DatabaseServer/DatabaseServer';
import { PaperProvider } from 'react-native-paper';
const Stack = createNativeStackNavigator();

export default function App() {
  createDataBase();
  return (
    <PaperProvider>
      <NavigationContainer>
        <Stack.Navigator>
          <Stack.Screen name="Home" component={AppHome} />
          <Stack.Screen name="NewContact" component={NewContact} />
          <Stack.Screen name="Edit" component={EditProfile} />
          <Stack.Screen name="Detail" component={ContactDetail} />
        </Stack.Navigator>
      </NavigationContainer>
    </PaperProvider>

  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
