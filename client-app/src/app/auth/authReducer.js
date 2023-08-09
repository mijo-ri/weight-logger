import ACTION_TYPES from './authActionTypes';

const authReducer = (state, action) => {
  switch (action.type) {
    case ACTION_TYPES.LOGIN_SUCCESS:
      // save token in local storage
      localStorage.setItem('token', action.payload.token);

      return {
        isAuthenticated: true,
        user: action.payload,
        error: null,
      };
    case ACTION_TYPES.LOGIN_FAIL:
      // remove token from local storage
      localStorage.removeItem('token');

      return {
        isAuthenticated: false,
        user: null,
        error: action.payload,
      };
    default:
      return state;
  }
};

export default authReducer;
