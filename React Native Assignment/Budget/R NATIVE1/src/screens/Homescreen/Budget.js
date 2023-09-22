import React from 'react';
import {SafeAreaView, ScrollView, View,StyleSheet} from 'react-native';
import {Text} from '@react-native-material/core';
import {reducer} from '../redux/reducer';
import {useSelector} from 'react-redux';
import { Table, TableWrapper, Row, Rows, Col, Cols, Cell } from 'react-native-table-component';


const Budget = () => {
  let itemLists=[]
  itemLists = useSelector(state => state.reducer);
  console.log(itemLists)
  let state = {
    tableTitle: ['Item', 'Planned Amount', 'Actual Amount'],
  };
 return (
    <View style={styles.container}>
      <Table borderStyle={{borderWidth: 2, borderColor: '#c98276'}}>
        <Row
          data={state.tableTitle}
          style={styles.head}
          textStyle={styles.text}
        />

        {itemLists.map(item => (
          <Row
            data={[item.itemName, item.plannedAmmount, item.actualAmmount]}
            style={styles.head}
            textStyle={styles.text}
          />
        ))}
      </Table>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {flex: 1, padding: 16, paddingTop: 30, backgroundColor: '#00ffd6'},
  head: {
    height: 40,
    backgroundColor: '#eeeeee',
    // borderWidth: 2,
  },
  text: {margin: 6},
});

export default Budget;




















