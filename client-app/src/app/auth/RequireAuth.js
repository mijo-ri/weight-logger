import { Navigate, Outlet, useLocation } from 'react-router-dom';

import { useAuth } from './AuthContext';

const RequireAuth = () => {
  const { isAuthenticated } = useAuth();
  const location = useLocation();

  console.log('isAuthenticated', isAuthenticated);

  if (!isAuthenticated) {
    return <Navigate to='/login' state={{ from: location }} />;
  }

  return <Outlet />;
};

export default RequireAuth;
