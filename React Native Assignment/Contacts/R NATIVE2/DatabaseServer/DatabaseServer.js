import * as SQLite from "expo-sqlite"

const databaseName='contactAppDatabase'
const databaseVersion='1.0'
const databaseDisplayName='contactAppDatabase'
const databaseSize=200000

const db=SQLite.openDatabase(
    databaseName,
    databaseVersion,
    databaseDisplayName,
    databaseSize
);

export const createDataBase = () => {
    db.transaction((tx) => {
            tx.executeSql("CREATE TABLE IF NOT EXISTS contacts(id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(30) ,mobileno VARCHAR(10), landlineno VARCHAR(15),imgpath VARCHAR(5000) , isfav INTEGER)",[],
            ()=>{
                console.log('Database and table created successfully')
            },
            (error)=>
            {
                console.log('Error creating table',error)
            })
          })
}

export const insertData = (name,mobile,landlineno,imgpath,isfav) => {
    db.transaction((tx) => {
        tx.executeSql("INSERT INTO contacts(name, mobileno,landlineno,imgpath,isfav) VALUES(?,?,?,?,?)",[name,mobile,landlineno,imgpath,isfav],
        ()=>{
            console.log('new data inserted successfully')
        },
        (error)=>
        {
            console.log('Error inserting data into table',error)
        })
      })

}

export const fetchAllContact = () => {
    return new Promise((resolve, reject) => {
        db.transaction((tx) => {
          tx.executeSql(
            "SELECT * FROM contacts",
            null,
            (objtx, rs) => {
                const contacts = [];
                for (let i = 0; i < rs.rows.length; i++) {
                  contacts.push(rs.rows.item(i));
                }
                resolve(contacts);
            },
            (error) => {
              reject(error);
            }
             );
    });
  });
}

export const detail = (id) => {

    return new Promise((resolve, reject) => {
        db.transaction((tx) => {
          tx.executeSql(
            "SELECT * FROM contacts WHERE id = ?",
            [id],
            (objtx, rs) => {
              if (rs.rows.length >= 0) {
                const detail = rs.rows.item(0);
                resolve(detail);
              } else {
                resolve(null);
              }
            },
            (error) => {
              reject(error);
            }
          );
        });
      });
        
}

export const editData = (name,mobile,landlineno,id) => {
    db.transaction((tx) => {
        tx.executeSql(
          'UPDATE contacts SET name = ?, mobileno = ?, landlineno = ? WHERE id = ?',
          [name,mobile,landlineno,id],
          (txObj, resultSet) => {
            console.log('Update successful');
          },
          (txObj, error) => {
            console.log('Error updating row:', error);
          }
        );
      });
      
}

export const deleteData = (id) => {
    db.transaction((tx) => {
        tx.executeSql(
          'DELETE FROM contacts WHERE id = ?',
          [id],
          (txObj, resultSet) => {
            console.log('deleted successful');
          },
          (txObj, error) => {
            console.log('Error deleteing data:', error);
          }
        );
      });
}

export const deleteTable = () => {

}

export const toggleFavorite = (id) => {
  return new Promise((resolve, reject) => {
    db.transaction((tx) => {
      tx.executeSql(
        'UPDATE contacts SET favorite = NOT favorite WHERE id = ?',
        [id],
        (_, { rowsAffected }) => {
          if (rowsAffected > 0) {
            resolve();
          } else {
            reject(new Error('Contact not found'));
          }
        },
        (_, error) => {
          reject(error);
        }
      );
    });
  });
};

