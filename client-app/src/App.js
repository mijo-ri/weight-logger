import axios from 'axios';
import React from 'react';

import AuthProvider from './auth/AuthContext';
import Login from './features/login/Login';

axios.defaults.baseURL = process.env.REACT_APP_API_URL;
if (localStorage.token) {
  axios.defaults.headers.common[
    'Authorization'
  ] = `Bearer ${localStorage.token}`;
} else {
  delete axios.defaults.headers.common['Authorization'];
}

const App = () => {
  return (
    <AuthProvider>
      <Login />
    </AuthProvider>
  );
};

export default App;
