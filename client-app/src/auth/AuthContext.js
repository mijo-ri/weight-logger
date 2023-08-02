import { createContext, useContext, useReducer } from 'react';
import axios from 'axios';

import authReducer from './authReducer';
import ACTION_TYPES from './authActionTypes';

const INITIAL_STATE = {
  isAuthenticated: false,
  user: null,
  error: null,
};

export const AuthContext = createContext();

const AuthProvider = ({ children }) => {
  const [state, dispatch] = useReducer(authReducer, INITIAL_STATE);

  // Login user
  const login = async (email, password) => {
    try {
      const response = await axios.post('/auth/login', {
        email,
        password,
      });
      const data = await response.data;

      dispatch({ type: ACTION_TYPES.LOGIN_SUCCESS, payload: data });
    } catch (error) {
      dispatch({ type: ACTION_TYPES.LOGIN_FAIL, payload: error });
    }
  };

  return (
    <AuthContext.Provider
      value={{
        isAuthenticated: state.isAuthenticated,
        user: state.user,
        login,
      }}
    >
      {children}
    </AuthContext.Provider>
  );
};

export default AuthProvider;

export const useAuth = () => useContext(AuthContext);
