import React from 'react';
import { UserIcon } from '@heroicons/react/24/outline';

const Header = () => {
  return (
    <div className='sticky z-50 bg-slate-300 p-4'>
      <div className='flex items-center justify-between'>
        <a href='/' className='font-semibold text-lg'>
          Weight Logger
        </a>
        <UserIcon className='h-6 w-6' />
      </div>
    </div>
  );
};

export default Header;
