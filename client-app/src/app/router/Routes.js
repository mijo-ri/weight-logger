import { createBrowserRouter } from 'react-router-dom';

import Login from '../../features/login/Login';
import Layout from '../layout/Layout';

const router = createBrowserRouter([
  {
    path: '/',
    element: <Layout />,
    children: [
      {
        path: 'logs',
        element: <div>Logs</div>,
      },
    ],
  },
  {
    path: '/login',
    element: <Login />,
  },
]);

export default router;
