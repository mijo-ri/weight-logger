import { useForm } from 'react-hook-form';
import { Button } from '@mui/material';
import * as yup from 'yup';
import { yupResolver } from '@hookform/resolvers/yup';

import { useAuth } from '../../auth/AuthContext';
import TextField from '../../components/form/TextField';

const Login = () => {
  const validationSchema = yup.object().shape({
    email: yup.string().required().email(),
    password: yup.string().required(),
  });

  const { control, handleSubmit } = useForm({
    defaultValues: {
      email: '',
      password: '',
    },
    resolver: yupResolver(validationSchema),
  });

  const { login, isAuthenticated } = useAuth();

  console.log('isAuthenticated', isAuthenticated);

  const onSubmit = (data) => {
    console.log('data', data);

    login(data.email, data.password);
  };

  return (
    <form onSubmit={handleSubmit(onSubmit)}>
      <div>
        <TextField control={control} name='email' placeholder='Email' />
      </div>
      <div>
        <TextField
          control={control}
          name='password'
          type='password'
          placeholder='Password'
        />
      </div>
      <div>
        <Button type='submit'>Login</Button>
      </div>
    </form>
  );
};

export default Login;
