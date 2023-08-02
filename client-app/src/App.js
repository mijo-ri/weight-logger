import axios from 'axios';
import React from 'react';

import Logs from './features/logs/Logs';

axios.defaults.baseURL = process.env.REACT_APP_API_URL;

// TODO: Remove this hardcoded token
axios.defaults.headers.common['Authorization'] =
  'Bearer eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Im1pZ2kiLCJuYW1laWQiOiJkYzc2N2I3NS0xZjQ0LTRmZTgtYjc2Zi05NzhhYzFhZmY3NWYiLCJlbWFpbCI6Im1pY2hpLnJpZXNlckBnbWFpbC5jb20iLCJuYmYiOjE2OTA4NzA4MTQsImV4cCI6MTY5MTQ3NTYxNCwiaWF0IjoxNjkwODcwODE0fQ.x_HX3OGK90wy5wPqjFUJ9vvQb8qL0hfrN3d7j_qa7Xz6iXHyI8Bjp3y8MJsVXL3F0H43D2F3RMF308qJsANhsg';

const App = () => {
  return (
    <div>
      <Logs />
    </div>
  );
};

export default App;
