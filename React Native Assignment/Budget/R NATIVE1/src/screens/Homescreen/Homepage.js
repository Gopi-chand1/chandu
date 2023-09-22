import React, {useState} from 'react';
import {SafeAreaView, View, Alert} from 'react-native';
import {Button, TextInput, Text} from '@react-native-material/core';
import {useDispatch, useSelector} from 'react-redux';
import {saveItem, listItems} from '../redux/action';

const Homepage = ({navigation}) => {
  const dispatch = useDispatch();
  const [itemName, setItemName] = useState('');
  const [plannedAmmount, setPlannedAmmount] = useState('');
  const [actualAmmount, setActualAmmount] = useState('');

  function handelSaveItem() {
    dispatch(saveItem({itemName, plannedAmmount, actualAmmount}));
    setItemName('');
    setPlannedAmmount('');
    setActualAmmount('');
    Alert.alert('Data Saved Successfully');
  };

  return (
    <View 
    style={{
      backgroundColor: '#1111e0',
    }}>
      <Text
        style={{
          textAlign: 'left',
          paddingLeft: 35,
          backgroundColor: '#ed1b24',
          color: 'white',
          textAlignVertical: 'center',
          height: 50,
          fontSize: 23,
          fontWeight: 'bold',
        }}>
         YEARLY BUDGET
      </Text>
      <TextInput
        variant="outlined"
        //   label="Name"
        placeholder="Item name"
        style={{margin: 16}}
        value={itemName}
        onChange={event => setItemName(event.nativeEvent.text)}
      />
      <TextInput
        variant="outlined"
        // label="Planned Amount"
        placeholder="Planned Expence"
        keyboardType="numeric"
        style={{margin: 16}}
        value={plannedAmmount}
        onChange={event => setPlannedAmmount(event.nativeEvent.text)}
      />
      <TextInput
        variant="outlined"
        placeholder="Actual Expence"
        keyboardType="numeric"
        // label="Actual Amount"
        style={{margin: 16}}
        value={actualAmmount}
        onChange={event => setActualAmmount(event.nativeEvent.text)}
      />
      <View style={{flexDirection: 'row', alignSelf: 'center'}}>
        <Button
          style={{marginRight: 15,
          backgroundColor: '#4297ec'}}
          title="Save"
          onPress={() => handelSaveItem()}
        />
        <Button
          style={{marginLeft: 15,
            backgroundColor: '#8b658b'}}
          title="Item list"
          onPress={() => navigation.navigate('BList')}
        />
      </View>
    </View>
  );
};


export default Homepage;





