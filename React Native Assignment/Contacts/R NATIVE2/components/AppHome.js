import React from 'react';
import { StatusBar } from 'expo-status-bar';
import { FlatList, ScrollView, StyleSheet, Text, View, TouchableOpacity, Image } from 'react-native';
import { fetchAllContact, toggleFavorite } from '../DatabaseServer/DatabaseServer';
import { useState } from 'react';
import { useFocusEffect } from '@react-navigation/native';
import { IconButton } from 'react-native-paper';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';

export default function AppHome({ navigation }) {
  const [contactsArr, setContactsArr] = useState([]);

  useFocusEffect(
    React.useCallback(() => {
      (async () => {
        const fetchedContacts = await fetchAllContact();
        setContactsArr(fetchedContacts);
      })();
    }, [])
  );
  console.log(contactsArr);

  const handleFavorite = async (id) => {
    await toggleFavorite(id);
    const updatedContacts = await fetchAllContact();
    setContactsArr(updatedContacts);
  };

  const renderItem = ({ item }) => (
    <TouchableOpacity
      style={styles.contactButton}
      onPress={() => navigation.navigate('Detail', { id: item.id })}
    >
      
      {item.imgpath==null ? (<View style={styles.contactImagePlaceholder}>
            <MaterialCommunityIcons name="account-circle" size={50} color="pink" />
          </View>
            
        
        ) : (
          <Image source={{ uri: item.imgpath }} style={styles.contactImage} />
        )}

      <View style={styles.contactInfo}>
        <Text style={styles.contactName}>{item.name}</Text>
        <TouchableOpacity
          style={styles.favoriteIcon}
          onPress={() => handleFavorite(item.id)}
        >
          <MaterialCommunityIcons
            name={item.favorite ? 'star' : 'star-outline'}
            size={20}
            color={item.favorite ? 'gold' : 'gray'}
          />
        </TouchableOpacity>
      </View>
    </TouchableOpacity>
  );

  return (
    <View style={styles.container}>
      <StatusBar style="auto" />
      <FlatList
        data={contactsArr}
        renderItem={renderItem}
        keyExtractor={(item) => item.id.toString()}
        style={styles.flatList}
      />
      <TouchableOpacity
        style={styles.btn}
        onPress={() => navigation.navigate('NewContact')}
      >
        <IconButton
          icon={({ size, color }) => (
            <MaterialCommunityIcons name="plus" size={size} color={color} />
          )}
          size={30}
          color="black"
        />
      </TouchableOpacity>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#ede3d8',
  },
  flatList: {
    paddingHorizontal: 20,
  },
  contactButton: {
    paddingVertical: 16,
    borderBottomWidth: 1,
    borderBottomColor: '#000000',
    alignItems: 'center',
    flexDirection: 'row',
  },
  contactImage: {
    width: 50,
    height: 50,
    borderRadius: 25,
    marginRight: 10,
  },
  contactImagePlaceholder: {
    width: 50,
    height: 50,
    borderRadius: 25,
    marginRight: 10,
    backgroundColor: '#ccc',
    alignItems: 'center',
    justifyContent: 'center',
  },
  contactInfo: {
    flex: 1,
    flexDirection: 'row',
    alignItems: 'center',
  },
  contactName: {
    fontSize: 16,
  },
  favoriteIcon: {
    marginLeft: 'auto',
  },
  btn: {
    position: 'absolute',
    bottom: 20,
    right: 20,
    width: 70,
    height: 70,
    borderRadius: 35,
    backgroundColor: 'blue',
    alignItems: 'center',
    justifyContent: 'center',
    elevation: 5,
  },
  btnText: {
    fontSize: 30,
    color: 'white',
  },
});
