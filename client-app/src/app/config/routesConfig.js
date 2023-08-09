import { createBrowserRouter } from 'react-router-dom';

import Layout from '../layout/Layout';
import Login from '../pages/login/Login';
import RequireAuth from '../auth/RequireAuth';

const router = createBrowserRouter([
  {
    path: '/',
    element: <RequireAuth />,
    children: [
      {
        element: <Layout />,
        children: [
          {
            path: 'logs',
            element: <div>Logs</div>,
          },
        ],
      },
    ],
  },
  {
    path: '/login',
    element: <Login />,
  },
]);

export default router;
