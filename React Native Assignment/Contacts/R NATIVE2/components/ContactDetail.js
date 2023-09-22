import { StatusBar } from 'expo-status-bar';
import { TouchableOpacity, ScrollView, StyleSheet, Text, View } from 'react-native';
import { useFocusEffect } from '@react-navigation/native';
import { detail } from '../DatabaseServer/DatabaseServer';
import { deleteData } from '../DatabaseServer/DatabaseServer';
import { useState } from 'react';
import React from 'react';
import { IconButton } from 'react-native-paper';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';

export default function ContactDetail({ route, navigation }) {
  const { id } = route.params;
  const [userDetail, setUserDetail] = useState({});

  useFocusEffect(
    React.useCallback(() => {
      (async () => {
        const fetchedDetail = await detail(id);
        setUserDetail(fetchedDetail);
      })();
    }, [])
  );
  console.log(userDetail);
  const handleDelete = () => {
    deleteData(userDetail.id);
    navigation.navigate('Home');
  };



  return (
    <View style={styles.container}>
      <Text>{userDetail.name}</Text>
      <Text>{userDetail.mobileno}</Text>
      <Text>{userDetail.landlineno}</Text>
      <View style={styles.bthContainer}>
        <TouchableOpacity
          style={styles.btn1}
          onPress={() => navigation.navigate('Edit', { userData: userDetail })}
        >
          <IconButton
            icon={({ size, color }) => (
              <MaterialCommunityIcons name="account-edit" size={size} color={color} />
            )}
            size={30}
            color="white"
          />
        </TouchableOpacity>

        <TouchableOpacity icon="delete"
          style={styles.btn}
          onPress={handleDelete}
        >
          <IconButton
            icon={({ size, color }) => (
              <MaterialCommunityIcons name="delete" size={size} color={color} />
            )}
            size={30}
            color="white"
          />
        </TouchableOpacity>

      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#ede3d8',
    alignItems: 'center',
    justifyContent: 'center',
  },
  bthContainer: {
    flexDirection: "row",
    backgroundColor: '#ede3d8',
    alignItems: 'center',
    justifyContent: 'center',
  },


  btn: {
    width: 40,
    height: 20,
    borderRadius: 5,
    backgroundColor: 'red',
    alignItems: 'center',
    justifyContent: 'center',
    elevation: 5,
  },
  btn1: {
    width: 40,
    height: 20,
    borderRadius: 5,
    backgroundColor: 'teal',
    alignItems: 'center',
    justifyContent: 'center',
    elevation: 5,
  },
  btnText: {
    fontSize: 20,
    color: 'white',
  },
  btnfav: {
    width: 60,
    height: 40,
    borderRadius: 10,
    backgroundColor: 'yellow',
    alignItems: 'center',
    justifyContent: 'center',
    elevation: 5,
  },
  btnfavtext: {
    fontSize: 20,
    color: 'white',
  },
});
