import React, { useState, useEffect, Fragment } from 'react';
import Profile from './Profile'
import Menu from './Menu'
import axios from 'axios'

//Redux
import { Provider } from "react-redux";
import store from "./Redux/Stores";
import ProfileList from './ProfileList';

function App() {

  useEffect(() => {
    axios.get("http://localhost:5000/api/nhanvien").then(res => console.log(res)).catch(err => console.log(err)
    )

  }, [])

  return (
    <Provider store={store}>
      <Fragment>
        <ProfileList />
        <Menu />
      </Fragment>
    </Provider>
  );
}

export default App;
