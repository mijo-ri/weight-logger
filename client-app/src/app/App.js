import axios from 'axios';
import React from 'react';
import { RouterProvider } from 'react-router-dom';

import AuthProvider from './auth/AuthContext';
import router from './config/routesConfig';

// Axios configuration
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
      <RouterProvider router={router} />
    </AuthProvider>
  );
};

export default App;
