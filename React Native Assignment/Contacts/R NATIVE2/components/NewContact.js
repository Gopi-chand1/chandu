import React, { useState } from 'react';
import { TouchableOpacity, StyleSheet, Text, TextInput, View, Button, Image } from 'react-native';
import * as ImagePicker from 'expo-image-picker';
import { insertData } from '../DatabaseServer/DatabaseServer';
import * as SQLite from 'expo-sqlite';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';

export default function NewContact({ navigation }) {
  const [name, setName] = useState('');
  const [mobile, setMobile] = useState('');
  const [landLine, setLandLine] = useState('');
  const [image, setImage] = useState(null);
  const [isFavorite, setIsFavorite] = useState(false); // New state variable for favorite status
  const db = SQLite.openDatabase('contact.db');

  const formSubmit = () => {
    insertData(name, mobile, landLine, image, isFavorite); // Pass isFavorite to the insertData function

    setName('');
    setMobile('');
    setLandLine('');
    setImage(null);
    setIsFavorite(false);
    navigation.navigate('Home');
  };

  const pickImage = async () => {
    let permissionResult = await ImagePicker.requestMediaLibraryPermissionsAsync();
    if (permissionResult.granted === false) {
      alert('Permission to access camera roll is required!');
      return;
    }

    let pickerResult = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsEditing: true,
      aspect: [1, 1],
      quality: 1,
    });

    if (!pickerResult.cancelled) {
      setImage(pickerResult.uri);
    }
  };

  const toggleFavorite = () => {
    setIsFavorite(!isFavorite);
  };

  return (
    <View style={styles.container}>
      <TouchableOpacity
        style={styles.imageContainer}
        onPress={pickImage}
      >
        {image ? (
          <Image source={{ uri: image }} style={styles.image} />
        ) : (
          <View style={styles.cameraIcon}>
            <MaterialCommunityIcons name="camera" size={30} color="blue" />
          </View>
        )}
      </TouchableOpacity>

      <TextInput
        placeholder="Name"
        style={styles.input}
        value={name}
        onChangeText={(data) => {
          setName(data);
        }}
      />
      <TextInput
        placeholder="Mobile No"
        style={styles.input}
        value={mobile}
        onChangeText={(data) => {
          setMobile(data);
        }}
      />
      <TextInput
        placeholder="LandLine No"
        style={styles.input}
        value={landLine}
        onChangeText={(data) => {
          setLandLine(data);
        }}
      />

      <TouchableOpacity
        style={styles.favoriteButton}
        onPress={toggleFavorite}
      >
        <MaterialCommunityIcons
          name={isFavorite ? 'star' : 'star-outline'}
          size={30}
          color={isFavorite ? 'gold' : 'gray'}
        />
      </TouchableOpacity>

      <Button title="Save" onPress={formSubmit}/>
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
  input: {
    margin: 5,
    padding: 5,
    borderWidth: 5,
    fontSize: 20,
    borderColor: 'black',
    borderRadius: 5,
  },
  imageContainer: {
    marginVertical: 10,
    width: 100,
    height: 100,
    borderRadius: 100,
    overflow: 'hidden',
    backgroundColor: '#e7e373',
    alignItems: 'center',
    justifyContent: 'center',
  },
  image: {
    width: '100%',
    height: '100%',
  },
  cameraIcon: {
    alignItems: 'center',
    justifyContent: 'center',
  },
  favoriteButton: {
    position: 'absolute',
    top: 10,
    right: 10,
  },
});
