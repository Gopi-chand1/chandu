import { StatusBar } from 'expo-status-bar';
import { ScrollView, StyleSheet, Text, View,TextInput,Button } from 'react-native';
import { editData } from '../DatabaseServer/DatabaseServer';
import { useState } from 'react';
export default function EditProfile({route, navigation }) {
    const userData= route.params.userData;
    const [name, setName] = useState(userData.name)
    const [mobile, setMobile] = useState(userData.mobileno)
    const [landLine, setLandLine] = useState(userData.landlineno)

    const formSubmit = () => {

        editData(name,mobile,landLine,userData.id)
        setName('')
        setMobile('')
        setLandLine('')
        navigation.navigate('Home')
      }

  return (
    <View style={styles.container}>
    <TextInput placeholder='Name' style={styles.input} value={name} onChangeText={(data) => { setName(data) }} />
    <TextInput placeholder='Mobile No' style={styles.input} value={mobile} onChangeText={(data) => { setMobile(data) }} />
    <TextInput placeholder='LandLine No' style={styles.input} value={landLine} onChangeText={(data) => { setLandLine(data) }} />

    <View>
      <Button title='save' style={[styles.btn, styles.btnBlue]} onPress={formSubmit} />
    </View>

  </View>
  );
}

const styles = StyleSheet.create({
    container: {
      flex: 1,
    backgroundColor: '#ede3d8',
      alignItems: 'center',
      justifyContent: 'center'
    },
    input: {
      margin: 5,
      padding: 5,
      borderWidth: 5,
      fontSize: 20,
      borderColor: "green",
      borderRadius: 5
    },
    btn: {
      fontSize: 15,
      margin: 5,
      padding: 5,
      borderRadius: 5
    },
  
    btnBlue: {
      backgroundColor: "blue",
      color: "black"
    },
    btnBlue: {
  
      backgroundColor: "blue",
    }
  });
