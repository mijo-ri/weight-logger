import React from 'react';
import { Outlet } from 'react-router-dom';

const Layout = () => {
  return (
    <>
      <div className='bg-slate-500'>Header</div>
      <Outlet />
      <div className='bg-slate-500'>Footer</div>
    </>
  );
};

export default Layout;
